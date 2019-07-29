using PROBLEM_CLASSIFIER_W_NEURAL_NETWORK.Classes.NeuralNetwork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PROBLEM_CLASSIFIER_W_NEURAL_NETWORK.UserControls
{
    /// <summary>
    /// Interaction logic for TrainingControl.xaml
    /// </summary>
    public partial class TrainingControl : UserControl
    {
        NeuralNetwork nn;
        List<double[]> inputs;
        List<double[]> outputs;
        BackgroundWorker worker;

        int reps;
        string state;

        public TrainingControl()
        {
            InitializeComponent();

            inputs = new List<double[]>();
            outputs = new List<double[]>();
            reps = 0;

            worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;

            state = "";
        }

        private void btn_trainingSetsBrowse_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.tb_trainingSets.Text = ofd.FileName;
                StreamReader sr = new StreamReader(ofd.FileName);

                this.inputs = new List<double[]>();
                this.outputs = new List<double[]>();

                string[] atm;
                double[] atmInput;
                double[] atmOutput;
                string[] atmInputLine;
                string[] atmOutputLine;

                while (!sr.EndOfStream)
                {
                    atm = sr.ReadLine().Split(':');
                    atmInput = new double[atm[0].Split(';').Length];
                    atmOutput = new double[atm[1].Split(';').Length];

                    atmInputLine = atm[0].Split(';');
                    for (int i = 0; i < atmInput.Length; i++)
                    {
                        atmInput[i] = Convert.ToDouble(atmInputLine[i]);
                    }

                    atmOutputLine = atm[1].Split(';');
                    for (int i = 0; i < atmOutput.Length; i++)
                    {
                        atmOutput[i] = Convert.ToDouble(atmOutputLine[i]);
                    }

                    inputs.Add(atmInput);
                    outputs.Add(atmOutput);
                }
                sr.Close();

                MessageBox.Show("Success!");
            }
        }

        private void btn_neuralNetworkBrowse_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.tb_neuralNetwork.Text = ofd.FileName;
                NetworkHelper.CreateNetworkByTxt(ref nn, ofd.FileName);
            }
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            if (this.tb_trainingSets.Text.Length > 0 && this.tb_neuralNetwork.Text.Length > 0 && this.tb_reps.Text.Length > 0)
            {
                this.btn_start.IsEnabled = false;
                this.btn_saveNetwork.IsEnabled = true;

                this.reps = Convert.ToInt32(this.tb_reps.Text.ToString());

                this.pb_training.Value = 0;
                this.pb_training.Minimum = 0;
                this.pb_training.Maximum = this.reps;

                TextRange txt = new TextRange(this.rtb_log.Document.ContentStart, this.rtb_log.Document.ContentEnd);
                txt.Text = "Training...\n";

                try
                {
                    worker.RunWorkerAsync();
                }
                catch (Exception)
                {
                    this.rtb_log.AppendText("Failed.");
                }
            }
            else MessageBox.Show("Browse the files and set the reps first!");
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.rtb_log.AppendText(e.UserState.ToString() + "\n");
            this.rtb_log.ScrollToEnd();
            this.pb_training.Value = e.ProgressPercentage;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int j = 0; j < this.reps; j++)
            {
                for (int i = 0; i < inputs.Count; i++)
                {
                    try
                    {
                        lock (nn)
                        {
                            nn.FeedForward(inputs[i]);
                            nn.BackProp(outputs[i]);
                        }
                    }
                    catch (Exception)
                    {
                        state = "failed";
                        break;
                    }

                }
                if (state == "failed") break;
                else worker.ReportProgress(j + 1, String.Format("Training... ({0}/{1})", j + 1, this.reps));
            }
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.btn_start.IsEnabled = true;
            this.pb_training.Value = 0;
            if(state == "") this.rtb_log.AppendText("Completed!\n");
            else this.rtb_log.AppendText( state + "\n");
        }

        private void btn_saveNetwork_Click(object sender, RoutedEventArgs e)
        {
            lock (nn)
            {
                NetworkHelper.SaveNetToFile(nn, "neuralNetwork.txt");
                this.rtb_log.AppendText("Network saved! \n");
            }
        }
    }
}

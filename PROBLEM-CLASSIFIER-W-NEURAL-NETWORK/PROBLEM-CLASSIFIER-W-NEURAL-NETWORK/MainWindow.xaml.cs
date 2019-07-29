using PROBLEM_CLASSIFIER_W_NEURAL_NETWORK.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace PROBLEM_CLASSIFIER_W_NEURAL_NETWORK
{
    public partial class MainWindow : Window
    {
        CreateLearningLabelsControl cllc;
        CreateLearningSetControl clsc;
        MakeNeuralNetworkControl mnnc;
        TrainingControl tc;

        List<string> labels;

        public MainWindow()
        {
            InitializeComponent();
            labels = new List<string>();
        }

        private void btn_learningLabels_Click(object sender, RoutedEventArgs e)
        {
            if (cllc == null) cllc = new CreateLearningLabelsControl();
            userControlHolder.Content = cllc;
        }

        private void btn_learningSet_Click(object sender, RoutedEventArgs e)
        {
            labels = (cllc == null)? null: cllc.GetLabels();

            if (labels != null && labels.Count > 0)
            {
                if (clsc == null) clsc = new CreateLearningSetControl();
                clsc.refreshLabels(this.labels);
                userControlHolder.Content = clsc;
            }
            else MessageBox.Show("You need to set at least one or more label first!");
        }

        private void btn_makeNeuralNetwork_Click(object sender, RoutedEventArgs e)
        {
            if (mnnc == null) mnnc = new MakeNeuralNetworkControl();
            userControlHolder.Content = mnnc;
        }

        private void btn_training_Click(object sender, RoutedEventArgs e)
        {
            if (tc == null) tc = new TrainingControl();
            userControlHolder.Content = tc;
        }
    }
}

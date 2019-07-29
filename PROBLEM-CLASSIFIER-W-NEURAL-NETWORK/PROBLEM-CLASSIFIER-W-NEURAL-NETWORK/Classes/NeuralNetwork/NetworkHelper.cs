using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEM_CLASSIFIER_W_NEURAL_NETWORK.Classes.NeuralNetwork
{
    class NetworkHelper
    {
        public static void SaveNetToFile(NeuralNetwork net, string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);

            for (int i = 0; i < net.Layers.Length; i++)
            {
                sw.Write(net.Layers[i].NumberOfInput.ToString());
                sw.Write(":");
                if (i == net.Layers.Length - 1) sw.Write(net.Layers[i].NumberOfOutput.ToString());
            }
            sw.WriteLine(":" + net.Activation);

            foreach (Layer layer in net.Layers)
            {
                sw.WriteLine(layer.NumberOfInput.ToString() + ":" + layer.NumberOfOutput.ToString());

                for (int i = 0; i < layer.Output.Length; i++)
                {
                    sw.Write(layer.Output[i].ToString());
                    if (i < layer.Output.Length - 1) sw.Write(":");
                }
                sw.WriteLine();

                for (int i = 0; i < layer.Input.Length; i++)
                {
                    sw.Write(layer.Input[i].ToString());
                    if (i < layer.Input.Length - 1) sw.Write(":");
                }
                sw.WriteLine();

                for (int i = 0; i < layer.NumberOfOutput; i++)
                {
                    for (int j = 0; j < layer.NumberOfInput; j++)
                    {
                        sw.Write(layer.Weights[i, j].ToString());
                        if (j < layer.NumberOfInput - 1) sw.Write(":");
                    }
                    sw.WriteLine();
                }
            }
            sw.Close();
        }

    }
}

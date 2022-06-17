using MulticlassClassifier.Data;
using System;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Neuro;
using Accord.Neuro.Learning;
using System.Collections;
using Accord.Controls;
using Accord;

namespace MulticlassClassifier
{
    public partial class Form1 : Form
    {
        List<Pixel> pixels;
        double learningRate;
        float minXvalue, maxXValue;
        const float n = 1;
        int errorSum, lastIteration, maxIterations, maxError, classesCount;
        private static List<Color> dataSereisColors = new List<Color>() {
                                                                     Color.Red,     Color.Green,
                                                                     Color.Blue,   Color.DarkOrange,
                                                                     Color.Violet,  Color.Brown,
                                                                     Color.Black,   Color.Pink,
                                                                     Color.Olive,   Color.Navy, };

        public Form1()
        {
            InitializeComponent();
            pixels = new List<Pixel>();
            learningRateTextbox.Text = "0.1";
            iterationsTextBox.Text = "1000";
            maxErrorTextbox.Text = "0";
            checkBox1.Checked = true;
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            int iteration = 0;
            lastIteration = iteration;
            errorSum = int.MaxValue;
            bool is3D = pixels[0].Z != 0;
            maxError = int.Parse(maxErrorTextbox.Text);
            maxIterations = int.Parse(iterationsTextBox.Text);
            ValidateLearningRate(learningRate);

            double[] optimW0 = new double[classesCount], optimW1 = new double[classesCount], optimW2 = new double[classesCount], optimW3 = new double[classesCount];
            bool needToStop = false;
            // prepare learning data
            double[][] input = new double[pixels.Count][];

            double[][] output = new double[pixels.Count][];

            if (!is3D)
            {
                for (int i = 0; i < pixels.Count; i++)
                {
                    input[i] = new double[2];
                    output[i] = new double[classesCount];

                    // set input
                    input[i][0] = pixels[i].X;
                    input[i][1] = pixels[i].Y;

                    // set output               
                    output[i][pixels[i].Group] = 1;
                }
            }
            else
            {
                for (int i = 0; i < pixels.Count; i++)
                {
                    input[i] = new double[3];
                    output[i] = new double[classesCount];

                    // set input
                    input[i][0] = pixels[i].X;
                    input[i][1] = pixels[i].Y;
                    input[i][2] = pixels[i].Z;

                    // set output               
                    output[i][pixels[i].Group] = 1;
                }
            }
            ActivationNetwork network;
            if (!is3D)
                network = new ActivationNetwork(new ThresholdFunction(), 2, classesCount);
            else
                network = new ActivationNetwork(new ThresholdFunction(), 3, classesCount);

            ActivationLayer layer = network.Layers[0] as ActivationLayer;

            if (!checkBox1.Checked)
            {
                foreach (ActivationLayer networkLayer in network.Layers)
                {
                    foreach (ActivationNeuron neuron in networkLayer.Neurons)
                    {
                        for (var i = 0; i < neuron.Weights.Length; i++)
                        {
                            neuron.Weights[i] = 0;
                        }
                        neuron.Threshold = 0;
                    }
                }
            }

            PerceptronLearning teacher = new PerceptronLearning(network);

            teacher.LearningRate = learningRate;


            // iterations
            while (!needToStop && iteration < maxIterations)
            {
                var iterationError = 0;

                teacher.RunEpoch(input, output);
                iteration++;

                for (int i = 0; i < pixels.Count; i++)
                {
                    var result = network.Compute(input[i]);
                    if (!result.ToList().SequenceEqual(output[i]))
                    {
                        iterationError++;
                    }
                }

                if (iterationError < errorSum)
                {
                    lastIteration = iteration;
                    errorSum = iterationError;
                    for (int i = 0; i < classesCount; i++)
                    {
                        optimW0[i] = ((ActivationNeuron)layer.Neurons[i]).Threshold;
                        optimW1[i] = layer.Neurons[i].Weights[0];
                        optimW2[i] = layer.Neurons[i].Weights[1];
                        if (is3D)
                        {
                            optimW3[i] = layer.Neurons[i].Weights[2];
                        }
                    }
                    if (iterationError == 0 || maxError > errorSum)
                        break;
                }
            }

            passedIterationsTextbox.Text = iteration.ToString();
            errorTextbox.Text = errorSum.ToString();
            if (!is3D)
            {
                for (int j = 0; j < classesCount; j++)
                {
                    double k = (optimW2[j] != 0) ? (-optimW1[j] / optimW2[j]) : 0;
                    double b = (optimW2[j] != 0) ? (-optimW0[j] / optimW2[j]) : 0;
                    double[,] classifier = new double[2, 2] {
                            { chart.RangeX.Min, chart.RangeX.Min * k + b },
                            { chart.RangeX.Max, chart.RangeX.Max * k + b }
                                                                };

                    // update chart
                    chart.UpdateDataSeries(string.Format("classifier" + j), classifier);
                }
                SetResultMessage(optimW0, optimW1, optimW2);
            }
            else
            {
                SetResultMessage(optimW0, optimW1, optimW2, optimW3);
            }

        }

        private void ValidateLearningRate(double learningRateValue)
        {
            learningRate = double.Parse(learningRateTextbox.Text);
            if (learningRate < 0)
            {
                learningRate = 0;
                learningRateTextbox.Text = "0";
            }
            if (learningRate > 1)
            {
                learningRate = 1;
                learningRateTextbox.Text = "1";
            }
        }
        private void ShowTrainingData()
        {
            double[][,] dataSeries = new double[classesCount][,];
            int[] indexes = new int[classesCount];

            // allocate data arrays
            for (int i = 0; i < classesCount; i++)
            {
                dataSeries[i] = new double[(int)pixels.Count / classesCount, 2];
            }

            // fill data arrays
            for (int i = 0; i < pixels.Count; i++)
            {
                // get sample's class
                int dataClass = pixels[i].Group;
                // copy data into appropriate array
                dataSeries[dataClass][indexes[dataClass], 0] = pixels[i].X;
                dataSeries[dataClass][indexes[dataClass], 1] = pixels[i].Y;
                indexes[dataClass]++;
            }

            // remove all previous data series from chart control
            chart.RemoveAllDataSeries();

            // add new data series
            for (int i = 0; i < classesCount; i++)
            {
                var pixel = pixels.Where(k => k.Group == i).FirstOrDefault();
                string className = string.Format("class" + i);

                // add data series
                chart.AddDataSeries(className, dataSereisColors[i], Chart.SeriesType.Dots, 3);
                chart.UpdateDataSeries(className, dataSeries[i]);
                // add classifier
                chart.AddDataSeries(string.Format("classifier" + i), pixel.Color, Chart.SeriesType.Line, 1, false);
            }
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            if (filePathTextBox.Text!="")
                LoadDataFromFileAndInitWorkspace(filePathTextBox.Text);
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            var dlg = new CommonOpenFileDialog
            {
                DefaultDirectory = @"d:\Users\Bogdan.Bilyk\Downloads\MulticlassClassifier\MulticlassClassifier",
                IsFolderPicker = false,
                EnsurePathExists = true,
            };

            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                filePathTextBox.Text = dlg.FileName;
                LoadDataFromFileAndInitWorkspace(dlg.FileName);
            }
        }

        private void InitializeDataSet(List<string> parsedData)
        {
            minXvalue = float.MaxValue;
            maxXValue = float.MinValue;
            classesCount = 0;
            foreach (var parsedRaw in parsedData)
            {
                string[] pointUnit = parsedRaw.Split(',');
                if (pointUnit.Length == 3)
                    pixels.Add(new Pixel() { X = float.Parse(pointUnit[0]), Y = float.Parse(pointUnit[1]), Group = int.Parse(pointUnit[2]), Color = dataSereisColors[int.Parse(pointUnit[2])] });
                if (pointUnit.Length == 4)
                    pixels.Add(new Pixel() { X = float.Parse(pointUnit[0]), Y = float.Parse(pointUnit[1]), Z = float.Parse(pointUnit[2]), Group = int.Parse(pointUnit[3]) });
                if (pixels.LastOrDefault().Group >= classesCount)
                    classesCount++;
                // search for min value
                if (float.Parse(pointUnit[0]) < minXvalue)
                    minXvalue = float.Parse(pointUnit[0]);
                // search for max value
                if (float.Parse(pointUnit[0]) > maxXValue)
                    maxXValue = float.Parse(pointUnit[0]);
            }
            chart.RangeX = new Range(minXvalue, maxXValue);
        }
        private void SetDataLoadMessage()
        {
            if (pixels[0].Z == 0)
                logTextBox.Text += $"{pixels.Count} input vectors of {classesCount} classes in 2-dimensional space have been loaded\r\n\r\n";
            else
            {
                logTextBox.Text += $"{pixels.Count} input vectors of {classesCount} classes in 3-dimensional space have been loaded\r\n\r\n";
            }
        }
        private void SetResultMessage(double[] resultW0, double[] resultW1, double[] resultW2, double[] resultW3 = null)
        {
            logTextBox.Text += $"Random initialization of weights = {checkBox1.Checked}. Learning rate = {learningRateTextbox.Text}\r\n";
            logTextBox.Text += $"Maximum number of epochs = {maxIterations}.  Maximum error = {maxErrorTextbox.Text}\r\n";
            logTextBox.Text += $"Passed epochs: {passedIterationsTextbox.Text}, error = {errorSum}\r\n";
            logTextBox.Text += $"Optimal values ​​of the synaptic weights were found after {lastIteration} epochs:\r\n";
            for (int i = 0; i < classesCount; i++)
            {
                string neuronName = string.Format($"Neuron #{i}\r\n");
                logTextBox.Text += neuronName;
                logTextBox.Text += $"w0 = {resultW0[i]}\r\n";
                logTextBox.Text += $"w1 = {resultW1[i]}\r\n";
                logTextBox.Text += $"w2 = {resultW2[i]}\r\n";
                if (resultW3 != null)
                {
                    logTextBox.Text += $"w3 = {resultW3[i]}\r\n";
                }
            }
        }
        private void LoadDataFromFileAndInitWorkspace(string path)
        {
            List<string> rows = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                //This allows you to do one Read operation.
                var fileData = sr.ReadToEnd().Replace("\r", string.Empty);
                rows = fileData.Split('\n').ToList();
                //delete empty element
                rows.RemoveAt(rows.Count - 1);
            }
            ClearPictureBox();
            pixels.Clear();
            logTextBox.Text = "";

            InitializeDataSet(rows);
            SetDataLoadMessage();

            if (pixels[0].Z == 0)
                //DrawPixels();
                ShowTrainingData();

        }
        private void ClearPictureBox()
        {
            chart.RemoveAllDataSeries();
        }

    }
}

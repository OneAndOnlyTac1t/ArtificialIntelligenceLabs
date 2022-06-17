using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using Accord;
using Accord.Neuro;
using Accord.Neuro.Learning;

using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.Globalization;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace AI_3
{
    public partial class FormMain : Form
    {

        TaskScheduler uiScheduler;
        Size imgSize;
        int inputSize;

        int PassedEpoch = 0;
        double CurrentTrainError = 0, CurrentTestError = 0, CurrentRMSError = 0;
        Stopwatch watch = new Stopwatch();

        CancellationTokenSource runing = new CancellationTokenSource();

        ActivationNetwork network;

        public FormMain()
        {
            InitializeComponent();
            imgSize = new Size(28, 28);
            inputSize = imgSize.Width * imgSize.Height;
            imageList_TrainInput = new ImageList();
            imageList_TestOutput = new ImageList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imageList_TrainInput.ImageSize = imgSize;
            imageList_TestOutput.ImageSize = imgSize;
            textBoxInputSize.Text = String.Format("{0}-", inputSize);
            uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
        }

        private void button_SelectTrainFolder_Click(object sender, EventArgs e)
        {
            try
            {
                var dlg = new CommonOpenFileDialog
                {
                    IsFolderPicker = true,
                    EnsurePathExists = false,
                    DefaultDirectory = textBox_trainFolder.Text,
                };

                if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    textBox_trainFolder.Text = dlg.FileName;
                }
                        
                button_LoadTrainFolder_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_LoadTrainFolder_Click(object sender, EventArgs e)
        {
            try
            {
                imageList_TrainInput.Images.Clear();
                listView_TrainInput.Items.Clear();
                string path = textBox_trainFolder.Text;
                var files = Directory.GetFiles(path, "*.png");
                foreach (var file in files)
                {
                    string filename = file.Split('\\').Last();
                    imageList_TrainInput.Images.Add(filename, Image.FromFile(file));
                    listView_TrainInput.SmallImageList = imageList_TrainInput;

                    var item = listView_TrainInput.Items.Add(filename[0].ToString());
                    item.ImageKey = filename;
                }

                button_MixTrainInput.Enabled = true;
                textBox_TrainInputCount.Text = listView_TrainInput.Items.Count.ToString();

                if (imageList_TrainInput.Images.Count == 0)
                {
                    throw new Exception("Відсутні зображення!");
                }

                if (network != null && checkBoxInputNotRecognized.Checked)
                {
                    checkBoxInputNotRecognized_CheckedChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_MixTrainInput_Click(object sender, EventArgs e)
        {
            try
            {
                Random r = new Random();
                List<int> list = new List<int>();
                for (int i = 0; i < imageList_TrainInput.Images.Count; i++)
                    list.Add(i);
                list = list.OrderBy(i => r.Next()).ToList();

                ImageList newimageList_TrainInput = new ImageList();
                newimageList_TrainInput.ImageSize = imgSize;

                for (int i = 0; i < imageList_TrainInput.Images.Count; i++)
                    newimageList_TrainInput.Images.Add(imageList_TrainInput.Images.Keys[list[i]], imageList_TrainInput.Images[list[i]]);

                imageList_TrainInput = newimageList_TrainInput;
                listView_TrainInput.Items.Clear();
                listView_TrainInput.SmallImageList = imageList_TrainInput;
                for (int i = 0; i < imageList_TrainInput.Images.Count; i++)
                {
                    var item = listView_TrainInput.Items.Add(imageList_TrainInput.Images.Keys[i][0].ToString());
                    item.ImageKey = imageList_TrainInput.Images.Keys[i];
                }
                textBox_TrainInputCount.Text = imageList_TrainInput.Images.Count.ToString();

                if (network != null && checkBoxInputNotRecognized.Checked)
                {
                    checkBoxInputNotRecognized_CheckedChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_SelectTestFolder_Click(object sender, EventArgs e)
        {
            try
            {
                var dlg = new CommonOpenFileDialog
                {
                    IsFolderPicker = true,
                    EnsurePathExists = false,
                    DefaultDirectory = textBox_testFolder.Text,
                };

                if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    textBox_testFolder.Text = dlg.FileName;
                }
                
                button_LoadTestFolder_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_LoadTestFolder_Click(object sender, EventArgs e)
        {
            try
            {
                imageList_TestOutput.Images.Clear();
                string path = textBox_testFolder.Text;
                var files = Directory.GetFiles(path, "*.png");
                foreach (var file in files)
                {
                    string filename = file.Split('\\').Last();
                    imageList_TestOutput.Images.Add(filename, Image.FromFile(file));
                    listView_TestOutput.SmallImageList = imageList_TestOutput;

                    var item = listView_TestOutput.Items.Add(filename[0].ToString());
                    item.ImageKey = filename;
                }
                textBox_TestOutputCount.Text = listView_TestOutput.Items.Count.ToString();
                if (imageList_TestOutput.Images.Count == 0)
                {
                    throw new Exception("Немає зображень!");
                }
                if (network != null && checkBoxTestNotRecognized.Checked)
                {
                    checkBoxTestNotRecognized_CheckedChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_CreateNetwork_Click(object sender, EventArgs e)
        {
            try
            {
                if (runing != null)
                {
                    runing.Cancel();
                    runing = null;
                    Thread.Sleep(200);
                }

                string[] stringLayers = textBox_Layers.Text.Split('-');
                int[] layers = new int[stringLayers.Length + 1];
                for (int i = 0; i < stringLayers.Length; i++)
                    layers[i] = int.Parse(stringLayers[i]);
                layers[stringLayers.Length] = 10;

                network = new ActivationNetwork(new BipolarSigmoidFunction(double.Parse(textBoxAlpha.Text)), inputSize, layers);
                var RandWeights = new GaussianWeights(network, double.Parse(textBoxStdDev.Text));
                RandWeights.UpdateThresholds = true;
                RandWeights.Randomize();

                foreach (var series in chartMain.Series)
                {
                    series.Points.Clear();
                    series.Enabled = false;
                }
                button_Start.Enabled = true;

                PassedEpoch = 0;
                CurrentTrainError = 0;
                CurrentTestError = 0;
                CurrentRMSError = 0;
                watch.Reset();

                textBoxPassedEpoch.Text = PassedEpoch.ToString();
                textBoxPassedOutputError.Text = Math.Round(CurrentRMSError, 3).ToString();
                textBoxPassedTime.Text = TimeSpan.FromTicks(watch.ElapsedTicks).ToString().Substring(0, 8);
                textBoxPassedTrainError.Text = String.Empty;
                textBoxPassedTestError.Text = String.Empty;

                checkBoxInputNotRecognized_CheckedChanged(sender, e);
                checkBoxTestNotRecognized_CheckedChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void button_Start_Click(object sender, EventArgs e)
        {
            if (checkBox_ErrorsTrain.Checked)
                chartMain.Series[0].Enabled = true;
            if (checkBox_ErrorsTest.Checked)
                chartMain.Series[1].Enabled = true;
            if (checkBox_ErrorsOnOutput.Checked)
                chartMain.Series[2].Enabled = true;

            button_Start.Text = "Призупинити";

            if (runing != null)
            {
                runing.Cancel();
                runing = null;
                button_Start.Text = "Навчати";
                return;
            }

            BackPropagationLearning bpl = new BackPropagationLearning(network);
            bpl.LearningRate = double.Parse(textBox_LearningRate.Text);
            bpl.Momentum = double.Parse(textBox_Momentum.Text);

            int maxEpoch = int.Parse(textBox_MaxEpoh.Text);
            long time = DateTime.Parse(textBox_MaxTime.Text).TimeOfDay.Ticks;
            double errorLimit = double.Parse(textBox_ErrorOnOutput.Text);
            double trainErrorLmit = double.Parse(textBox_TrainErrorMax.Text);
            double testErrorLmit = double.Parse(textBox_ErrorOnTestPercent.Text);

            double[][] inputTrain = new double[imageList_TrainInput.Images.Count][];
            double[][] outputTrain = new double[imageList_TrainInput.Images.Count][];
            for (int i = 0; i < imageList_TrainInput.Images.Count; i++)
            {
                inputTrain[i] = GetInput(imageList_TrainInput.Images[i]);
                outputTrain[i] = new double[10];
                outputTrain[i][int.Parse(imageList_TrainInput.Images.Keys[i][0].ToString())] = 1;
            }

            double[][] inputTest = new double[imageList_TestOutput.Images.Count][];
            double[][] outputTest = new double[imageList_TestOutput.Images.Count][];
            if (checkBox_ErrorsTest.Checked)
            {
                for (int i = 0; i < imageList_TestOutput.Images.Count; i++)
                {
                    inputTest[i] = GetInput(imageList_TestOutput.Images[i]);
                    outputTest[i] = new double[10];
                    outputTest[i][int.Parse(imageList_TestOutput.Images.Keys[i][0].ToString())] = 1;
                }
            }

            if (checkBox_ErrorsTest.Checked && textBox_testFolder.Text != "")
            {
                button_LoadTestFolder_Click(sender, e);
            }

            runing = new CancellationTokenSource();
            CancellationToken ct = runing.Token;

            var x = Task.Run(() =>
            {
                watch.Start();
                do
                {
                    if (checkBoxShuffle.Checked)
                    {
                        Random random = new Random();
                        int rnd;
                        double[] tmp;
                        for (int i = inputTrain.Length - 1; i >= 1; i--)
                        {
                            rnd = random.Next(i + 1);
                            tmp = inputTrain[rnd];
                            inputTrain[rnd] = inputTrain[i];
                            inputTrain[i] = tmp;
                            tmp = outputTrain[rnd];
                            outputTrain[rnd] = outputTrain[i];
                            outputTrain[i] = tmp;
                        }
                    }
                    var res = bpl.RunEpoch(inputTrain, outputTrain);
                    CurrentRMSError = Math.Sqrt(2 * res / (10 * inputTrain.Length));

                    if (checkBox_ErrorsTrain.Checked)
                    {
                        int error = 0;
                        for (int i = 0; i < imageList_TrainInput.Images.Count; i++)
                        {
                            network.Compute(inputTrain[i]);
                            for (int j = 0; j < network.Output.Length; j++)
                                if (network.Output[j] == network.Output.Max())
                                {
                                    if (outputTrain[i][j] != 1)
                                        error++;
                                }
                        }
                        CurrentTrainError = error * 100.0 / imageList_TrainInput.Images.Count;
                    }

                    if (checkBox_ErrorsTest.Checked && imageList_TestOutput.Images.Count != 0)
                    {
                        int error = 0;
                        for (int i = 0; i < imageList_TestOutput.Images.Count; i++)
                        {
                            var outputL = network.Compute(GetInput(imageList_TestOutput.Images[i]));
                            int result = -1;
                            for (int j = 0; j < outputL.Length; j++)
                                if (outputL[j] == outputL.Max())
                                    result = j;
                            if (result != int.Parse(imageList_TestOutput.Images.Keys[i][0].ToString()))
                                error++;
                        }
                        CurrentTestError = error * 100 / imageList_TestOutput.Images.Count;
                    }

                    UpdateProgress(PassedEpoch.ToString(),
                        CurrentTrainError.ToString(),
                        CurrentTestError.ToString(),
                        Math.Round(CurrentRMSError, 3).ToString(),
                        TimeSpan.FromTicks(watch.Elapsed.Ticks).ToString().Substring(0, 8));

                    UpdateGraf(PassedEpoch, CurrentTrainError, CurrentTestError, CurrentRMSError);

                    PassedEpoch++;

                    if (ct.IsCancellationRequested)
                    {
                        break;
                    }
                }
                while ((!checkBox_PassedEpoch.Checked || PassedEpoch < maxEpoch) &&
                    (!checkBox_Time.Checked || watch.ElapsedTicks < time) &&
                    (!checkBox_ErrorsTrain.Checked || CurrentTrainError > trainErrorLmit) &&
                    (!checkBox_ErrorsOnOutput.Checked || CurrentRMSError > errorLimit) &&
                    (!checkBox_ErrorsTest.Checked || CurrentTestError > testErrorLmit || imageList_TestOutput.Images.Count == 0));

                watch.Stop();
            }, ct);

            await x;

            button_LoadTestFolder_Click(sender, e);
            button_LoadTrainFolder_Click(sender, e);
            button_Start.Text = "Навчати";
        }

        private void checkBoxInputNotRecognized_CheckedChanged(object sender, EventArgs e)
        {
            if (imageList_TrainInput.Images.Count != 0)
            {
                listView_TrainInput.Visible = false;
                int error = 0;
                listView_TrainInput.Items.Clear();
                double[][] input = new double[imageList_TrainInput.Images.Count][];
                double[][] output = new double[imageList_TrainInput.Images.Count][];
                for (int i = 0; i < imageList_TrainInput.Images.Count; i++)
                {
                    input[i] = GetInput(imageList_TrainInput.Images[i]);
                    output[i] = new double[10];
                    output[i][int.Parse(imageList_TrainInput.Images.Keys[i][0].ToString())] = 1;
                }
                for (int i = 0; i < imageList_TrainInput.Images.Count; i++)
                {
                    network.Compute(input[i]);
                    for (int j = 0; j < network.Output.Length; j++)
                    {
                        if (network.Output[j] == network.Output.Max())
                        {
                            if (output[i][j] != 1)
                            {
                                error++;
                                if (checkBoxInputNotRecognized.Checked)
                                    listView_TrainInput.Items.Add(imageList_TrainInput.Images.Keys[i][0].ToString() + " (" + j.ToString() + ")", i);
                            }
                            if (!checkBoxInputNotRecognized.Checked)
                                listView_TrainInput.Items.Add(imageList_TrainInput.Images.Keys[i][0].ToString() + " (" + j.ToString() + ")", i);
                        }
                    }
                }
                listView_TrainInput.Visible = true;
                textBoxInputNotRecognized.Text = error.ToString();
                textBox_TrainIncorectPercent.Text = (error * 100.0 / imageList_TrainInput.Images.Count).ToString("F");
            }
        }

        private void checkBoxTestNotRecognized_CheckedChanged(object sender, EventArgs e)
        {
            if (imageList_TestOutput.Images.Count != 0)
            {
                listView_TestOutput.Visible = false;
                int error = 0;
                listView_TestOutput.Items.Clear();
                double[][] input = new double[imageList_TestOutput.Images.Count][];
                double[][] output = new double[imageList_TestOutput.Images.Count][];
                for (int i = 0; i < imageList_TestOutput.Images.Count; i++)
                {
                    input[i] = GetInput(imageList_TestOutput.Images[i]);
                    output[i] = new double[10];
                    output[i][int.Parse(imageList_TestOutput.Images.Keys[i][0].ToString())] = 1;
                }
                for (int i = 0; i < imageList_TestOutput.Images.Count; i++)
                {
                    network.Compute(input[i]);
                    for (int j = 0; j < network.Output.Length; j++)
                    {
                        if (network.Output[j] == network.Output.Max())
                        {
                            if (output[i][j] != 1)
                            {
                                error++;
                                if (checkBoxTestNotRecognized.Checked)
                                    listView_TestOutput.Items.Add(imageList_TestOutput.Images.Keys[i][0].ToString() + " (" + j.ToString() + ")", i);
                            }
                            if (!checkBoxTestNotRecognized.Checked)
                                listView_TestOutput.Items.Add(imageList_TestOutput.Images.Keys[i][0].ToString() + " (" + j.ToString() + ")", i);
                        }
                    }
                }
                listView_TestOutput.Visible = true;
                textBox_NotRecognizedTestCount.Text = error.ToString();
                textBox_TestIncorectPercent.Text = (error * 100.0 / imageList_TestOutput.Images.Count).ToString("F");
            }
        }

        private void UpdateProgress(string PassedEpoch, string CurrentTrainError, string CurrentTestError, string CurrentError, string Time)
        {
            Task.Factory.StartNew(() =>
            {
                textBoxPassedEpoch.Text = PassedEpoch;
                textBoxPassedTrainError.Text = CurrentTrainError;
                textBoxPassedOutputError.Text = CurrentError;
                textBoxPassedTime.Text = Time;
                if (checkBox_ErrorsTest.Checked)
                    textBoxPassedTestError.Text = CurrentTestError;
            }, CancellationToken.None, TaskCreationOptions.None, uiScheduler);
        }


        private void UpdateGraf(int PassedEpoch, double CurrentTrainError, double CurrentTestError, double CurrentError)
        {
            Task.Factory.StartNew(() =>
            {
                if (checkBox_ErrorsTrain.Checked)
                    chartMain.Series[0].Points.AddXY(PassedEpoch, CurrentTrainError);
                if (checkBox_ErrorsTest.Checked)
                    chartMain.Series[1].Points.AddXY(PassedEpoch, CurrentTestError);
                if (checkBox_ErrorsOnOutput.Checked)
                    chartMain.Series[2].Points.AddXY(PassedEpoch, CurrentError);
            }, CancellationToken.None, TaskCreationOptions.None, uiScheduler);
        }

        static double[] GetInput(Image img)
        {
            Bitmap bimg = new Bitmap(img);
            double[] res = new double[img.Width * img.Height];
            for (int i = 0; i < img.Width; i++)
                for (int j = 0; j < img.Height; j++)
                    res[i * img.Height + j] = bimg.GetPixel(i, j).GetBrightness() * 2.0 - 1.0;
            return res;
        }
    }
}

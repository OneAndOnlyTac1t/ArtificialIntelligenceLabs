using Accord.Genetic;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1D_CSPBilyk
{
    public partial class Form1 : Form
    {
        private double mutationRate;
        private int populationSize;
        private int iterations;
        private int currentIteration;
        private int maxIterations;
        private int[] detailSizes;
        private int detailsAmount;
        private int endAmountOfBillets;
        private const int billetsLength = 100;
        private int totalDetailsLength;
        private Thread workerThread = null;
        private volatile bool needToStop = false;
        private int selectionMethod = 0;
        private int fitnessFunctionValue = 1;
        private double fitnessFunctionResult;
        private int iteration;
        private int usedBillets;
        public Form1()
        {
            InitializeComponent();
            selectionOperationComboBox.SelectedIndex = selectionMethod;
            fitnessFunctionComboBox.SelectedIndex = fitnessFunctionValue;
            billetLengthTextBox.Text = billetsLength.ToString();
            populationSizeTextBox.Text = "100";
            maxIterationsAmountTextBox.Text = "1000";
            mutationRateTextBox.Text = "0.1";
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            var dlg = new CommonOpenFileDialog
            {
                DefaultDirectory = @"d:\Users\Bogdan.Bilyk\Downloads\1D_CSP\1D_CSP",
                IsFolderPicker = false,
                EnsurePathExists = true,
            };

            string path;
            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                path = dlg.FileName;

                List<string> rows = new List<string>();
                using (StreamReader sr = new StreamReader(path))
                {
                    //This allows you to do one Read operation.
                    var fileData = sr.ReadToEnd().Replace("\r", string.Empty);
                    rows = fileData.Split('\n').ToList();
                    //delete empty element
                    rows.RemoveAt(rows.Count - 1);
                }
                detailsAmount = rows.Count;
                InitDataFromFile(rows);
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            // stop worker thread
            if (workerThread != null)
            {
                needToStop = true;
                while (!workerThread.Join(100))
                    Application.DoEvents();
                workerThread = null;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            selectionMethod = selectionOperationComboBox.SelectedIndex;
            mutationRate = double.Parse(mutationRateTextBox.Text);
            fitnessFunctionValue = fitnessFunctionComboBox.SelectedIndex;
            maxIterations = int.Parse(maxIterationsAmountTextBox.Text);
            populationSize = int.Parse(populationSizeTextBox.Text);

            // disable all settings controls except "Stop" button
            EnableControls(false);

            // run worker thread
            needToStop = false;
            workerThread = new Thread(new ThreadStart(SearchSolution));
            workerThread.Start();
        }

        // Worker thread
        void SearchSolution()
        {
            bool isComplexFitnessFunction = (fitnessFunctionValue == 1) ? true: false;
            
            // create fitness function
            CSPFitnessFunction fitnessFunction = new CSPFitnessFunction(detailSizes, billetsLength, isComplexFitnessFunction);
            // create population
            Population population = new Population(populationSize,
                new ShortArrayChromosome(detailsAmount, detailsAmount-1),
                fitnessFunction,
                (selectionMethod == 0) ? (ISelectionMethod)new EliteSelection() :
                (selectionMethod == 1) ? (ISelectionMethod)new RankSelection() :
                (ISelectionMethod)new RouletteWheelSelection()
                );
            mutationRate = double.Parse(mutationRateTextBox.Text);
            population.AutoShuffling = true;
            population.MutationRate = mutationRate;
            // iterations
            int i = 1;
          

            // loop
            while (!needToStop)
            {
                population.RunEpoch();
                ushort[] bestResult = ((ShortArrayChromosome)population.BestChromosome).Value;

                fitnessFunctionResult = fitnessFunction.Evaluate(population.BestChromosome);

                usedBillets = (int)fitnessFunction.CalculateM(population.BestChromosome);
                                
                SetText(iterationTextBox, i.ToString());
                SetText(fitnessFunctionValueTextBox, fitnessFunctionResult.ToString());
                SetText(usedBilletsTextBox, usedBillets.ToString()); 

                ShowResult(bestResult);
                //Thread.Sleep(1000);
                i++;
                //
                if (((maxIterations != 0) && (i > maxIterations))|| usedBillets==endAmountOfBillets)
                {
                    break;
                }
            }
           // ShowResult(((ShortArrayChromosome)population.BestChromosome).Value);
            // enable settings controls
            EnableControls(true);
        }

        // Delegates to enable async calls for setting controls properties
        private delegate void SetTextCallback(System.Windows.Forms.Control control, string text);

        // Thread safe updating of control's text property
        private void SetText(System.Windows.Forms.Control control, string text)
        {
            if (control.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new object[] { control, text });
            }
            else
            {
                control.Text = text;
            }
        }
        private void ShowResult(ushort[] result)
        {
            SetText(resultTextBox, "");
            string resultString ="";
            var resultList = new List<ushort>();

            for (int i = 0; i < result.Length; i++)
            {
                if (!resultList.Contains(result[i]))
                {
                    resultList.Add(result[i]);
                }
            }
            for (int i = 0; i < resultList.Count; i++)
            {
                double tempBiletSum = 0;
                resultString += string.Concat((i+1).ToString(), ": ");
               // SetText(resultTextBox, string.Concat(resultList[i].ToString(), ": "));
                for (int j = 0; j < result.Length; j++)
                {
                    if (result[j] == resultList[i])
                    {
                        tempBiletSum += detailSizes[j];
                    }
                }
                resultString += string.Concat(tempBiletSum, " = ");
               // SetText(resultTextBox, string.Concat(tempBiletSum, " = "));
                for (int j = 0; j < result.Length; j++)
                {
                    if (result[j] == resultList[i])
                    {
                        resultString += string.Concat(detailSizes[j], " + ");
                        //SetText(resultTextBox, string.Concat(detailSizes[j], " + "));
                    }

                }
                resultString = resultString.Remove(resultString.Length-3);
                resultString += "\r\n";
                //   SetText(resultTextBox, resultTextBox.Text.Remove(resultTextBox.Text.Length-3, 3));
                //   SetText(resultTextBox, "\r\n");
            }
            SetText(resultTextBox, resultString);
        }
        private void InitDataFromFile(List<string> rows)
        {
            totalDetailsLength = 0;
            detailSizes = new int[detailsAmount];
            for (int i = 0; i < rows.Count; i++)
            {
                detailSizes[i] = int.Parse(rows[i]);
                totalDetailsLength += detailSizes[i];
            }

            endAmountOfBillets = totalDetailsLength / billetsLength + 1;
            UpdateSettings();
            UpdateInitResut();
        }

        private void UpdateInitResut()
        {
            resultTextBox.Text = "";
            for (int i = 0; i < detailsAmount; i++)
            {
                resultTextBox.Text += string.Concat((i+1).ToString(), ": ", detailSizes[i], " = ", detailSizes[i]);
                resultTextBox.Text += "\r\n";
            }
        }
        private void UpdateSettings()
        {
            totalDetailsLenghtTextBox.Text = totalDetailsLength.ToString();
            detailsAmountTextBox.Text = detailsAmount.ToString();
            endAmountOfUsedBilletsTextBox.Text = endAmountOfBillets.ToString();
            usedBilletsTextBox.Text = detailsAmount.ToString();
        }
        // Delegates to enable async calls for setting controls properties
        private delegate void EnableCallback(bool enable);

        private void EnableControls(bool enable)
        {
            if (InvokeRequired)
            {
                EnableCallback d = new EnableCallback(EnableControls);
                Invoke(d, new object[] { enable });
            }
            else
            {
                mutationRateTextBox.Enabled = enable;
                populationSizeTextBox.Enabled = enable;
                maxIterationsAmountTextBox.Enabled = enable;
                selectionOperationComboBox.Enabled = enable;
                fitnessFunctionComboBox.Enabled = enable;

                startButton.Enabled = enable;
                stopButton.Enabled = !enable;
            }
        }
    }
}

using Accord;
using Accord.Controls;
using Accord.Genetic;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace TCPBilyk
{
    public partial class Form1 : Form
    {
        private int citiesCount = 20;
        private int populationSize = 100;
        private int iterations = 1000;
        private int selectionMethod = 0;
		private double finalSpeed = 1;
		private double mutationRate = 0.1;

        private double[,] map = null;

        private Thread workerThread = null;
        private volatile bool needToStop = false;
        public Form1()
        {
            InitializeComponent();
            // set up map control
            mapControl.RangeX = new Range(0, 1000);
            mapControl.RangeY = new Range(0, 1000);
            mapControl.AddDataSeries("map", Color.Blue, Chart.SeriesType.Dots, 3, false);
            mapControl.AddDataSeries("path", Color.Blue, Chart.SeriesType.Line, 1, false);
			mapControl.AddDataSeries("start", Color.Green, Chart.SeriesType.Dots, 5, false);
			mapControl.AddDataSeries("finish", Color.Red, Chart.SeriesType.Dots, 5, false);

			//
			selectionBox.SelectedIndex = selectionMethod;
			mutationRateTextBox.Text = mutationRate.ToString();

			UpdateSettings();
            GenerateMap();
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
		// On main form closing
		private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// check if worker thread is running
			if ((workerThread != null) && (workerThread.IsAlive))
			{
				needToStop = true;
				while (!workerThread.Join(100))
					Application.DoEvents();
			}
		}

		// Update settings controls
		private void UpdateSettings()
		{
			citiesCountBox.Text = citiesCount.ToString();
			populationSizeBox.Text = populationSize.ToString();
			iterationsBox.Text = iterations.ToString();
			finalSpeedTextBox.Text = finalSpeed.ToString();
		}

		// Delegates to enable async calls for setting controls properties
		private delegate void EnableCallback(bool enable);

		// Enable/disale controls (safe for threading)
		private void EnableControls(bool enable)
		{
			if (InvokeRequired)
			{
				EnableCallback d = new EnableCallback(EnableControls);
				Invoke(d, new object[] { enable });
			}
			else
			{
				citiesCountBox.Enabled = enable;
				populationSizeBox.Enabled = enable;
				iterationsBox.Enabled = enable;
				selectionBox.Enabled = enable;

				generateMapButton.Enabled = enable;

				startButton.Enabled = enable;
				stopButton.Enabled = !enable;
			}
		}

		// Generate new map for the Traivaling Salesman problem
		private void GenerateMap()
		{
			Random rand = new Random((int)DateTime.Now.Ticks);

			// create coordinates array
			map = new double[citiesCount, 2];

			for (int i = 0; i < citiesCount; i++)
			{
				map[i, 0] = rand.Next(1001);
				map[i, 1] = rand.Next(1001);
			}

			var startData = new double[1, 2];
			startData[0, 0] = map[0, 0];
			startData[0, 1] = map[0, 1];

			// set the map 
			mapControl.UpdateDataSeries("map", map);
			mapControl.UpdateDataSeries("start", startData);
			// erase path if it is
			mapControl.UpdateDataSeries("path", null);
		}

		// On "Generate" button click - generate map
		private void generateMapButton_Click(object sender, System.EventArgs e)
		{
			// get cities count
			try
			{
				citiesCount = Math.Max(5, Math.Min(50, int.Parse(citiesCountBox.Text)));
			}
			catch
			{
				citiesCount = 20;
			}
			citiesCountBox.Text = citiesCount.ToString();

			// regenerate map
			GenerateMap();
		}

		// On "Start" button click
		private void startButton_Click(object sender, System.EventArgs e)
		{
			// get population size
			try
			{
				populationSize = int.Parse(populationSizeBox.Text);
			}
			catch
			{
				populationSize = 40;
			}
			// iterations
			try
			{
				iterations = int.Parse(iterationsBox.Text);
			}
			catch
			{
				iterations = 100;
			}
            try
            {
				finalSpeed = double.Parse(finalSpeedTextBox.Text);
			}
            catch
            {
				finalSpeed = 1;
            }
			// update settings controls
			UpdateSettings();

			selectionMethod = selectionBox.SelectedIndex;

			// disable all settings controls except "Stop" button
			EnableControls(false);

			// run worker thread
			needToStop = false;
			workerThread = new Thread(new ThreadStart(SearchSolution));
			workerThread.Start();
		}

		// On "Stop" button click
		private void stopButton_Click(object sender, System.EventArgs e)
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

		private void SaveButton_Click(object sender, EventArgs e)
		{
			var dlg = new CommonSaveFileDialog
			{
				DefaultDirectory = @"d:\Users\Bogdan.Bilyk\Downloads\TSPmod\TSPmod",
				EnsurePathExists = true,
			};
			string path;

			if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
			{
				path = string.Concat(dlg.FileName, ".dat");
				using (StreamWriter sr = new StreamWriter(path))
				{
					for (int i = 0; i < citiesCount; i++)
                    {
						sr.WriteLine(string.Concat(map[i, 0], " ", map[i, 1]));
                    }
				}
			}
		}
		private void LoadButton_Click(object sender, EventArgs e)
        {
			var dlg = new CommonOpenFileDialog
			{
				DefaultDirectory = @"d:\Users\Bogdan.Bilyk\Downloads\TSPmod\TSPmod",
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
				InitDataFromFile(rows);
			}
		}

		private void InitDataFromFile(List<string> rows)
        {
			map = new double[rows.Count, 2];
			for (int i = 0; i < rows.Count; i++)
            {
				var dataset = rows[i].Split(' ').ToList();
				map[i, 0] = double.Parse(dataset[0]);
				map[i, 1] = double.Parse(dataset[1]);
			}
			var startData = new double[1, 2];
			startData[0, 0] = map[0, 0];
			startData[0, 1] = map[0, 1];

			// set the map 
			mapControl.UpdateDataSeries("map", map);
			mapControl.UpdateDataSeries("start", startData);
			// erase path if it is
			mapControl.UpdateDataSeries("path", null);
			citiesCount = rows.Count;
			citiesCountBox.Text = citiesCount.ToString();
		}

		// Worker thread
		void SearchSolution()
		{
			// create fitness function
			TSPFitnessFunction fitnessFunction = new TSPFitnessFunction(map, finalSpeed);
			// create population
			Population population = new Population(populationSize,
			    new PermutationChromosome(citiesCount),
				fitnessFunction,
				(selectionMethod == 0) ? (ISelectionMethod)new EliteSelection() :
				(selectionMethod == 1) ? (ISelectionMethod)new RankSelection() :
				(ISelectionMethod)new RouletteWheelSelection()
				);
			mutationRate =double.Parse(mutationRateTextBox.Text);
			population.MutationRate = mutationRate;
			// iterations
			int i = 1;

			// path
			double[,] path = new double[citiesCount + 1, 2];

			// loop
			while (!needToStop)
			{
				// run one epoch of genetic algorithm
				population.RunEpoch();

				// display current path
				ushort[] bestValue = ((PermutationChromosome)population.BestChromosome).Value;

				for (int j = 0; j < citiesCount; j++)
				{
					path[j, 0] = map[bestValue[j], 0];
					path[j, 1] = map[bestValue[j], 1];
				}
				path[citiesCount, 0] = map[bestValue[0], 0];
				path[citiesCount, 1] = map[bestValue[0], 1];

				mapControl.UpdateDataSeries("path", path);

				// set current iteration's info
				SetText(currentIterationBox, i.ToString());
				SetText(pathTimeTextBox, fitnessFunction.CalculateTime(population.BestChromosome).ToString());

				SetText(pathLengthBox, fitnessFunction.ResultPath(population.BestChromosome).ToString());

				var lastCity = fitnessFunction.LastPoint(population.BestChromosome);
				var endData = new double[1, 2];
				endData[0, 0] = map[lastCity, 0];
				endData[0, 1] = map[lastCity, 1];
				mapControl.UpdateDataSeries("finish", endData);
				// increase current iteration
				i++;

				//
				if ((iterations != 0) && (i > iterations))
				{
					break;
				}
			}

			// enable settings controls
			EnableControls(true);
		}       
    }
}

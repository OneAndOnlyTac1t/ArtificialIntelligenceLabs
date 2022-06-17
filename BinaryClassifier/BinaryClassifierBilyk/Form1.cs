using BinaryClassifierBilyk.Data;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BinaryClassifierBilyk
{
    public partial class Form1 : Form
    {
        double w1, w2, w3, w0 = 0;
        const float n = 1;
        int errorSum, lastIteration;

        int maxIterations, maxError;
        List<Pixel> pixels;
        public Form1()
        {

            pixels = new List<Pixel>();

            InitializeComponent();
            iterationsTextBox.Text = "1000";
            maxErrorTextbox.Text = "0";
            errorSum = int.MaxValue;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var dlg = new CommonOpenFileDialog
            {
                DefaultDirectory = @"d:\Users\Bogdan.Bilyk\Downloads\BinaryClassifier\BinaryClassifier",
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
            foreach (var parsedRaw in parsedData)
            {
                string[] pointUnit = parsedRaw.Split(',');
                if (pointUnit.Length == 3)
                    pixels.Add(new Pixel() { X = float.Parse(pointUnit[0]), Y = float.Parse(pointUnit[1]), Group = int.Parse(pointUnit[2]) });
                if (pointUnit.Length == 4)
                    pixels.Add(new Pixel() { X = float.Parse(pointUnit[0]), Y = float.Parse(pointUnit[1]), Z = float.Parse(pointUnit[2]), Group = int.Parse(pointUnit[3]) });
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
                DrawPixels();

            w0 = 0;
            w1 = 0;
            w2 = 0;
            w3 = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataFromFileAndInitWorkspace(filePathTextBox.Text);
        }

        private void ClearPictureBox()
        {
            Bitmap bitmap = new Bitmap(coordinatesPictureBox.Width, coordinatesPictureBox.Height);

            var g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            coordinatesPictureBox.Image = bitmap;
        }
        private void DrawPixels()
        {
            Bitmap bitmap = new Bitmap(coordinatesPictureBox.Width, coordinatesPictureBox.Height);

            var g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            coordinatesPictureBox.Refresh();
            foreach (var pixel in pixels)
            {
                var x = coordinatesPictureBox.Width / 2 + pixel.X * 10 - 50;
                var y = coordinatesPictureBox.Height / 2 - pixel.Y * 10;
                Pen pen;
                if (pixel.Group == 1)
                {
                    pen = new Pen(Color.Red, 2);
                }
                else
                {
                    pen = new Pen(Color.Blue, 2);
                }
                g.DrawRectangle(pen, (float)x, (float)y, 1, 1);
            }
            coordinatesPictureBox.Image = bitmap;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            if (pixels[0].Z == 0)
                DrawPixels();

            errorSum = int.MaxValue;

            int i, iterationErrorSum = 0;
            int iterations = 1;
            bool isValueChanged = true;
            lastIteration = iterations;

            maxIterations = int.Parse(iterationsTextBox.Text);
            maxError = int.Parse(maxErrorTextbox.Text);

            double iterationW0 = 0;
            double iterationW1 = 0;
            double iterationW2 = 0;
            double iterationW3 = 0;

            while (isValueChanged && iterations <= maxIterations)
            {
                isValueChanged = false;

                for (i = 0; i <= pixels.Count - 1; i++)
                {
                    double x1 = pixels[i].X;
                    double x2 = pixels[i].Y;
                    double x3 = pixels[i].Z;
                    int y;

                    if (pixels[0].Z == 0)
                    {                      
                        if (((iterationW1 * x1) + (iterationW2 * x2) + iterationW0) < 0)
                        {
                            y = 0;
                        }
                        else
                        {
                            y = 1;
                        }
                        
                        if (y != pixels[i].Group)
                        {
                            isValueChanged = true;

                            iterationW0 = iterationW0 + n * (pixels[i].Group - y);
                            iterationW1 = iterationW1 + n * (pixels[i].Group - y) * x1;
                            iterationW2 = iterationW2 + n * (pixels[i].Group - y) * x2;
                        }
                                              

                    }
                    else
                    {
                        if (((iterationW1 * x1) + (iterationW2 * x2) + (iterationW3 * x3) + iterationW0) < 0)
                        {
                            y = 0;
                        }
                        else
                        {
                            y = 1;
                        }

                        if (y != pixels[i].Group)
                        {
                            isValueChanged = true;

                            iterationW0 = iterationW0 + n * (pixels[i].Group - y);
                            iterationW1 = iterationW1 + n * (pixels[i].Group - y) * x1;
                            iterationW2 = iterationW2 + n * (pixels[i].Group - y) * x2;
                            iterationW3 = iterationW3 + n * (pixels[i].Group - y) * x3;
                        }
                    }
                }

                //errorSum chekcking
                int yCheker;
                for (i = 0; i <= pixels.Count - 1; i++)
                {
                    if (pixels[0].Z == 0)
                    {
                        if (((iterationW1 * pixels[i].X) + (iterationW2 * pixels[i].Y) + iterationW0) < 0)
                        {
                            yCheker = 0;
                        }
                        else
                        {
                            yCheker = 1;
                        }
                        iterationErrorSum += Math.Abs(pixels[i].Group - yCheker);
                    }
                    else
                    {
                        if (((iterationW1 * pixels[i].X) + (iterationW2 * pixels[i].Y) + (iterationW3 * pixels[i].Z) + iterationW0) < 0)
                        {
                            yCheker = 0;
                        }
                        else
                        {
                            yCheker = 1;
                        }
                        iterationErrorSum += Math.Abs(pixels[i].Group - yCheker);
                    }
                }

                //save latest value in case if it is optimal
                if ((iterationErrorSum < errorSum && isValueChanged) || iterationErrorSum == 0)
                {
                    lastIteration = iterations;
                    errorSum = iterationErrorSum;
                    w0 = iterationW0;
                    w1 = iterationW1;
                    w2 = iterationW2;
                    w3 = iterationW3;
                }

                iterationErrorSum = 0;
                iterations++;
                //quit in case if error was 
                if (maxError > errorSum)
                {
                    break;
                }               
            }

            //reduce iterations value because it was incremented in while cycle
            if (iterations != maxIterations)
            {
                iterations--;
            }

            //artifact appears 
            if (!isValueChanged)
            {
                iterations--;
                lastIteration--;
            }
            passedIterationsTextbox.Text = (iterations).ToString();
            errorTextbox.Text = (errorSum).ToString();
            SetResultMessage();

            if (pixels[0].Z == 0)
                DrawSeparationLine();
        }
        private void DrawSeparationLine()
        {
            Bitmap bitmap = new Bitmap(coordinatesPictureBox.Image);
            var g = Graphics.FromImage(bitmap);
            // g.DrawLine(new Pen(Color.Gainsboro), new Point(0, pictureBox1.Height / 2), new Point(pictureBox1.Width, pictureBox1.Height / 2));
            // g.DrawLine(new Pen(Color.Gainsboro), new Point(pictureBox1.Width / 2, 0), new Point(pictureBox1.Width / 2, pictureBox1.Height));


            Pen pen = new Pen(Color.Purple, 1.75F);
            double x1, y1, x2, y2;

            x1 = 15;
            y1 = -(x1 * w1 / w2) - (w0 / w2);

            y2 = 15;
            x2 = -(y2 * w2 / w1) - (w0 / w1);

            PointF point1 = new PointF(GetX(x1), GetY(y1));
            PointF point2 = new PointF(GetX(x2), GetY(y2));

            g.DrawLine(pen, point1, point2);
            coordinatesPictureBox.Image = bitmap;
        }
        private float GetX(double input)
        {
            return (float)(coordinatesPictureBox.Width / 2 + input * 10 - 50);
        }
        private float GetY(double input)
        {
            return (float)(coordinatesPictureBox.Height / 2 - input * 10);
        }
        private void SetDataLoadMessage()
        {
            if (pixels[0].Z == 0)
                logTextBox.Text += $"{pixels.Count} input vectors in 2-dimensional space have been loaded\r\n\r\n";
            else
            {
                logTextBox.Text += $"{pixels.Count} input vectors in 3-dimensional space have been loaded\r\n\r\n";
            }
        }
        private void SetResultMessage()
        {
            if (pixels[0].Z == 0)
            {
                logTextBox.Text += $"Maximum number of epochs = {maxIterations}.  Maximum error = {maxErrorTextbox.Text}\r\n";
                logTextBox.Text += $"Passed epochs: {passedIterationsTextbox.Text}, error = {errorSum}\r\n";
                logTextBox.Text += $"Optimal values ​​of the synaptic weights were found after {lastIteration} epochs:\r\n";
                logTextBox.Text += $"w0 = {w0}\r\n";
                logTextBox.Text += $"w1 = {w1}\r\n";
                logTextBox.Text += $"w2 = {w2}\r\n";
            }
            else
            {
                logTextBox.Text += $"Maximum number of epochs = {maxIterations}.  Maximum error = {maxErrorTextbox.Text}\r\n";
                logTextBox.Text += $"Passed epochs: {passedIterationsTextbox.Text}, error = {errorSum}\r\n";
                logTextBox.Text += $"Optimal values ​​of the synaptic weights were found after {lastIteration} epochs:\r\n";
                logTextBox.Text += $"w0 = {w0}\r\n";
                logTextBox.Text += $"w1 = {w1}\r\n";
                logTextBox.Text += $"w2 = {w2}\r\n";
                logTextBox.Text += $"w3 = {w3}\r\n";
            }
        }
    }
}

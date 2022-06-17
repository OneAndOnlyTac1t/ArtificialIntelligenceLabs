namespace AI_3
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox_trainFolder = new System.Windows.Forms.TextBox();
            this.button_SelectTrainFolder = new System.Windows.Forms.Button();
            this.button_LoadTrainFolder = new System.Windows.Forms.Button();
            this.button_MixTrainInput = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_TrainIncorectPercent = new System.Windows.Forms.TextBox();
            this.textBoxInputNotRecognized = new System.Windows.Forms.TextBox();
            this.checkBoxInputNotRecognized = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_TrainInput = new System.Windows.Forms.ListView();
            this.imageList_TrainInput = new System.Windows.Forms.ImageList(this.components);
            this.textBox_TrainInputCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxTestNotRecognized = new System.Windows.Forms.CheckBox();
            this.listView_TestOutput = new System.Windows.Forms.ListView();
            this.textBox_TestIncorectPercent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_TestOutputCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_NotRecognizedTestCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_testFolder = new System.Windows.Forms.TextBox();
            this.button_SelectTestFolder = new System.Windows.Forms.Button();
            this.button_LoadTestFolder = new System.Windows.Forms.Button();
            this.imageList_TestOutput = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxInputSize = new System.Windows.Forms.TextBox();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.textBox_Layers = new System.Windows.Forms.TextBox();
            this.textBoxStdDev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_CreateNetwork = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_TrainErrorMax = new System.Windows.Forms.TextBox();
            this.checkBox_ErrorsTrain = new System.Windows.Forms.CheckBox();
            this.textBox_ErrorOnOutput = new System.Windows.Forms.TextBox();
            this.textBox_MaxTime = new System.Windows.Forms.TextBox();
            this.textBox_ErrorOnTestPercent = new System.Windows.Forms.TextBox();
            this.checkBox_ErrorsTest = new System.Windows.Forms.CheckBox();
            this.checkBox_ErrorsOnOutput = new System.Windows.Forms.CheckBox();
            this.checkBox_Time = new System.Windows.Forms.CheckBox();
            this.checkBox_PassedEpoch = new System.Windows.Forms.CheckBox();
            this.textBox_MaxEpoh = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxPassedTrainError = new System.Windows.Forms.TextBox();
            this.textBoxPassedOutputError = new System.Windows.Forms.TextBox();
            this.textBoxPassedTime = new System.Windows.Forms.TextBox();
            this.textBoxPassedTestError = new System.Windows.Forms.TextBox();
            this.textBoxPassedEpoch = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBoxShuffle = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Momentum = new System.Windows.Forms.TextBox();
            this.textBox_LearningRate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_trainFolder
            // 
            this.textBox_trainFolder.Location = new System.Drawing.Point(72, 28);
            this.textBox_trainFolder.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_trainFolder.Name = "textBox_trainFolder";
            this.textBox_trainFolder.Size = new System.Drawing.Size(377, 21);
            this.textBox_trainFolder.TabIndex = 0;
            this.textBox_trainFolder.Text = "d:\\Users\\Bogdan.Bilyk\\Downloads\\DigitRecognition_pass_1234\\MNIST_data\\train\\600";
            // 
            // button_SelectTrainFolder
            // 
            this.button_SelectTrainFolder.Location = new System.Drawing.Point(12, 62);
            this.button_SelectTrainFolder.Margin = new System.Windows.Forms.Padding(4);
            this.button_SelectTrainFolder.Name = "button_SelectTrainFolder";
            this.button_SelectTrainFolder.Size = new System.Drawing.Size(59, 23);
            this.button_SelectTrainFolder.TabIndex = 2;
            this.button_SelectTrainFolder.Text = "Обрати";
            this.button_SelectTrainFolder.UseVisualStyleBackColor = true;
            this.button_SelectTrainFolder.Click += new System.EventHandler(this.button_SelectTrainFolder_Click);
            // 
            // button_LoadTrainFolder
            // 
            this.button_LoadTrainFolder.Location = new System.Drawing.Point(84, 62);
            this.button_LoadTrainFolder.Margin = new System.Windows.Forms.Padding(4);
            this.button_LoadTrainFolder.Name = "button_LoadTrainFolder";
            this.button_LoadTrainFolder.Size = new System.Drawing.Size(96, 23);
            this.button_LoadTrainFolder.TabIndex = 3;
            this.button_LoadTrainFolder.Text = "Завантажити";
            this.button_LoadTrainFolder.UseVisualStyleBackColor = true;
            this.button_LoadTrainFolder.Click += new System.EventHandler(this.button_LoadTrainFolder_Click);
            // 
            // button_MixTrainInput
            // 
            this.button_MixTrainInput.Enabled = false;
            this.button_MixTrainInput.Location = new System.Drawing.Point(192, 62);
            this.button_MixTrainInput.Margin = new System.Windows.Forms.Padding(4);
            this.button_MixTrainInput.Name = "button_MixTrainInput";
            this.button_MixTrainInput.Size = new System.Drawing.Size(67, 23);
            this.button_MixTrainInput.TabIndex = 4;
            this.button_MixTrainInput.Text = "Змішати";
            this.button_MixTrainInput.UseVisualStyleBackColor = true;
            this.button_MixTrainInput.Click += new System.EventHandler(this.button_MixTrainInput_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox_TrainIncorectPercent);
            this.groupBox1.Controls.Add(this.textBoxInputNotRecognized);
            this.groupBox1.Controls.Add(this.checkBoxInputNotRecognized);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listView_TrainInput);
            this.groupBox1.Controls.Add(this.textBox_TrainInputCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_MixTrainInput);
            this.groupBox1.Controls.Add(this.textBox_trainFolder);
            this.groupBox1.Controls.Add(this.button_SelectTrainFolder);
            this.groupBox1.Controls.Add(this.button_LoadTrainFolder);
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(459, 362);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Зображення для навчання";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 332);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Частка помилок, %";
            // 
            // textBox_TrainIncorectPercent
            // 
            this.textBox_TrainIncorectPercent.Enabled = false;
            this.textBox_TrainIncorectPercent.Location = new System.Drawing.Point(392, 329);
            this.textBox_TrainIncorectPercent.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_TrainIncorectPercent.Name = "textBox_TrainIncorectPercent";
            this.textBox_TrainIncorectPercent.ReadOnly = true;
            this.textBox_TrainIncorectPercent.Size = new System.Drawing.Size(57, 21);
            this.textBox_TrainIncorectPercent.TabIndex = 12;
            // 
            // textBoxInputNotRecognized
            // 
            this.textBoxInputNotRecognized.Enabled = false;
            this.textBoxInputNotRecognized.Location = new System.Drawing.Point(154, 331);
            this.textBoxInputNotRecognized.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInputNotRecognized.Name = "textBoxInputNotRecognized";
            this.textBoxInputNotRecognized.Size = new System.Drawing.Size(57, 21);
            this.textBoxInputNotRecognized.TabIndex = 11;
            // 
            // checkBoxInputNotRecognized
            // 
            this.checkBoxInputNotRecognized.AutoSize = true;
            this.checkBoxInputNotRecognized.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxInputNotRecognized.Checked = true;
            this.checkBoxInputNotRecognized.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInputNotRecognized.Location = new System.Drawing.Point(9, 332);
            this.checkBoxInputNotRecognized.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxInputNotRecognized.Name = "checkBoxInputNotRecognized";
            this.checkBoxInputNotRecognized.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxInputNotRecognized.Size = new System.Drawing.Size(137, 19);
            this.checkBoxInputNotRecognized.TabIndex = 10;
            this.checkBoxInputNotRecognized.Text = "Лише нерозпізнані:";
            this.checkBoxInputNotRecognized.UseVisualStyleBackColor = true;
            this.checkBoxInputNotRecognized.CheckedChanged += new System.EventHandler(this.checkBoxInputNotRecognized_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Всього зображень:";
            // 
            // listView_TrainInput
            // 
            this.listView_TrainInput.HideSelection = false;
            this.listView_TrainInput.Location = new System.Drawing.Point(9, 91);
            this.listView_TrainInput.Margin = new System.Windows.Forms.Padding(4);
            this.listView_TrainInput.Name = "listView_TrainInput";
            this.listView_TrainInput.Size = new System.Drawing.Size(440, 220);
            this.listView_TrainInput.SmallImageList = this.imageList_TrainInput;
            this.listView_TrainInput.TabIndex = 9;
            this.listView_TrainInput.UseCompatibleStateImageBehavior = false;
            this.listView_TrainInput.View = System.Windows.Forms.View.SmallIcon;
            // 
            // imageList_TrainInput
            // 
            this.imageList_TrainInput.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_TrainInput.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_TrainInput.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // textBox_TrainInputCount
            // 
            this.textBox_TrainInputCount.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_TrainInputCount.Enabled = false;
            this.textBox_TrainInputCount.Location = new System.Drawing.Point(387, 62);
            this.textBox_TrainInputCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_TrainInputCount.Name = "textBox_TrainInputCount";
            this.textBox_TrainInputCount.Size = new System.Drawing.Size(62, 21);
            this.textBox_TrainInputCount.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Папка:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxTestNotRecognized);
            this.groupBox2.Controls.Add(this.listView_TestOutput);
            this.groupBox2.Controls.Add(this.textBox_TestIncorectPercent);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_TestOutputCount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_NotRecognizedTestCount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_testFolder);
            this.groupBox2.Controls.Add(this.button_SelectTestFolder);
            this.groupBox2.Controls.Add(this.button_LoadTestFolder);
            this.groupBox2.Location = new System.Drawing.Point(18, 387);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(459, 361);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Зображення для тестування";
            // 
            // checkBoxTestNotRecognized
            // 
            this.checkBoxTestNotRecognized.AutoSize = true;
            this.checkBoxTestNotRecognized.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxTestNotRecognized.Checked = true;
            this.checkBoxTestNotRecognized.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTestNotRecognized.Location = new System.Drawing.Point(14, 319);
            this.checkBoxTestNotRecognized.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxTestNotRecognized.Name = "checkBoxTestNotRecognized";
            this.checkBoxTestNotRecognized.Size = new System.Drawing.Size(137, 19);
            this.checkBoxTestNotRecognized.TabIndex = 13;
            this.checkBoxTestNotRecognized.Text = "Лише нерозпізнані:";
            this.checkBoxTestNotRecognized.UseVisualStyleBackColor = true;
            this.checkBoxTestNotRecognized.CheckedChanged += new System.EventHandler(this.checkBoxTestNotRecognized_CheckedChanged);
            // 
            // listView_TestOutput
            // 
            this.listView_TestOutput.HideSelection = false;
            this.listView_TestOutput.Location = new System.Drawing.Point(12, 86);
            this.listView_TestOutput.Margin = new System.Windows.Forms.Padding(4);
            this.listView_TestOutput.Name = "listView_TestOutput";
            this.listView_TestOutput.Size = new System.Drawing.Size(437, 220);
            this.listView_TestOutput.SmallImageList = this.imageList_TrainInput;
            this.listView_TestOutput.TabIndex = 12;
            this.listView_TestOutput.UseCompatibleStateImageBehavior = false;
            this.listView_TestOutput.View = System.Windows.Forms.View.SmallIcon;
            // 
            // textBox_TestIncorectPercent
            // 
            this.textBox_TestIncorectPercent.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_TestIncorectPercent.Enabled = false;
            this.textBox_TestIncorectPercent.Location = new System.Drawing.Point(386, 316);
            this.textBox_TestIncorectPercent.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_TestIncorectPercent.Name = "textBox_TestIncorectPercent";
            this.textBox_TestIncorectPercent.Size = new System.Drawing.Size(62, 21);
            this.textBox_TestIncorectPercent.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 319);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Частка помилок у %:";
            // 
            // textBox_TestOutputCount
            // 
            this.textBox_TestOutputCount.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_TestOutputCount.Enabled = false;
            this.textBox_TestOutputCount.Location = new System.Drawing.Point(387, 56);
            this.textBox_TestOutputCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_TestOutputCount.Name = "textBox_TestOutputCount";
            this.textBox_TestOutputCount.Size = new System.Drawing.Size(62, 21);
            this.textBox_TestOutputCount.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Всього зображень:";
            // 
            // textBox_NotRecognizedTestCount
            // 
            this.textBox_NotRecognizedTestCount.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_NotRecognizedTestCount.Enabled = false;
            this.textBox_NotRecognizedTestCount.Location = new System.Drawing.Point(185, 318);
            this.textBox_NotRecognizedTestCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_NotRecognizedTestCount.Name = "textBox_NotRecognizedTestCount";
            this.textBox_NotRecognizedTestCount.Size = new System.Drawing.Size(57, 21);
            this.textBox_NotRecognizedTestCount.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Папка:";
            // 
            // textBox_testFolder
            // 
            this.textBox_testFolder.Location = new System.Drawing.Point(72, 28);
            this.textBox_testFolder.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_testFolder.Name = "textBox_testFolder";
            this.textBox_testFolder.Size = new System.Drawing.Size(377, 21);
            this.textBox_testFolder.TabIndex = 0;
            this.textBox_testFolder.Text = "d:\\Users\\Bogdan.Bilyk\\Downloads\\DigitRecognition_pass_1234\\MNIST_data\\test\\100";
            // 
            // button_SelectTestFolder
            // 
            this.button_SelectTestFolder.Location = new System.Drawing.Point(16, 56);
            this.button_SelectTestFolder.Margin = new System.Windows.Forms.Padding(4);
            this.button_SelectTestFolder.Name = "button_SelectTestFolder";
            this.button_SelectTestFolder.Size = new System.Drawing.Size(90, 23);
            this.button_SelectTestFolder.TabIndex = 2;
            this.button_SelectTestFolder.Text = "Обрати";
            this.button_SelectTestFolder.UseVisualStyleBackColor = true;
            this.button_SelectTestFolder.Click += new System.EventHandler(this.button_SelectTestFolder_Click);
            // 
            // button_LoadTestFolder
            // 
            this.button_LoadTestFolder.Location = new System.Drawing.Point(125, 56);
            this.button_LoadTestFolder.Margin = new System.Windows.Forms.Padding(4);
            this.button_LoadTestFolder.Name = "button_LoadTestFolder";
            this.button_LoadTestFolder.Size = new System.Drawing.Size(119, 23);
            this.button_LoadTestFolder.TabIndex = 3;
            this.button_LoadTestFolder.Text = "Завантажити";
            this.button_LoadTestFolder.UseVisualStyleBackColor = true;
            this.button_LoadTestFolder.Click += new System.EventHandler(this.button_LoadTestFolder_Click);
            // 
            // imageList_TestOutput
            // 
            this.imageList_TestOutput.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_TestOutput.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_TestOutput.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxInputSize);
            this.groupBox3.Controls.Add(this.textBoxAlpha);
            this.groupBox3.Controls.Add(this.textBox_Layers);
            this.groupBox3.Controls.Add(this.textBoxStdDev);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.button_CreateNetwork);
            this.groupBox3.Location = new System.Drawing.Point(485, 17);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(322, 139);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Нейромережа";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 90);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Архітектура мережі:";
            // 
            // textBoxInputSize
            // 
            this.textBoxInputSize.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInputSize.Enabled = false;
            this.textBoxInputSize.Location = new System.Drawing.Point(132, 87);
            this.textBoxInputSize.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInputSize.Name = "textBoxInputSize";
            this.textBoxInputSize.Size = new System.Drawing.Size(41, 21);
            this.textBoxInputSize.TabIndex = 11;
            this.textBoxInputSize.Text = "784-";
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Location = new System.Drawing.Point(258, 55);
            this.textBoxAlpha.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(58, 21);
            this.textBoxAlpha.TabIndex = 9;
            this.textBoxAlpha.Text = "0.9";
            this.textBoxAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Layers
            // 
            this.textBox_Layers.Location = new System.Drawing.Point(179, 87);
            this.textBox_Layers.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Layers.Name = "textBox_Layers";
            this.textBox_Layers.Size = new System.Drawing.Size(88, 21);
            this.textBox_Layers.TabIndex = 8;
            this.textBox_Layers.Text = "80-40-20";
            this.textBox_Layers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxStdDev
            // 
            this.textBoxStdDev.Location = new System.Drawing.Point(258, 22);
            this.textBoxStdDev.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStdDev.Name = "textBoxStdDev";
            this.textBoxStdDev.Size = new System.Drawing.Size(58, 21);
            this.textBoxStdDev.TabIndex = 7;
            this.textBoxStdDev.Text = "0.1";
            this.textBoxStdDev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Коефіцієнт крутизни  сигмоїди (Alpha):";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(279, 87);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(36, 21);
            this.textBox7.TabIndex = 5;
            this.textBox7.Text = "-10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Стандартне відхилення початкових ваг:";
            // 
            // button_CreateNetwork
            // 
            this.button_CreateNetwork.Location = new System.Drawing.Point(9, 112);
            this.button_CreateNetwork.Margin = new System.Windows.Forms.Padding(4);
            this.button_CreateNetwork.Name = "button_CreateNetwork";
            this.button_CreateNetwork.Size = new System.Drawing.Size(112, 23);
            this.button_CreateNetwork.TabIndex = 2;
            this.button_CreateNetwork.Text = "Створити";
            this.button_CreateNetwork.UseVisualStyleBackColor = true;
            this.button_CreateNetwork.Click += new System.EventHandler(this.button_CreateNetwork_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_TrainErrorMax);
            this.groupBox4.Controls.Add(this.checkBox_ErrorsTrain);
            this.groupBox4.Controls.Add(this.textBox_ErrorOnOutput);
            this.groupBox4.Controls.Add(this.textBox_MaxTime);
            this.groupBox4.Controls.Add(this.textBox_ErrorOnTestPercent);
            this.groupBox4.Controls.Add(this.checkBox_ErrorsTest);
            this.groupBox4.Controls.Add(this.checkBox_ErrorsOnOutput);
            this.groupBox4.Controls.Add(this.checkBox_Time);
            this.groupBox4.Controls.Add(this.checkBox_PassedEpoch);
            this.groupBox4.Controls.Add(this.textBox_MaxEpoh);
            this.groupBox4.Location = new System.Drawing.Point(815, 17);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(267, 177);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Критерії зупинки навчання";
            // 
            // textBox_TrainErrorMax
            // 
            this.textBox_TrainErrorMax.Location = new System.Drawing.Point(218, 109);
            this.textBox_TrainErrorMax.Name = "textBox_TrainErrorMax";
            this.textBox_TrainErrorMax.Size = new System.Drawing.Size(40, 21);
            this.textBox_TrainErrorMax.TabIndex = 14;
            this.textBox_TrainErrorMax.Text = "-1";
            this.textBox_TrainErrorMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBox_ErrorsTrain
            // 
            this.checkBox_ErrorsTrain.AutoSize = true;
            this.checkBox_ErrorsTrain.Checked = true;
            this.checkBox_ErrorsTrain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ErrorsTrain.Location = new System.Drawing.Point(14, 111);
            this.checkBox_ErrorsTrain.Name = "checkBox_ErrorsTrain";
            this.checkBox_ErrorsTrain.Size = new System.Drawing.Size(175, 19);
            this.checkBox_ErrorsTrain.TabIndex = 13;
            this.checkBox_ErrorsTrain.Text = "Помилки на навч. вив., %:";
            this.checkBox_ErrorsTrain.UseVisualStyleBackColor = true;
            // 
            // textBox_ErrorOnOutput
            // 
            this.textBox_ErrorOnOutput.Location = new System.Drawing.Point(192, 80);
            this.textBox_ErrorOnOutput.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ErrorOnOutput.Name = "textBox_ErrorOnOutput";
            this.textBox_ErrorOnOutput.Size = new System.Drawing.Size(67, 21);
            this.textBox_ErrorOnOutput.TabIndex = 12;
            this.textBox_ErrorOnOutput.Text = "0.01";
            this.textBox_ErrorOnOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_MaxTime
            // 
            this.textBox_MaxTime.Location = new System.Drawing.Point(191, 53);
            this.textBox_MaxTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MaxTime.Name = "textBox_MaxTime";
            this.textBox_MaxTime.Size = new System.Drawing.Size(68, 21);
            this.textBox_MaxTime.TabIndex = 11;
            this.textBox_MaxTime.Text = "00:01:00";
            this.textBox_MaxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_ErrorOnTestPercent
            // 
            this.textBox_ErrorOnTestPercent.Location = new System.Drawing.Point(217, 143);
            this.textBox_ErrorOnTestPercent.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ErrorOnTestPercent.Name = "textBox_ErrorOnTestPercent";
            this.textBox_ErrorOnTestPercent.Size = new System.Drawing.Size(41, 21);
            this.textBox_ErrorOnTestPercent.TabIndex = 10;
            this.textBox_ErrorOnTestPercent.Text = "6";
            this.textBox_ErrorOnTestPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBox_ErrorsTest
            // 
            this.checkBox_ErrorsTest.AutoSize = true;
            this.checkBox_ErrorsTest.Checked = true;
            this.checkBox_ErrorsTest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ErrorsTest.Location = new System.Drawing.Point(14, 145);
            this.checkBox_ErrorsTest.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_ErrorsTest.Name = "checkBox_ErrorsTest";
            this.checkBox_ErrorsTest.Size = new System.Drawing.Size(175, 19);
            this.checkBox_ErrorsTest.TabIndex = 9;
            this.checkBox_ErrorsTest.Text = "Помилка на тест. виб., %:";
            this.checkBox_ErrorsTest.UseVisualStyleBackColor = true;
            // 
            // checkBox_ErrorsOnOutput
            // 
            this.checkBox_ErrorsOnOutput.AutoSize = true;
            this.checkBox_ErrorsOnOutput.Checked = true;
            this.checkBox_ErrorsOnOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ErrorsOnOutput.Location = new System.Drawing.Point(14, 82);
            this.checkBox_ErrorsOnOutput.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_ErrorsOnOutput.Name = "checkBox_ErrorsOnOutput";
            this.checkBox_ErrorsOnOutput.Size = new System.Drawing.Size(135, 19);
            this.checkBox_ErrorsOnOutput.TabIndex = 8;
            this.checkBox_ErrorsOnOutput.Text = "Похибка на 1 вихід";
            this.checkBox_ErrorsOnOutput.UseVisualStyleBackColor = true;
            // 
            // checkBox_Time
            // 
            this.checkBox_Time.AutoSize = true;
            this.checkBox_Time.Location = new System.Drawing.Point(14, 56);
            this.checkBox_Time.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_Time.Name = "checkBox_Time";
            this.checkBox_Time.Size = new System.Drawing.Size(91, 19);
            this.checkBox_Time.TabIndex = 7;
            this.checkBox_Time.Text = "Тривалість";
            this.checkBox_Time.UseVisualStyleBackColor = true;
            // 
            // checkBox_PassedEpoch
            // 
            this.checkBox_PassedEpoch.AutoSize = true;
            this.checkBox_PassedEpoch.Checked = true;
            this.checkBox_PassedEpoch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_PassedEpoch.Location = new System.Drawing.Point(14, 30);
            this.checkBox_PassedEpoch.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_PassedEpoch.Name = "checkBox_PassedEpoch";
            this.checkBox_PassedEpoch.Size = new System.Drawing.Size(110, 19);
            this.checkBox_PassedEpoch.TabIndex = 6;
            this.checkBox_PassedEpoch.Text = "Кількість епох";
            this.checkBox_PassedEpoch.UseVisualStyleBackColor = true;
            // 
            // textBox_MaxEpoh
            // 
            this.textBox_MaxEpoh.Location = new System.Drawing.Point(191, 28);
            this.textBox_MaxEpoh.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MaxEpoh.Name = "textBox_MaxEpoh";
            this.textBox_MaxEpoh.Size = new System.Drawing.Size(67, 21);
            this.textBox_MaxEpoh.TabIndex = 0;
            this.textBox_MaxEpoh.Text = "1000";
            this.textBox_MaxEpoh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxPassedTrainError);
            this.groupBox5.Controls.Add(this.textBoxPassedOutputError);
            this.groupBox5.Controls.Add(this.textBoxPassedTime);
            this.groupBox5.Controls.Add(this.textBoxPassedTestError);
            this.groupBox5.Controls.Add(this.textBoxPassedEpoch);
            this.groupBox5.Location = new System.Drawing.Point(1090, 17);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(82, 177);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Поточні";
            // 
            // textBoxPassedTrainError
            // 
            this.textBoxPassedTrainError.Enabled = false;
            this.textBoxPassedTrainError.Location = new System.Drawing.Point(8, 112);
            this.textBoxPassedTrainError.Name = "textBoxPassedTrainError";
            this.textBoxPassedTrainError.ReadOnly = true;
            this.textBoxPassedTrainError.Size = new System.Drawing.Size(61, 21);
            this.textBoxPassedTrainError.TabIndex = 13;
            this.textBoxPassedTrainError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPassedOutputError
            // 
            this.textBoxPassedOutputError.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPassedOutputError.Enabled = false;
            this.textBoxPassedOutputError.Location = new System.Drawing.Point(9, 80);
            this.textBoxPassedOutputError.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassedOutputError.Name = "textBoxPassedOutputError";
            this.textBoxPassedOutputError.Size = new System.Drawing.Size(60, 21);
            this.textBoxPassedOutputError.TabIndex = 12;
            this.textBoxPassedOutputError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPassedTime
            // 
            this.textBoxPassedTime.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPassedTime.Enabled = false;
            this.textBoxPassedTime.Location = new System.Drawing.Point(9, 54);
            this.textBoxPassedTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassedTime.Name = "textBoxPassedTime";
            this.textBoxPassedTime.Size = new System.Drawing.Size(60, 21);
            this.textBoxPassedTime.TabIndex = 11;
            this.textBoxPassedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPassedTestError
            // 
            this.textBoxPassedTestError.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPassedTestError.Enabled = false;
            this.textBoxPassedTestError.Location = new System.Drawing.Point(9, 144);
            this.textBoxPassedTestError.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassedTestError.Name = "textBoxPassedTestError";
            this.textBoxPassedTestError.Size = new System.Drawing.Size(60, 21);
            this.textBoxPassedTestError.TabIndex = 10;
            this.textBoxPassedTestError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPassedEpoch
            // 
            this.textBoxPassedEpoch.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPassedEpoch.Enabled = false;
            this.textBoxPassedEpoch.Location = new System.Drawing.Point(9, 28);
            this.textBoxPassedEpoch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassedEpoch.Name = "textBoxPassedEpoch";
            this.textBoxPassedEpoch.Size = new System.Drawing.Size(60, 21);
            this.textBoxPassedEpoch.TabIndex = 0;
            this.textBoxPassedEpoch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBoxShuffle);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.textBox_Momentum);
            this.groupBox6.Controls.Add(this.textBox_LearningRate);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(485, 160);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(323, 98);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Навчання";
            // 
            // checkBoxShuffle
            // 
            this.checkBoxShuffle.AutoSize = true;
            this.checkBoxShuffle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShuffle.Checked = true;
            this.checkBoxShuffle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShuffle.Location = new System.Drawing.Point(42, 71);
            this.checkBoxShuffle.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxShuffle.Name = "checkBoxShuffle";
            this.checkBoxShuffle.Size = new System.Drawing.Size(263, 19);
            this.checkBoxShuffle.TabIndex = 12;
            this.checkBoxShuffle.Text = "Тасувати зображенння під час навчання:";
            this.checkBoxShuffle.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Момент (Momentum, [0, 1]):";
            // 
            // textBox_Momentum
            // 
            this.textBox_Momentum.Location = new System.Drawing.Point(255, 46);
            this.textBox_Momentum.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Momentum.Name = "textBox_Momentum";
            this.textBox_Momentum.Size = new System.Drawing.Size(50, 21);
            this.textBox_Momentum.TabIndex = 9;
            this.textBox_Momentum.Text = "0.1";
            this.textBox_Momentum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_LearningRate
            // 
            this.textBox_LearningRate.Location = new System.Drawing.Point(255, 19);
            this.textBox_LearningRate.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_LearningRate.Name = "textBox_LearningRate";
            this.textBox_LearningRate.Size = new System.Drawing.Size(50, 21);
            this.textBox_LearningRate.TabIndex = 7;
            this.textBox_LearningRate.Text = "0.1";
            this.textBox_LearningRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 22);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(250, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Швидкість навчання (Learning Rate, [0, 1]):";
            // 
            // button_Start
            // 
            this.button_Start.Enabled = false;
            this.button_Start.Location = new System.Drawing.Point(815, 202);
            this.button_Start.Margin = new System.Windows.Forms.Padding(4);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(357, 53);
            this.button_Start.TabIndex = 15;
            this.button_Start.Text = "Навчати";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // chartMain
            // 
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.Title = "Епоха";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Blue;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Blue;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.Title = "Частка помилок, %";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.Blue;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.Orange;
            chartArea2.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Orange;
            chartArea2.AxisY2.Title = "Середньоквадратична похибка на 1 виході";
            chartArea2.AxisY2.TitleForeColor = System.Drawing.Color.Orange;
            chartArea2.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea2);
            legend2.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.ReversedSeriesOrder;
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 9.82906F;
            legend2.Position.Width = 34.93151F;
            legend2.Position.X = 62.06849F;
            legend2.Position.Y = 3F;
            legend2.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.chartMain.Legends.Add(legend2);
            this.chartMain.Location = new System.Drawing.Point(485, 274);
            this.chartMain.Margin = new System.Windows.Forms.Padding(4);
            this.chartMain.Name = "chartMain";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Color = System.Drawing.Color.Aquamarine;
            series4.Legend = "Legend1";
            series4.Name = "Помилка на навчальних даних";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Color = System.Drawing.Color.Blue;
            series5.Legend = "Legend1";
            series5.Name = "Помилка на тестових даних";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Color = System.Drawing.Color.Brown;
            series6.Legend = "Legend1";
            series6.Name = "СК похибка на 1 виході";
            series6.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series6.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chartMain.Series.Add(series4);
            this.chartMain.Series.Add(series5);
            this.chartMain.Series.Add(series6);
            this.chartMain.Size = new System.Drawing.Size(687, 469);
            this.chartMain.TabIndex = 16;
            this.chartMain.Text = "chartMain";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 756);
            this.Controls.Add(this.chartMain);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DigitRecognition Bilyk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox textBox_trainFolder;
        private System.Windows.Forms.Button button_SelectTrainFolder;
        private System.Windows.Forms.Button button_LoadTrainFolder;
        private System.Windows.Forms.Button button_MixTrainInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_TrainInput;
        private System.Windows.Forms.TextBox textBox_TrainInputCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_TestIncorectPercent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_TestOutputCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_NotRecognizedTestCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_testFolder;
        private System.Windows.Forms.Button button_SelectTestFolder;
        private System.Windows.Forms.Button button_LoadTestFolder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxInputSize;
        private System.Windows.Forms.TextBox textBoxAlpha;
        private System.Windows.Forms.TextBox textBox_Layers;
        private System.Windows.Forms.TextBox textBoxStdDev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_CreateNetwork;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_ErrorOnOutput;
        private System.Windows.Forms.TextBox textBox_MaxTime;
        private System.Windows.Forms.TextBox textBox_ErrorOnTestPercent;
        private System.Windows.Forms.CheckBox checkBox_ErrorsTest;
        private System.Windows.Forms.CheckBox checkBox_ErrorsOnOutput;
        private System.Windows.Forms.CheckBox checkBox_Time;
        private System.Windows.Forms.CheckBox checkBox_PassedEpoch;
        private System.Windows.Forms.TextBox textBox_MaxEpoh;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxPassedOutputError;
        private System.Windows.Forms.TextBox textBoxPassedTime;
        private System.Windows.Forms.TextBox textBoxPassedTestError;
        private System.Windows.Forms.TextBox textBoxPassedEpoch;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Momentum;
        private System.Windows.Forms.TextBox textBox_LearningRate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.ListView listView_TestOutput;
        private System.Windows.Forms.TextBox textBoxInputNotRecognized;
        private System.Windows.Forms.CheckBox checkBoxInputNotRecognized;
        private System.Windows.Forms.CheckBox checkBoxTestNotRecognized;
        private System.Windows.Forms.CheckBox checkBoxShuffle;
        private System.Windows.Forms.ImageList imageList_TrainInput;
        private System.Windows.Forms.ImageList imageList_TestOutput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_TrainIncorectPercent;
        private System.Windows.Forms.TextBox textBox_TrainErrorMax;
        private System.Windows.Forms.CheckBox checkBox_ErrorsTrain;
        private System.Windows.Forms.TextBox textBoxPassedTrainError;
    }
}


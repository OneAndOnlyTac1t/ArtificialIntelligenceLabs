
namespace _1D_CSPBilyk
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.endAmountOfUsedBilletsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalDetailsLenghtTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.detailsAmountTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.billetLengthTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.maxIterationsAmountTextBox = new System.Windows.Forms.TextBox();
            this.fitnessFunctionComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.selectionOperationComboBox = new System.Windows.Forms.ComboBox();
            this.mutationRateTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.populationSizeTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.fitnessFunctionValueTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.usedBilletsTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.iterationTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resultTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 594);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "План розкрою";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(6, 19);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(495, 569);
            this.resultTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.loadButton);
            this.groupBox3.Controls.Add(this.endAmountOfUsedBilletsTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.totalDetailsLenghtTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.detailsAmountTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.billetLengthTextBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(525, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 153);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Заготівки та деталі";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(39, 124);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(87, 23);
            this.loadButton.TabIndex = 16;
            this.loadButton.Text = "Завантажити";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // endAmountOfUsedBilletsTextBox
            // 
            this.endAmountOfUsedBilletsTextBox.Location = new System.Drawing.Point(220, 102);
            this.endAmountOfUsedBilletsTextBox.Name = "endAmountOfUsedBilletsTextBox";
            this.endAmountOfUsedBilletsTextBox.ReadOnly = true;
            this.endAmountOfUsedBilletsTextBox.Size = new System.Drawing.Size(37, 20);
            this.endAmountOfUsedBilletsTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Цільова кількість задіяних заготівок:";
            // 
            // totalDetailsLenghtTextBox
            // 
            this.totalDetailsLenghtTextBox.Location = new System.Drawing.Point(220, 76);
            this.totalDetailsLenghtTextBox.Name = "totalDetailsLenghtTextBox";
            this.totalDetailsLenghtTextBox.ReadOnly = true;
            this.totalDetailsLenghtTextBox.Size = new System.Drawing.Size(37, 20);
            this.totalDetailsLenghtTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Загальна довжина деталей:";
            // 
            // detailsAmountTextBox
            // 
            this.detailsAmountTextBox.Location = new System.Drawing.Point(220, 50);
            this.detailsAmountTextBox.Name = "detailsAmountTextBox";
            this.detailsAmountTextBox.ReadOnly = true;
            this.detailsAmountTextBox.Size = new System.Drawing.Size(37, 20);
            this.detailsAmountTextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Всього деталей:";
            // 
            // billetLengthTextBox
            // 
            this.billetLengthTextBox.Location = new System.Drawing.Point(220, 27);
            this.billetLengthTextBox.Name = "billetLengthTextBox";
            this.billetLengthTextBox.ReadOnly = true;
            this.billetLengthTextBox.Size = new System.Drawing.Size(37, 20);
            this.billetLengthTextBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Довжина заготівок:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.maxIterationsAmountTextBox);
            this.groupBox4.Controls.Add(this.fitnessFunctionComboBox);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.selectionOperationComboBox);
            this.groupBox4.Controls.Add(this.mutationRateTextBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.populationSizeTextBox);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(525, 324);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 147);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Налаштування ГА";
            // 
            // maxIterationsAmountTextBox
            // 
            this.maxIterationsAmountTextBox.Location = new System.Drawing.Point(197, 118);
            this.maxIterationsAmountTextBox.Name = "maxIterationsAmountTextBox";
            this.maxIterationsAmountTextBox.Size = new System.Drawing.Size(60, 20);
            this.maxIterationsAmountTextBox.TabIndex = 11;
            // 
            // fitnessFunctionComboBox
            // 
            this.fitnessFunctionComboBox.FormattingEnabled = true;
            this.fitnessFunctionComboBox.Items.AddRange(new object[] {
            "(1)",
            "(2)"});
            this.fitnessFunctionComboBox.Location = new System.Drawing.Point(220, 65);
            this.fitnessFunctionComboBox.Name = "fitnessFunctionComboBox";
            this.fitnessFunctionComboBox.Size = new System.Drawing.Size(37, 21);
            this.fitnessFunctionComboBox.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(176, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Максимальна кількість поколінь:";
            // 
            // selectionOperationComboBox
            // 
            this.selectionOperationComboBox.FormattingEnabled = true;
            this.selectionOperationComboBox.Items.AddRange(new object[] {
            "Elite",
            "Rank",
            "Roulette"});
            this.selectionOperationComboBox.Location = new System.Drawing.Point(197, 40);
            this.selectionOperationComboBox.Name = "selectionOperationComboBox";
            this.selectionOperationComboBox.Size = new System.Drawing.Size(60, 21);
            this.selectionOperationComboBox.TabIndex = 24;
            // 
            // mutationRateTextBox
            // 
            this.mutationRateTextBox.Location = new System.Drawing.Point(220, 92);
            this.mutationRateTextBox.Name = "mutationRateTextBox";
            this.mutationRateTextBox.Size = new System.Drawing.Size(37, 20);
            this.mutationRateTextBox.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Імовірність мутації:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Формула фітнес-функції:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Оператор відбору:";
            // 
            // populationSizeTextBox
            // 
            this.populationSizeTextBox.Location = new System.Drawing.Point(220, 17);
            this.populationSizeTextBox.Name = "populationSizeTextBox";
            this.populationSizeTextBox.Size = new System.Drawing.Size(37, 20);
            this.populationSizeTextBox.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Розмір популяції:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.fitnessFunctionValueTextBox);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.usedBilletsTextBox);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.iterationTextBox);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Location = new System.Drawing.Point(526, 477);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(262, 100);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Поточне покоління";
            // 
            // fitnessFunctionValueTextBox
            // 
            this.fitnessFunctionValueTextBox.Location = new System.Drawing.Point(196, 65);
            this.fitnessFunctionValueTextBox.Name = "fitnessFunctionValueTextBox";
            this.fitnessFunctionValueTextBox.ReadOnly = true;
            this.fitnessFunctionValueTextBox.Size = new System.Drawing.Size(61, 20);
            this.fitnessFunctionValueTextBox.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Значення фітнес-функції:";
            // 
            // usedBilletsTextBox
            // 
            this.usedBilletsTextBox.Location = new System.Drawing.Point(196, 39);
            this.usedBilletsTextBox.Name = "usedBilletsTextBox";
            this.usedBilletsTextBox.ReadOnly = true;
            this.usedBilletsTextBox.Size = new System.Drawing.Size(61, 20);
            this.usedBilletsTextBox.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Задіяно заготівок:";
            // 
            // iterationTextBox
            // 
            this.iterationTextBox.Location = new System.Drawing.Point(196, 16);
            this.iterationTextBox.Name = "iterationTextBox";
            this.iterationTextBox.ReadOnly = true;
            this.iterationTextBox.Size = new System.Drawing.Size(61, 20);
            this.iterationTextBox.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Покоління:";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(713, 583);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 11;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(632, 583);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Bilyk";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox endAmountOfUsedBilletsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalDetailsLenghtTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox detailsAmountTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox billetLengthTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox maxIterationsAmountTextBox;
        private System.Windows.Forms.ComboBox fitnessFunctionComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox selectionOperationComboBox;
        private System.Windows.Forms.TextBox mutationRateTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox populationSizeTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox fitnessFunctionValueTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox usedBilletsTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox iterationTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}


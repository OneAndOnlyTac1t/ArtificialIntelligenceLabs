
namespace TCPBilyk
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
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pathTimeTextBox = new System.Windows.Forms.TextBox();
            this.Path = new System.Windows.Forms.Label();
            this.pathLengthBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.currentIterationBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mutationRateTextBox = new System.Windows.Forms.TextBox();
            this.finalSpeedTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iterationsBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selectionBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.populationSizeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mapControl = new Accord.Controls.Chart();
            this.generateMapButton = new System.Windows.Forms.Button();
            this.citiesCountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(432, 327);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 9;
            this.stopButton.Text = "S&top";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(342, 327);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "&Start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pathTimeTextBox);
            this.groupBox3.Controls.Add(this.Path);
            this.groupBox3.Controls.Add(this.pathLengthBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.currentIterationBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(322, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 104);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current iteration";
            // 
            // pathTimeTextBox
            // 
            this.pathTimeTextBox.Location = new System.Drawing.Point(125, 43);
            this.pathTimeTextBox.Name = "pathTimeTextBox";
            this.pathTimeTextBox.ReadOnly = true;
            this.pathTimeTextBox.Size = new System.Drawing.Size(50, 20);
            this.pathTimeTextBox.TabIndex = 5;
            // 
            // Path
            // 
            this.Path.AutoSize = true;
            this.Path.Location = new System.Drawing.Point(10, 45);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(54, 13);
            this.Path.TabIndex = 4;
            this.Path.Text = "Path time:";
            // 
            // pathLengthBox
            // 
            this.pathLengthBox.Location = new System.Drawing.Point(125, 72);
            this.pathLengthBox.Name = "pathLengthBox";
            this.pathLengthBox.ReadOnly = true;
            this.pathLengthBox.Size = new System.Drawing.Size(50, 20);
            this.pathLengthBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Path length:";
            // 
            // currentIterationBox
            // 
            this.currentIterationBox.Location = new System.Drawing.Point(125, 15);
            this.currentIterationBox.Name = "currentIterationBox";
            this.currentIterationBox.ReadOnly = true;
            this.currentIterationBox.Size = new System.Drawing.Size(50, 20);
            this.currentIterationBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Iteration:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mutationRateTextBox);
            this.groupBox2.Controls.Add(this.finalSpeedTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.iterationsBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.selectionBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.populationSizeBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(322, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 195);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // mutationRateTextBox
            // 
            this.mutationRateTextBox.Location = new System.Drawing.Point(125, 105);
            this.mutationRateTextBox.Name = "mutationRateTextBox";
            this.mutationRateTextBox.Size = new System.Drawing.Size(50, 20);
            this.mutationRateTextBox.TabIndex = 10;
            // 
            // finalSpeedTextBox
            // 
            this.finalSpeedTextBox.Location = new System.Drawing.Point(125, 131);
            this.finalSpeedTextBox.Name = "finalSpeedTextBox";
            this.finalSpeedTextBox.Size = new System.Drawing.Size(50, 20);
            this.finalSpeedTextBox.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mutation Rate:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Final speed:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "( 0 - inifinity )";
            // 
            // iterationsBox
            // 
            this.iterationsBox.Location = new System.Drawing.Point(125, 157);
            this.iterationsBox.Name = "iterationsBox";
            this.iterationsBox.Size = new System.Drawing.Size(50, 20);
            this.iterationsBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Iterations:";
            // 
            // selectionBox
            // 
            this.selectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionBox.Items.AddRange(new object[] {
            "Elite",
            "Rank",
            "Roulette"});
            this.selectionBox.Location = new System.Drawing.Point(110, 45);
            this.selectionBox.Name = "selectionBox";
            this.selectionBox.Size = new System.Drawing.Size(65, 21);
            this.selectionBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selection method:";
            // 
            // populationSizeBox
            // 
            this.populationSizeBox.Location = new System.Drawing.Point(125, 20);
            this.populationSizeBox.Name = "populationSizeBox";
            this.populationSizeBox.Size = new System.Drawing.Size(50, 20);
            this.populationSizeBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Population size:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.mapControl);
            this.groupBox1.Controls.Add(this.generateMapButton);
            this.groupBox1.Controls.Add(this.citiesCountBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 340);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // mapControl
            // 
            this.mapControl.Location = new System.Drawing.Point(6, 13);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(280, 280);
            this.mapControl.TabIndex = 4;
            // 
            // generateMapButton
            // 
            this.generateMapButton.Location = new System.Drawing.Point(102, 309);
            this.generateMapButton.Name = "generateMapButton";
            this.generateMapButton.Size = new System.Drawing.Size(75, 22);
            this.generateMapButton.TabIndex = 3;
            this.generateMapButton.Text = "&Generate";
            this.generateMapButton.Click += new System.EventHandler(this.generateMapButton_Click);
            // 
            // citiesCountBox
            // 
            this.citiesCountBox.Location = new System.Drawing.Point(50, 310);
            this.citiesCountBox.Name = "citiesCountBox";
            this.citiesCountBox.Size = new System.Drawing.Size(50, 20);
            this.citiesCountBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cities:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 360);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bilyk";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox pathLengthBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox currentIterationBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox iterationsBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox selectionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox populationSizeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button generateMapButton;
        private System.Windows.Forms.TextBox citiesCountBox;
        private System.Windows.Forms.Label label1;
        private Accord.Controls.Chart mapControl;
        private System.Windows.Forms.TextBox mutationRateTextBox;
        private System.Windows.Forms.TextBox finalSpeedTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pathTimeTextBox;
        private System.Windows.Forms.Label Path;
    }
}


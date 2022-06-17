
namespace MulticlassClassifier
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
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.errorTextbox = new System.Windows.Forms.TextBox();
            this.passedIterationsTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxErrorTextbox = new System.Windows.Forms.TextBox();
            this.iterationsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.learningRateTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chart = new Accord.Controls.Chart();
            this.SuspendLayout();
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(393, 62);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(393, 292);
            this.logTextBox.TabIndex = 30;
            // 
            // errorTextbox
            // 
            this.errorTextbox.Location = new System.Drawing.Point(743, 409);
            this.errorTextbox.Name = "errorTextbox";
            this.errorTextbox.ReadOnly = true;
            this.errorTextbox.Size = new System.Drawing.Size(43, 20);
            this.errorTextbox.TabIndex = 29;
            // 
            // passedIterationsTextbox
            // 
            this.passedIterationsTextbox.Location = new System.Drawing.Point(743, 385);
            this.passedIterationsTextbox.Name = "passedIterationsTextbox";
            this.passedIterationsTextbox.ReadOnly = true;
            this.passedIterationsTextbox.Size = new System.Drawing.Size(43, 20);
            this.passedIterationsTextbox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(701, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Error:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(654, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Passed epochs:";
            // 
            // maxErrorTextbox
            // 
            this.maxErrorTextbox.Location = new System.Drawing.Point(604, 409);
            this.maxErrorTextbox.Name = "maxErrorTextbox";
            this.maxErrorTextbox.Size = new System.Drawing.Size(41, 20);
            this.maxErrorTextbox.TabIndex = 25;
            // 
            // iterationsTextBox
            // 
            this.iterationsTextBox.Location = new System.Drawing.Point(604, 385);
            this.iterationsTextBox.Name = "iterationsTextBox";
            this.iterationsTextBox.Size = new System.Drawing.Size(40, 20);
            this.iterationsTextBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Maxinum number of epochs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Maximum error:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(393, 360);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 69);
            this.startButton.TabIndex = 21;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(704, 21);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 19;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(614, 21);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 18;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(47, 23);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(552, 20);
            this.filePathTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "File:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(474, 360);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(173, 17);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "Random initialization of weights";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // learningRateTextbox
            // 
            this.learningRateTextbox.Location = new System.Drawing.Point(743, 358);
            this.learningRateTextbox.Name = "learningRateTextbox";
            this.learningRateTextbox.Size = new System.Drawing.Size(43, 20);
            this.learningRateTextbox.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(664, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Learning rate:";
            // 
            // chart
            // 
            this.chart.Location = new System.Drawing.Point(18, 62);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(356, 363);
            this.chart.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.learningRateTextbox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.errorTextbox);
            this.Controls.Add(this.passedIterationsTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maxErrorTextbox);
            this.Controls.Add(this.iterationsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.TextBox errorTextbox;
        private System.Windows.Forms.TextBox passedIterationsTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maxErrorTextbox;
        private System.Windows.Forms.TextBox iterationsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox learningRateTextbox;
        private System.Windows.Forms.Label label6;
        private Accord.Controls.Chart chart;
    }
}


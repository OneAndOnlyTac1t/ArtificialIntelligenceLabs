
namespace BinaryClassifierBilyk
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
            this.label1 = new System.Windows.Forms.Label();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.coordinatesPictureBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iterationsTextBox = new System.Windows.Forms.TextBox();
            this.maxErrorTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passedIterationsTextbox = new System.Windows.Forms.TextBox();
            this.errorTextbox = new System.Windows.Forms.TextBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(45, 10);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(552, 20);
            this.filePathTextBox.TabIndex = 1;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(612, 8);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(702, 8);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 3;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // coordinatesPictureBox
            // 
            this.coordinatesPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.coordinatesPictureBox.Location = new System.Drawing.Point(16, 49);
            this.coordinatesPictureBox.Name = "coordinatesPictureBox";
            this.coordinatesPictureBox.Size = new System.Drawing.Size(369, 367);
            this.coordinatesPictureBox.TabIndex = 5;
            this.coordinatesPictureBox.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(391, 372);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 44);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Maximum error:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(466, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Maxinum number of epochs:";
            // 
            // iterationsTextBox
            // 
            this.iterationsTextBox.Location = new System.Drawing.Point(602, 372);
            this.iterationsTextBox.Name = "iterationsTextBox";
            this.iterationsTextBox.Size = new System.Drawing.Size(40, 20);
            this.iterationsTextBox.TabIndex = 9;
            // 
            // maxErrorTextbox
            // 
            this.maxErrorTextbox.Location = new System.Drawing.Point(602, 396);
            this.maxErrorTextbox.Name = "maxErrorTextbox";
            this.maxErrorTextbox.Size = new System.Drawing.Size(41, 20);
            this.maxErrorTextbox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Passed epochs:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(699, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Error:";
            // 
            // passedIterationsTextbox
            // 
            this.passedIterationsTextbox.Location = new System.Drawing.Point(741, 372);
            this.passedIterationsTextbox.Name = "passedIterationsTextbox";
            this.passedIterationsTextbox.ReadOnly = true;
            this.passedIterationsTextbox.Size = new System.Drawing.Size(43, 20);
            this.passedIterationsTextbox.TabIndex = 13;
            // 
            // errorTextbox
            // 
            this.errorTextbox.Location = new System.Drawing.Point(741, 396);
            this.errorTextbox.Name = "errorTextbox";
            this.errorTextbox.ReadOnly = true;
            this.errorTextbox.Size = new System.Drawing.Size(43, 20);
            this.errorTextbox.TabIndex = 14;
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(391, 49);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(393, 317);
            this.logTextBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.coordinatesPictureBox);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.coordinatesPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.PictureBox coordinatesPictureBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox iterationsTextBox;
        private System.Windows.Forms.TextBox maxErrorTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passedIterationsTextbox;
        private System.Windows.Forms.TextBox errorTextbox;
        private System.Windows.Forms.TextBox logTextBox;
    }
}


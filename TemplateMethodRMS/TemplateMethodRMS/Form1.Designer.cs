namespace TemplateMethodRMS
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rmsLabel = new System.Windows.Forms.Label();
            this.waveformTB = new System.Windows.Forms.TextBox();
            this.startTB = new System.Windows.Forms.TextBox();
            this.endTB = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Waveform Expression";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Root Mean Square Value";
            // 
            // rmsLabel
            // 
            this.rmsLabel.AutoSize = true;
            this.rmsLabel.Location = new System.Drawing.Point(187, 194);
            this.rmsLabel.Name = "rmsLabel";
            this.rmsLabel.Size = new System.Drawing.Size(10, 13);
            this.rmsLabel.TabIndex = 4;
            this.rmsLabel.Text = " ";
            // 
            // waveformTB
            // 
            this.waveformTB.Location = new System.Drawing.Point(190, 29);
            this.waveformTB.Name = "waveformTB";
            this.waveformTB.Size = new System.Drawing.Size(100, 20);
            this.waveformTB.TabIndex = 5;
            // 
            // startTB
            // 
            this.startTB.Location = new System.Drawing.Point(190, 51);
            this.startTB.Name = "startTB";
            this.startTB.Size = new System.Drawing.Size(100, 20);
            this.startTB.TabIndex = 6;
            // 
            // endTB
            // 
            this.endTB.Location = new System.Drawing.Point(190, 74);
            this.endTB.Name = "endTB";
            this.endTB.Size = new System.Drawing.Size(100, 20);
            this.endTB.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(133, 133);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 234);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.endTB);
            this.Controls.Add(this.startTB);
            this.Controls.Add(this.waveformTB);
            this.Controls.Add(this.rmsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label rmsLabel;
        private System.Windows.Forms.TextBox waveformTB;
        private System.Windows.Forms.TextBox startTB;
        private System.Windows.Forms.TextBox endTB;
        private System.Windows.Forms.Button calculateButton;
    }
}


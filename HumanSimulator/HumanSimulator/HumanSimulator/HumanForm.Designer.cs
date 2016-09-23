namespace HumanSimulator
{
    partial class HumanForm
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
            this.sleepLabel = new System.Windows.Forms.Label();
            this.workLabel = new System.Windows.Forms.Label();
            this.happinessLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sleepLabel
            // 
            this.sleepLabel.AutoSize = true;
            this.sleepLabel.Location = new System.Drawing.Point(151, 124);
            this.sleepLabel.Name = "sleepLabel";
            this.sleepLabel.Size = new System.Drawing.Size(0, 13);
            this.sleepLabel.TabIndex = 5;
            this.sleepLabel.Text = "Sleep Numbers";
            // 
            // workLabel
            // 
            this.workLabel.AutoSize = true;
            this.workLabel.Location = new System.Drawing.Point(151, 175);
            this.workLabel.Name = "workLabel";
            this.workLabel.Size = new System.Drawing.Size(79, 13);
            this.workLabel.TabIndex = 6;
            this.workLabel.Text = " Work numbers";
            // 
            // happinessLabel
            // 
            this.happinessLabel.AutoSize = true;
            this.happinessLabel.Location = new System.Drawing.Point(151, 150);
            this.happinessLabel.Name = "happinessLabel";
            this.happinessLabel.Size = new System.Drawing.Size(0, 13);
            this.happinessLabel.TabIndex = 7;
            this.happinessLabel.Text = "Happiness Numbers";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Location = new System.Drawing.Point(151, 97);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(84, 13);
            this.healthLabel.TabIndex = 8;
            this.healthLabel.Text = " Health numbers";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(110, 55);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(24, 13);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Joe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Health";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Happiness";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Work";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Sleep";
            // 
            // HumanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 261);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.happinessLabel);
            this.Controls.Add(this.workLabel);
            this.Controls.Add(this.sleepLabel);
            this.Name = "HumanForm";
            this.Text = "HumanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sleepLabel;
        private System.Windows.Forms.Label workLabel;
        private System.Windows.Forms.Label happinessLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
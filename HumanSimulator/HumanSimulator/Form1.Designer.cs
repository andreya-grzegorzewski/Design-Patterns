namespace HumanSimulator
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
            this.createHumanButton = new System.Windows.Forms.Button();
            this.deadHumansLB = new System.Windows.Forms.ListBox();
            this.healthTB = new System.Windows.Forms.TextBox();
            this.workTB = new System.Windows.Forms.TextBox();
            this.happinessTB = new System.Windows.Forms.TextBox();
            this.sleepTB = new System.Windows.Forms.TextBox();
            this.dayLabel = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sleep";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Work";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Happiness";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Health";
            // 
            // createHumanButton
            // 
            this.createHumanButton.Location = new System.Drawing.Point(510, 60);
            this.createHumanButton.Name = "createHumanButton";
            this.createHumanButton.Size = new System.Drawing.Size(75, 23);
            this.createHumanButton.TabIndex = 5;
            this.createHumanButton.Text = "Create Human";
            this.createHumanButton.UseVisualStyleBackColor = true;
            this.createHumanButton.Click += new System.EventHandler(this.createHumanButton_Click);
            // 
            // deadHumansLB
            // 
            this.deadHumansLB.FormattingEnabled = true;
            this.deadHumansLB.Location = new System.Drawing.Point(17, 216);
            this.deadHumansLB.Name = "deadHumansLB";
            this.deadHumansLB.Size = new System.Drawing.Size(645, 251);
            this.deadHumansLB.TabIndex = 6;
            // 
            // healthTB
            // 
            this.healthTB.Location = new System.Drawing.Point(180, 75);
            this.healthTB.Name = "healthTB";
            this.healthTB.Size = new System.Drawing.Size(100, 20);
            this.healthTB.TabIndex = 7;
            this.healthTB.Text = "3";
            // 
            // workTB
            // 
            this.workTB.Location = new System.Drawing.Point(180, 150);
            this.workTB.Name = "workTB";
            this.workTB.Size = new System.Drawing.Size(100, 20);
            this.workTB.TabIndex = 8;
            this.workTB.Text = "8";
            // 
            // happinessTB
            // 
            this.happinessTB.Location = new System.Drawing.Point(180, 127);
            this.happinessTB.Name = "happinessTB";
            this.happinessTB.Size = new System.Drawing.Size(100, 20);
            this.happinessTB.TabIndex = 9;
            this.happinessTB.Text = "5";
            // 
            // sleepTB
            // 
            this.sleepTB.Location = new System.Drawing.Point(180, 101);
            this.sleepTB.Name = "sleepTB";
            this.sleepTB.Size = new System.Drawing.Size(100, 20);
            this.sleepTB.TabIndex = 10;
            this.sleepTB.Text = "8";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(373, 482);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(35, 13);
            this.dayLabel.TabIndex = 11;
            this.dayLabel.Text = "Day 1";
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(252, 482);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(28, 13);
            this.hourLabel.TabIndex = 12;
            this.hourLabel.Text = "0:00";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(108, 31);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 13;
            this.nameTB.Text = "Joe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 517);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.sleepTB);
            this.Controls.Add(this.happinessTB);
            this.Controls.Add(this.workTB);
            this.Controls.Add(this.healthTB);
            this.Controls.Add(this.deadHumansLB);
            this.Controls.Add(this.createHumanButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createHumanButton;
        private System.Windows.Forms.ListBox deadHumansLB;
        private System.Windows.Forms.TextBox healthTB;
        private System.Windows.Forms.TextBox workTB;
        private System.Windows.Forms.TextBox happinessTB;
        private System.Windows.Forms.TextBox sleepTB;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.TextBox nameTB;
    }
}


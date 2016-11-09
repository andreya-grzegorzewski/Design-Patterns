namespace ImpedanceBridge
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.polarRB = new System.Windows.Forms.RadioButton();
            this.rectangularRB = new System.Windows.Forms.RadioButton();
            this.numberTB1 = new System.Windows.Forms.TextBox();
            this.numberTB2 = new System.Windows.Forms.TextBox();
            this.operationCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTB = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.polarRB);
            this.panel1.Controls.Add(this.rectangularRB);
            this.panel1.Location = new System.Drawing.Point(327, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 66);
            this.panel1.TabIndex = 0;
            // 
            // polarRB
            // 
            this.polarRB.AutoSize = true;
            this.polarRB.Location = new System.Drawing.Point(15, 37);
            this.polarRB.Name = "polarRB";
            this.polarRB.Size = new System.Drawing.Size(49, 17);
            this.polarRB.TabIndex = 1;
            this.polarRB.TabStop = true;
            this.polarRB.Text = "Polar";
            this.polarRB.UseVisualStyleBackColor = true;
            this.polarRB.CheckedChanged += new System.EventHandler(this.polarRB_CheckedChanged);
            // 
            // rectangularRB
            // 
            this.rectangularRB.AutoSize = true;
            this.rectangularRB.Location = new System.Drawing.Point(15, 14);
            this.rectangularRB.Name = "rectangularRB";
            this.rectangularRB.Size = new System.Drawing.Size(83, 17);
            this.rectangularRB.TabIndex = 0;
            this.rectangularRB.TabStop = true;
            this.rectangularRB.Text = "Rectangular";
            this.rectangularRB.UseVisualStyleBackColor = true;
            this.rectangularRB.CheckedChanged += new System.EventHandler(this.rectangularRB_CheckedChanged);
            // 
            // numberTB1
            // 
            this.numberTB1.Location = new System.Drawing.Point(31, 30);
            this.numberTB1.Name = "numberTB1";
            this.numberTB1.Size = new System.Drawing.Size(100, 20);
            this.numberTB1.TabIndex = 1;
            // 
            // numberTB2
            // 
            this.numberTB2.Location = new System.Drawing.Point(327, 30);
            this.numberTB2.Name = "numberTB2";
            this.numberTB2.Size = new System.Drawing.Size(100, 20);
            this.numberTB2.TabIndex = 2;
            // 
            // operationCB
            // 
            this.operationCB.FormattingEnabled = true;
            this.operationCB.Location = new System.Drawing.Point(149, 30);
            this.operationCB.Name = "operationCB";
            this.operationCB.Size = new System.Drawing.Size(162, 21);
            this.operationCB.TabIndex = 3;
            this.operationCB.Text = "Select operation...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Result:";
            // 
            // resultTB
            // 
            this.resultTB.Location = new System.Drawing.Point(74, 130);
            this.resultTB.Name = "resultTB";
            this.resultTB.Size = new System.Drawing.Size(100, 20);
            this.resultTB.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(31, 80);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 181);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.operationCB);
            this.Controls.Add(this.numberTB2);
            this.Controls.Add(this.numberTB1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Impedance Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton polarRB;
        private System.Windows.Forms.RadioButton rectangularRB;
        private System.Windows.Forms.TextBox numberTB1;
        private System.Windows.Forms.TextBox numberTB2;
        private System.Windows.Forms.ComboBox operationCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultTB;
        private System.Windows.Forms.Button calculateButton;
    }
}


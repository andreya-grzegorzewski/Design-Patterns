namespace Iterator_Pattern
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
            this.iterForwardButton = new System.Windows.Forms.Button();
            this.iterBackwardButton = new System.Windows.Forms.Button();
            this.namesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // iterForwardButton
            // 
            this.iterForwardButton.Location = new System.Drawing.Point(32, 24);
            this.iterForwardButton.Name = "iterForwardButton";
            this.iterForwardButton.Size = new System.Drawing.Size(106, 23);
            this.iterForwardButton.TabIndex = 0;
            this.iterForwardButton.Text = "Iterate Forward";
            this.iterForwardButton.UseVisualStyleBackColor = true;
            this.iterForwardButton.Click += new System.EventHandler(this.iterForwardButton_Click);
            // 
            // iterBackwardButton
            // 
            this.iterBackwardButton.Location = new System.Drawing.Point(32, 54);
            this.iterBackwardButton.Name = "iterBackwardButton";
            this.iterBackwardButton.Size = new System.Drawing.Size(106, 23);
            this.iterBackwardButton.TabIndex = 1;
            this.iterBackwardButton.Text = "Iterate Backward";
            this.iterBackwardButton.UseVisualStyleBackColor = true;
            this.iterBackwardButton.Click += new System.EventHandler(this.iterBackwardButton_Click);
            // 
            // namesListBox
            // 
            this.namesListBox.FormattingEnabled = true;
            this.namesListBox.Location = new System.Drawing.Point(32, 84);
            this.namesListBox.Name = "namesListBox";
            this.namesListBox.Size = new System.Drawing.Size(333, 524);
            this.namesListBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 650);
            this.Controls.Add(this.namesListBox);
            this.Controls.Add(this.iterBackwardButton);
            this.Controls.Add(this.iterForwardButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button iterForwardButton;
        private System.Windows.Forms.Button iterBackwardButton;
        private System.Windows.Forms.ListBox namesListBox;
    }
}


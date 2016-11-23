namespace GirlfriendState
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
            this.feedButton = new System.Windows.Forms.Button();
            this.complimentButton = new System.Windows.Forms.Button();
            this.antagonizeButton = new System.Windows.Forms.Button();
            this.ignoreButton = new System.Windows.Forms.Button();
            this.girlfriendStateLabel = new System.Windows.Forms.Label();
            this.acknowledgementsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // feedButton
            // 
            this.feedButton.Location = new System.Drawing.Point(30, 30);
            this.feedButton.Name = "feedButton";
            this.feedButton.Size = new System.Drawing.Size(158, 23);
            this.feedButton.TabIndex = 0;
            this.feedButton.Text = "Feed Your Girlfriend";
            this.feedButton.UseVisualStyleBackColor = true;
            this.feedButton.Click += new System.EventHandler(this.feedButton_Click);
            // 
            // complimentButton
            // 
            this.complimentButton.Location = new System.Drawing.Point(30, 59);
            this.complimentButton.Name = "complimentButton";
            this.complimentButton.Size = new System.Drawing.Size(158, 23);
            this.complimentButton.TabIndex = 1;
            this.complimentButton.Text = "Compliment Your Girlfriend";
            this.complimentButton.UseVisualStyleBackColor = true;
            this.complimentButton.Click += new System.EventHandler(this.complimentButton_Click);
            // 
            // antagonizeButton
            // 
            this.antagonizeButton.Location = new System.Drawing.Point(30, 88);
            this.antagonizeButton.Name = "antagonizeButton";
            this.antagonizeButton.Size = new System.Drawing.Size(158, 23);
            this.antagonizeButton.TabIndex = 2;
            this.antagonizeButton.Text = "Antagonize Your Girlfriend";
            this.antagonizeButton.UseVisualStyleBackColor = true;
            this.antagonizeButton.Click += new System.EventHandler(this.antagonizeButton_Click);
            // 
            // ignoreButton
            // 
            this.ignoreButton.Location = new System.Drawing.Point(30, 117);
            this.ignoreButton.Name = "ignoreButton";
            this.ignoreButton.Size = new System.Drawing.Size(158, 23);
            this.ignoreButton.TabIndex = 3;
            this.ignoreButton.Text = "Ignore Your Girlfriend";
            this.ignoreButton.UseVisualStyleBackColor = true;
            this.ignoreButton.Click += new System.EventHandler(this.ignoreButton_Click);
            // 
            // girlfriendStateLabel
            // 
            this.girlfriendStateLabel.AutoSize = true;
            this.girlfriendStateLabel.Location = new System.Drawing.Point(255, 30);
            this.girlfriendStateLabel.Name = "girlfriendStateLabel";
            this.girlfriendStateLabel.Size = new System.Drawing.Size(35, 13);
            this.girlfriendStateLabel.TabIndex = 4;
            this.girlfriendStateLabel.Text = "label1";
            // 
            // acknowledgementsButton
            // 
            this.acknowledgementsButton.Location = new System.Drawing.Point(312, 176);
            this.acknowledgementsButton.Name = "acknowledgementsButton";
            this.acknowledgementsButton.Size = new System.Drawing.Size(111, 23);
            this.acknowledgementsButton.TabIndex = 5;
            this.acknowledgementsButton.Text = "Acknowledgements";
            this.acknowledgementsButton.UseVisualStyleBackColor = true;
            this.acknowledgementsButton.Click += new System.EventHandler(this.acknowledgementsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 211);
            this.Controls.Add(this.acknowledgementsButton);
            this.Controls.Add(this.girlfriendStateLabel);
            this.Controls.Add(this.ignoreButton);
            this.Controls.Add(this.antagonizeButton);
            this.Controls.Add(this.complimentButton);
            this.Controls.Add(this.feedButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button feedButton;
        private System.Windows.Forms.Button complimentButton;
        private System.Windows.Forms.Button antagonizeButton;
        private System.Windows.Forms.Button ignoreButton;
        private System.Windows.Forms.Label girlfriendStateLabel;
        private System.Windows.Forms.Button acknowledgementsButton;
    }
}


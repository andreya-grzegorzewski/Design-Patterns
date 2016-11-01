namespace EmailProxy
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
            this.fromTB = new System.Windows.Forms.TextBox();
            this.bodyTB = new System.Windows.Forms.TextBox();
            this.subjectTB = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.spamLB = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inboxLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // fromTB
            // 
            this.fromTB.Location = new System.Drawing.Point(25, 43);
            this.fromTB.Name = "fromTB";
            this.fromTB.Size = new System.Drawing.Size(225, 20);
            this.fromTB.TabIndex = 0;
            this.fromTB.Click += new System.EventHandler(this.fromTB_Click);
            // 
            // bodyTB
            // 
            this.bodyTB.Location = new System.Drawing.Point(324, 43);
            this.bodyTB.Multiline = true;
            this.bodyTB.Name = "bodyTB";
            this.bodyTB.Size = new System.Drawing.Size(359, 98);
            this.bodyTB.TabIndex = 1;
            this.bodyTB.Click += new System.EventHandler(this.bodyTB_Click);
            // 
            // subjectTB
            // 
            this.subjectTB.Location = new System.Drawing.Point(25, 94);
            this.subjectTB.Multiline = true;
            this.subjectTB.Name = "subjectTB";
            this.subjectTB.Size = new System.Drawing.Size(225, 47);
            this.subjectTB.TabIndex = 2;
            this.subjectTB.Click += new System.EventHandler(this.subjectTB_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(752, 43);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Body";
            // 
            // spamLB
            // 
            this.spamLB.FormattingEnabled = true;
            this.spamLB.Location = new System.Drawing.Point(25, 478);
            this.spamLB.Name = "spamLB";
            this.spamLB.Size = new System.Drawing.Size(802, 173);
            this.spamLB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inbox";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Spam";
            // 
            // inboxLB
            // 
            this.inboxLB.FormattingEnabled = true;
            this.inboxLB.Location = new System.Drawing.Point(25, 223);
            this.inboxLB.Name = "inboxLB";
            this.inboxLB.Size = new System.Drawing.Size(802, 173);
            this.inboxLB.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 670);
            this.Controls.Add(this.inboxLB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.spamLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.subjectTB);
            this.Controls.Add(this.bodyTB);
            this.Controls.Add(this.fromTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fromTB;
        private System.Windows.Forms.TextBox bodyTB;
        private System.Windows.Forms.TextBox subjectTB;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox spamLB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox inboxLB;
    }
}


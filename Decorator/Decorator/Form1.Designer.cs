namespace Decorator
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
            this.resultLabel = new System.Windows.Forms.Label();
            this.nextTurnButton = new System.Windows.Forms.Button();
            this.monsterHealthLabel = new System.Windows.Forms.Label();
            this.partyHealthLabel = new System.Windows.Forms.Label();
            this.partyDescLabel = new System.Windows.Forms.Label();
            this.healerButton = new System.Windows.Forms.Button();
            this.tankButton = new System.Windows.Forms.Button();
            this.ddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monster";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your party";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(16, 339);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 2;
            // 
            // nextTurnButton
            // 
            this.nextTurnButton.Location = new System.Drawing.Point(13, 288);
            this.nextTurnButton.Name = "nextTurnButton";
            this.nextTurnButton.Size = new System.Drawing.Size(75, 23);
            this.nextTurnButton.TabIndex = 3;
            this.nextTurnButton.Text = "Next Turn";
            this.nextTurnButton.UseVisualStyleBackColor = true;
            this.nextTurnButton.Click += new System.EventHandler(this.nextTurnButton_Click);
            // 
            // monsterHealthLabel
            // 
            this.monsterHealthLabel.AutoSize = true;
            this.monsterHealthLabel.Location = new System.Drawing.Point(13, 44);
            this.monsterHealthLabel.Name = "monsterHealthLabel";
            this.monsterHealthLabel.Size = new System.Drawing.Size(142, 13);
            this.monsterHealthLabel.TabIndex = 4;
            this.monsterHealthLabel.Text = "The monster\'s health is 1000";
            // 
            // partyHealthLabel
            // 
            this.partyHealthLabel.AutoSize = true;
            this.partyHealthLabel.Location = new System.Drawing.Point(299, 44);
            this.partyHealthLabel.Name = "partyHealthLabel";
            this.partyHealthLabel.Size = new System.Drawing.Size(0, 13);
            this.partyHealthLabel.TabIndex = 5;
            // 
            // partyDescLabel
            // 
            this.partyDescLabel.AutoSize = true;
            this.partyDescLabel.Location = new System.Drawing.Point(299, 77);
            this.partyDescLabel.Name = "partyDescLabel";
            this.partyDescLabel.Size = new System.Drawing.Size(99, 13);
            this.partyDescLabel.TabIndex = 6;
            this.partyDescLabel.Text = "Your party is empty.";
            // 
            // healerButton
            // 
            this.healerButton.Location = new System.Drawing.Point(27, 223);
            this.healerButton.Name = "healerButton";
            this.healerButton.Size = new System.Drawing.Size(75, 23);
            this.healerButton.TabIndex = 7;
            this.healerButton.Text = "Add Healer";
            this.healerButton.UseVisualStyleBackColor = true;
            this.healerButton.Click += new System.EventHandler(this.healerButton_Click);
            // 
            // tankButton
            // 
            this.tankButton.Location = new System.Drawing.Point(192, 223);
            this.tankButton.Name = "tankButton";
            this.tankButton.Size = new System.Drawing.Size(75, 23);
            this.tankButton.TabIndex = 8;
            this.tankButton.Text = "Add Tank";
            this.tankButton.UseVisualStyleBackColor = true;
            this.tankButton.Click += new System.EventHandler(this.tankButton_Click);
            // 
            // ddButton
            // 
            this.ddButton.Location = new System.Drawing.Point(362, 223);
            this.ddButton.Name = "ddButton";
            this.ddButton.Size = new System.Drawing.Size(119, 23);
            this.ddButton.TabIndex = 9;
            this.ddButton.Text = "Add Damage Dealer";
            this.ddButton.UseVisualStyleBackColor = true;
            this.ddButton.Click += new System.EventHandler(this.ddButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 396);
            this.Controls.Add(this.ddButton);
            this.Controls.Add(this.tankButton);
            this.Controls.Add(this.healerButton);
            this.Controls.Add(this.partyDescLabel);
            this.Controls.Add(this.partyHealthLabel);
            this.Controls.Add(this.monsterHealthLabel);
            this.Controls.Add(this.nextTurnButton);
            this.Controls.Add(this.resultLabel);
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
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button nextTurnButton;
        private System.Windows.Forms.Label monsterHealthLabel;
        private System.Windows.Forms.Label partyHealthLabel;
        private System.Windows.Forms.Label partyDescLabel;
        private System.Windows.Forms.Button healerButton;
        private System.Windows.Forms.Button tankButton;
        private System.Windows.Forms.Button ddButton;
    }
}


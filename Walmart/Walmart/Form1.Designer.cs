namespace Walmart
{
    partial class WalmartForm
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
            this.productsLB = new System.Windows.Forms.ListBox();
            this.costsLB = new System.Windows.Forms.ListBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.restockButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productsLB
            // 
            this.productsLB.FormattingEnabled = true;
            this.productsLB.ItemHeight = 16;
            this.productsLB.Location = new System.Drawing.Point(125, 23);
            this.productsLB.Name = "productsLB";
            this.productsLB.Size = new System.Drawing.Size(577, 564);
            this.productsLB.TabIndex = 0;
            // 
            // costsLB
            // 
            this.costsLB.FormattingEnabled = true;
            this.costsLB.ItemHeight = 16;
            this.costsLB.Location = new System.Drawing.Point(26, 23);
            this.costsLB.Name = "costsLB";
            this.costsLB.Size = new System.Drawing.Size(93, 564);
            this.costsLB.TabIndex = 1;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(759, 23);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 68);
            this.buyButton.TabIndex = 2;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // restockButton
            // 
            this.restockButton.Location = new System.Drawing.Point(759, 511);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(75, 75);
            this.restockButton.TabIndex = 3;
            this.restockButton.Text = "Restock";
            this.restockButton.UseVisualStyleBackColor = true;
            this.restockButton.Click += new System.EventHandler(this.restockButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(718, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Money in the bank: $";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(856, 290);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(29, 16);
            this.moneyLabel.TabIndex = 5;
            this.moneyLabel.Text = "250";
            // 
            // WalmartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 616);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restockButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.costsLB);
            this.Controls.Add(this.productsLB);
            this.Name = "WalmartForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productsLB;
        private System.Windows.Forms.ListBox costsLB;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label moneyLabel;
    }
}



namespace TipCalculator
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
            this.enterBillLabel = new System.Windows.Forms.Label();
            this.ComputeTipButton = new System.Windows.Forms.Button();
            this.TotalBillTextBox = new System.Windows.Forms.TextBox();
            this.TipAmountTextBox = new System.Windows.Forms.TextBox();
            this.TipPercentLabel = new System.Windows.Forms.Label();
            this.TipPercentBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterBillLabel
            // 
            this.enterBillLabel.AutoSize = true;
            this.enterBillLabel.Location = new System.Drawing.Point(90, 51);
            this.enterBillLabel.Name = "enterBillLabel";
            this.enterBillLabel.Size = new System.Drawing.Size(115, 20);
            this.enterBillLabel.TabIndex = 0;
            this.enterBillLabel.Text = "Enter Total Bill:";
            this.enterBillLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ComputeTipButton
            // 
            this.ComputeTipButton.Location = new System.Drawing.Point(81, 254);
            this.ComputeTipButton.Name = "ComputeTipButton";
            this.ComputeTipButton.Size = new System.Drawing.Size(142, 35);
            this.ComputeTipButton.TabIndex = 1;
            this.ComputeTipButton.Text = "ComputeTip";
            this.ComputeTipButton.UseVisualStyleBackColor = true;
            this.ComputeTipButton.Click += new System.EventHandler(this.ComputeTipButton_Click);
            // 
            // TotalBillTextBox
            // 
            this.TotalBillTextBox.Location = new System.Drawing.Point(252, 51);
            this.TotalBillTextBox.Name = "TotalBillTextBox";
            this.TotalBillTextBox.Size = new System.Drawing.Size(100, 26);
            this.TotalBillTextBox.TabIndex = 2;
            this.TotalBillTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TipAmountTextBox
            // 
            this.TipAmountTextBox.Location = new System.Drawing.Point(252, 263);
            this.TipAmountTextBox.Name = "TipAmountTextBox";
            this.TipAmountTextBox.Size = new System.Drawing.Size(100, 26);
            this.TipAmountTextBox.TabIndex = 3;
            // 
            // TipPercentLabel
            // 
            this.TipPercentLabel.AutoSize = true;
            this.TipPercentLabel.Location = new System.Drawing.Point(90, 153);
            this.TipPercentLabel.Name = "TipPercentLabel";
            this.TipPercentLabel.Size = new System.Drawing.Size(116, 20);
            this.TipPercentLabel.TabIndex = 4;
            this.TipPercentLabel.Text = "Tip Percentage";
            // 
            // TipPercentBox
            // 
            this.TipPercentBox.Location = new System.Drawing.Point(252, 153);
            this.TipPercentBox.Name = "TipPercentBox";
            this.TipPercentBox.Size = new System.Drawing.Size(100, 26);
            this.TipPercentBox.TabIndex = 5;
            this.TipPercentBox.TextChanged += new System.EventHandler(this.TipPercentBox_TextChanged);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(638, 366);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(100, 26);
            this.TotalTextBox.TabIndex = 6;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(493, 366);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(44, 20);
            this.TotalLabel.TabIndex = 7;
            this.TotalLabel.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.TipPercentBox);
            this.Controls.Add(this.TipPercentLabel);
            this.Controls.Add(this.TipAmountTextBox);
            this.Controls.Add(this.TotalBillTextBox);
            this.Controls.Add(this.ComputeTipButton);
            this.Controls.Add(this.enterBillLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterBillLabel;
        private System.Windows.Forms.Button ComputeTipButton;
        private System.Windows.Forms.TextBox TotalBillTextBox;
        private System.Windows.Forms.TextBox TipAmountTextBox;
        private System.Windows.Forms.Label TipPercentLabel;
        private System.Windows.Forms.TextBox TipPercentBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label TotalLabel;
    }
}


namespace ShapeshifterStudioPaymentCalculator
{
    partial class CalculatePay
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
            this.BkFromCalcPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BkFromCalcPay
            // 
            this.BkFromCalcPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BkFromCalcPay.Location = new System.Drawing.Point(31, 308);
            this.BkFromCalcPay.Name = "BkFromCalcPay";
            this.BkFromCalcPay.Size = new System.Drawing.Size(58, 21);
            this.BkFromCalcPay.TabIndex = 0;
            this.BkFromCalcPay.Text = "Back";
            this.BkFromCalcPay.UseVisualStyleBackColor = true;
            this.BkFromCalcPay.Click += new System.EventHandler(this.BkFromCalcPay_Click);
            // 
            // CalculatePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BkFromCalcPay);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CalculatePay";
            this.Text = "Shapeshifter Calculator - CalculatePay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BkFromCalcPay;
    }
}
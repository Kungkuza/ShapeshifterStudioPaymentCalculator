namespace ShapeshifterStudioPaymentCalculator
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.BkFromOverallBreakdown = new System.Windows.Forms.Button();
            this.AvailUSDTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BreakdownPaymentmonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.OwedAmountALLInstructorsRTB = new System.Windows.Forms.RichTextBox();
            this.SubmitUSDBtn = new System.Windows.Forms.Button();
            this.confirmation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BkFromOverallBreakdown
            // 
            this.BkFromOverallBreakdown.Location = new System.Drawing.Point(25, 589);
            this.BkFromOverallBreakdown.Name = "BkFromOverallBreakdown";
            this.BkFromOverallBreakdown.Size = new System.Drawing.Size(56, 21);
            this.BkFromOverallBreakdown.TabIndex = 0;
            this.BkFromOverallBreakdown.Text = "Back";
            this.BkFromOverallBreakdown.UseVisualStyleBackColor = true;
            this.BkFromOverallBreakdown.Click += new System.EventHandler(this.BkFromOverallBreakdown_Click);
            // 
            // AvailUSDTxtBox
            // 
            this.AvailUSDTxtBox.Location = new System.Drawing.Point(107, 66);
            this.AvailUSDTxtBox.MaxLength = 32;
            this.AvailUSDTxtBox.Name = "AvailUSDTxtBox";
            this.AvailUSDTxtBox.Size = new System.Drawing.Size(100, 20);
            this.AvailUSDTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the amount of USD being paid out.";
            // 
            // BreakdownPaymentmonthCalendar
            // 
            this.BreakdownPaymentmonthCalendar.Location = new System.Drawing.Point(304, 66);
            this.BreakdownPaymentmonthCalendar.Name = "BreakdownPaymentmonthCalendar";
            this.BreakdownPaymentmonthCalendar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter the 1st of the payout month.";
            // 
            // OwedAmountALLInstructorsRTB
            // 
            this.OwedAmountALLInstructorsRTB.Location = new System.Drawing.Point(25, 262);
            this.OwedAmountALLInstructorsRTB.Name = "OwedAmountALLInstructorsRTB";
            this.OwedAmountALLInstructorsRTB.Size = new System.Drawing.Size(544, 321);
            this.OwedAmountALLInstructorsRTB.TabIndex = 7;
            this.OwedAmountALLInstructorsRTB.Text = "";
            // 
            // SubmitUSDBtn
            // 
            this.SubmitUSDBtn.Location = new System.Drawing.Point(106, 109);
            this.SubmitUSDBtn.Name = "SubmitUSDBtn";
            this.SubmitUSDBtn.Size = new System.Drawing.Size(100, 25);
            this.SubmitUSDBtn.TabIndex = 8;
            this.SubmitUSDBtn.Text = "Submit";
            this.SubmitUSDBtn.UseVisualStyleBackColor = true;
            this.SubmitUSDBtn.Click += new System.EventHandler(this.SubmitUSDBtn_Click);
            // 
            // confirmation
            // 
            this.confirmation.AutoSize = true;
            this.confirmation.Location = new System.Drawing.Point(109, 141);
            this.confirmation.Name = "confirmation";
            this.confirmation.Size = new System.Drawing.Size(0, 13);
            this.confirmation.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(600, 622);
            this.Controls.Add(this.confirmation);
            this.Controls.Add(this.SubmitUSDBtn);
            this.Controls.Add(this.OwedAmountALLInstructorsRTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BreakdownPaymentmonthCalendar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AvailUSDTxtBox);
            this.Controls.Add(this.BkFromOverallBreakdown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shapershifter Calculator - Overall Breakdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BkFromOverallBreakdown;
        private System.Windows.Forms.TextBox AvailUSDTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar BreakdownPaymentmonthCalendar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox OwedAmountALLInstructorsRTB;
        private System.Windows.Forms.Button SubmitUSDBtn;
        private System.Windows.Forms.Label confirmation;
    }
}
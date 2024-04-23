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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CalcPaymonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.PaymentForTheMonthTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PercentofPointsTxtBox = new System.Windows.Forms.TextBox();
            this.SubmitCalcPayBtn = new System.Windows.Forms.Button();
            this.CPayInstcomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.USDAvailtxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BkFromCalcPay
            // 
            this.BkFromCalcPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BkFromCalcPay.Location = new System.Drawing.Point(20, 373);
            this.BkFromCalcPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BkFromCalcPay.Name = "BkFromCalcPay";
            this.BkFromCalcPay.Size = new System.Drawing.Size(77, 26);
            this.BkFromCalcPay.TabIndex = 0;
            this.BkFromCalcPay.Text = "Back";
            this.BkFromCalcPay.UseVisualStyleBackColor = true;
            this.BkFromCalcPay.Click += new System.EventHandler(this.BkFromCalcPay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the 1st of the month you are applying payment for";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Here is the payment needed this month for the selected instructor.";
            // 
            // CalcPaymonthCalendar
            // 
            this.CalcPaymonthCalendar.Location = new System.Drawing.Point(24, 90);
            this.CalcPaymonthCalendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.CalcPaymonthCalendar.Name = "CalcPaymonthCalendar";
            this.CalcPaymonthCalendar.TabIndex = 3;
            // 
            // PaymentForTheMonthTxtBox
            // 
            this.PaymentForTheMonthTxtBox.Location = new System.Drawing.Point(375, 190);
            this.PaymentForTheMonthTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PaymentForTheMonthTxtBox.MaxLength = 16;
            this.PaymentForTheMonthTxtBox.Name = "PaymentForTheMonthTxtBox";
            this.PaymentForTheMonthTxtBox.ReadOnly = true;
            this.PaymentForTheMonthTxtBox.Size = new System.Drawing.Size(132, 22);
            this.PaymentForTheMonthTxtBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Here is the current % of all points they hold.";
            // 
            // PercentofPointsTxtBox
            // 
            this.PercentofPointsTxtBox.Location = new System.Drawing.Point(375, 249);
            this.PercentofPointsTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PercentofPointsTxtBox.MaxLength = 16;
            this.PercentofPointsTxtBox.Name = "PercentofPointsTxtBox";
            this.PercentofPointsTxtBox.ReadOnly = true;
            this.PercentofPointsTxtBox.Size = new System.Drawing.Size(132, 22);
            this.PercentofPointsTxtBox.TabIndex = 6;
            // 
            // SubmitCalcPayBtn
            // 
            this.SubmitCalcPayBtn.Location = new System.Drawing.Point(375, 334);
            this.SubmitCalcPayBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitCalcPayBtn.Name = "SubmitCalcPayBtn";
            this.SubmitCalcPayBtn.Size = new System.Drawing.Size(129, 36);
            this.SubmitCalcPayBtn.TabIndex = 7;
            this.SubmitCalcPayBtn.Text = "Submit";
            this.SubmitCalcPayBtn.UseVisualStyleBackColor = true;
            this.SubmitCalcPayBtn.Click += new System.EventHandler(this.SubmitCalcPayBtn_Click);
            // 
            // CPayInstcomboBox
            // 
            this.CPayInstcomboBox.FormattingEnabled = true;
            this.CPayInstcomboBox.Location = new System.Drawing.Point(375, 126);
            this.CPayInstcomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CPayInstcomboBox.Name = "CPayInstcomboBox";
            this.CPayInstcomboBox.Size = new System.Drawing.Size(160, 24);
            this.CPayInstcomboBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select Instructor";
            // 
            // USDAvailtxtBox
            // 
            this.USDAvailtxtBox.Location = new System.Drawing.Point(577, 126);
            this.USDAvailtxtBox.Name = "USDAvailtxtBox";
            this.USDAvailtxtBox.Size = new System.Drawing.Size(165, 22);
            this.USDAvailtxtBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(578, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Amount of USD available:";
            // 
            // CalculatePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.USDAvailtxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CPayInstcomboBox);
            this.Controls.Add(this.SubmitCalcPayBtn);
            this.Controls.Add(this.PercentofPointsTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PaymentForTheMonthTxtBox);
            this.Controls.Add(this.CalcPaymonthCalendar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BkFromCalcPay);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CalculatePay";
            this.Text = "Shapeshifter Calculator - CalculatePay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BkFromCalcPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar CalcPaymonthCalendar;
        private System.Windows.Forms.TextBox PaymentForTheMonthTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PercentofPointsTxtBox;
        private System.Windows.Forms.Button SubmitCalcPayBtn;
        private System.Windows.Forms.ComboBox CPayInstcomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox USDAvailtxtBox;
        private System.Windows.Forms.Label label5;
    }
}
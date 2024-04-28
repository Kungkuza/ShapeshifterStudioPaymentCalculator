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
            this.SubmitCalcPayBtn = new System.Windows.Forms.Button();
            this.CPayInstcomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.USDAvailtxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CalcPayRTB = new System.Windows.Forms.RichTextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // BkFromCalcPay
            // 
            this.BkFromCalcPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BkFromCalcPay.Location = new System.Drawing.Point(15, 303);
            this.BkFromCalcPay.Name = "BkFromCalcPay";
            this.BkFromCalcPay.Size = new System.Drawing.Size(58, 21);
            this.BkFromCalcPay.TabIndex = 0;
            this.BkFromCalcPay.Text = "Back";
            this.BkFromCalcPay.UseVisualStyleBackColor = true;
            this.BkFromCalcPay.Click += new System.EventHandler(this.BkFromCalcPay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the 1st of the month you are applying payment for";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Here is the payment needed this month for the selected instructor.";
            // 
            // CalcPaymonthCalendar
            // 
            this.CalcPaymonthCalendar.Location = new System.Drawing.Point(18, 73);
            this.CalcPaymonthCalendar.Name = "CalcPaymonthCalendar";
            this.CalcPaymonthCalendar.TabIndex = 3;
            // 
            // SubmitCalcPayBtn
            // 
            this.SubmitCalcPayBtn.Location = new System.Drawing.Point(148, 247);
            this.SubmitCalcPayBtn.Name = "SubmitCalcPayBtn";
            this.SubmitCalcPayBtn.Size = new System.Drawing.Size(97, 29);
            this.SubmitCalcPayBtn.TabIndex = 7;
            this.SubmitCalcPayBtn.Text = "Submit";
            this.SubmitCalcPayBtn.UseVisualStyleBackColor = true;
            this.SubmitCalcPayBtn.Click += new System.EventHandler(this.SubmitCalcPayBtn_Click);
            // 
            // CPayInstcomboBox
            // 
            this.CPayInstcomboBox.FormattingEnabled = true;
            this.CPayInstcomboBox.Location = new System.Drawing.Point(281, 102);
            this.CPayInstcomboBox.Name = "CPayInstcomboBox";
            this.CPayInstcomboBox.Size = new System.Drawing.Size(121, 21);
            this.CPayInstcomboBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select Instructor";
            // 
            // USDAvailtxtBox
            // 
            this.USDAvailtxtBox.Location = new System.Drawing.Point(433, 102);
            this.USDAvailtxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.USDAvailtxtBox.Name = "USDAvailtxtBox";
            this.USDAvailtxtBox.Size = new System.Drawing.Size(125, 20);
            this.USDAvailtxtBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Amount of USD available:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "There is also a percentage of total points the instructor has contributed.";
            // 
            // CalcPayRTB
            // 
            this.CalcPayRTB.Location = new System.Drawing.Point(263, 180);
            this.CalcPayRTB.Name = "CalcPayRTB";
            this.CalcPayRTB.Size = new System.Drawing.Size(310, 144);
            this.CalcPayRTB.TabIndex = 13;
            this.CalcPayRTB.Text = "";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(555, 180);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 144);
            this.vScrollBar1.TabIndex = 14;
            // 
            // CalculatePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(600, 345);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.CalcPayRTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.USDAvailtxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CPayInstcomboBox);
            this.Controls.Add(this.SubmitCalcPayBtn);
            this.Controls.Add(this.CalcPaymonthCalendar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BkFromCalcPay);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button SubmitCalcPayBtn;
        private System.Windows.Forms.ComboBox CPayInstcomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox USDAvailtxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox CalcPayRTB;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}
namespace ShapeshifterStudioPaymentCalculator.stripe
{
    partial class PaymentStatusForm
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
            this.paymentProgressBar = new System.Windows.Forms.ProgressBar();
            this.paymentProgressText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paymentProgressBar
            // 
            this.paymentProgressBar.Location = new System.Drawing.Point(12, 12);
            this.paymentProgressBar.Name = "paymentProgressBar";
            this.paymentProgressBar.Size = new System.Drawing.Size(761, 26);
            this.paymentProgressBar.TabIndex = 0;
            this.paymentProgressBar.UseWaitCursor = true;
            // 
            // paymentProgressText
            // 
            this.paymentProgressText.AutoSize = true;
            this.paymentProgressText.Location = new System.Drawing.Point(12, 41);
            this.paymentProgressText.Name = "paymentProgressText";
            this.paymentProgressText.Size = new System.Drawing.Size(175, 13);
            this.paymentProgressText.TabIndex = 1;
            this.paymentProgressText.Text = "Processing Payment. Please wait...,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(151, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please DO NOT close the program while this is processing.";
            // 
            // PaymentStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 88);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paymentProgressText);
            this.Controls.Add(this.paymentProgressBar);
            this.Name = "PaymentStatusForm";
            this.ShowIcon = false;
            this.Text = "Payment in progress...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar paymentProgressBar;
        private System.Windows.Forms.Label paymentProgressText;
        private System.Windows.Forms.Label label2;
    }
}
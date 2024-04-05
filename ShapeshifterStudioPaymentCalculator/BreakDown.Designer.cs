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
            this.BkFromOverallBreakdown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BkFromOverallBreakdown
            // 
            this.BkFromOverallBreakdown.Location = new System.Drawing.Point(37, 303);
            this.BkFromOverallBreakdown.Name = "BkFromOverallBreakdown";
            this.BkFromOverallBreakdown.Size = new System.Drawing.Size(56, 21);
            this.BkFromOverallBreakdown.TabIndex = 0;
            this.BkFromOverallBreakdown.Text = "Back";
            this.BkFromOverallBreakdown.UseVisualStyleBackColor = true;
            this.BkFromOverallBreakdown.Click += new System.EventHandler(this.BkFromOverallBreakdown_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BkFromOverallBreakdown);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Shapershifter Calculator - Overall Breakdown";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BkFromOverallBreakdown;
    }
}
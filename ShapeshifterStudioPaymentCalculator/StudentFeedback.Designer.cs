namespace ShapeshifterStudioPaymentCalculator
{
    partial class Feedback
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
            this.BkFromStdntFdbk = new System.Windows.Forms.Button();
            this.SubmitFeedBk = new System.Windows.Forms.Button();
            this.StudentFeedBkRTxtBox = new System.Windows.Forms.RichTextBox();
            this.StudentNameTxtBox = new System.Windows.Forms.TextBox();
            this.StudentPointModifier = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BkFromStdntFdbk
            // 
            this.BkFromStdntFdbk.Location = new System.Drawing.Point(49, 389);
            this.BkFromStdntFdbk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BkFromStdntFdbk.Name = "BkFromStdntFdbk";
            this.BkFromStdntFdbk.Size = new System.Drawing.Size(75, 23);
            this.BkFromStdntFdbk.TabIndex = 0;
            this.BkFromStdntFdbk.Text = "Back";
            this.BkFromStdntFdbk.UseVisualStyleBackColor = true;
            this.BkFromStdntFdbk.Click += new System.EventHandler(this.BkFromStdntFdbk_Click);
            // 
            // SubmitFeedBk
            // 
            this.SubmitFeedBk.Location = new System.Drawing.Point(340, 353);
            this.SubmitFeedBk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubmitFeedBk.Name = "SubmitFeedBk";
            this.SubmitFeedBk.Size = new System.Drawing.Size(75, 23);
            this.SubmitFeedBk.TabIndex = 1;
            this.SubmitFeedBk.Text = "Submit";
            this.SubmitFeedBk.UseVisualStyleBackColor = true;
            this.SubmitFeedBk.Click += new System.EventHandler(this.SubmitFeedBk_Click);
            // 
            // StudentFeedBkRTxtBox
            // 
            this.StudentFeedBkRTxtBox.Location = new System.Drawing.Point(340, 155);
            this.StudentFeedBkRTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentFeedBkRTxtBox.Name = "StudentFeedBkRTxtBox";
            this.StudentFeedBkRTxtBox.Size = new System.Drawing.Size(223, 96);
            this.StudentFeedBkRTxtBox.TabIndex = 3;
            this.StudentFeedBkRTxtBox.Text = "";
            // 
            // StudentNameTxtBox
            // 
            this.StudentNameTxtBox.Location = new System.Drawing.Point(340, 98);
            this.StudentNameTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentNameTxtBox.Name = "StudentNameTxtBox";
            this.StudentNameTxtBox.Size = new System.Drawing.Size(223, 22);
            this.StudentNameTxtBox.TabIndex = 4;
            // 
            // StudentPointModifier
            // 
            this.StudentPointModifier.Location = new System.Drawing.Point(340, 298);
            this.StudentPointModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentPointModifier.Name = "StudentPointModifier";
            this.StudentPointModifier.Size = new System.Drawing.Size(100, 22);
            this.StudentPointModifier.TabIndex = 5;
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StudentPointModifier);
            this.Controls.Add(this.StudentNameTxtBox);
            this.Controls.Add(this.StudentFeedBkRTxtBox);
            this.Controls.Add(this.SubmitFeedBk);
            this.Controls.Add(this.BkFromStdntFdbk);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Feedback";
            this.Text = "Shapeshifter Calculator - Student Feedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BkFromStdntFdbk;
        private System.Windows.Forms.Button SubmitFeedBk;
        private System.Windows.Forms.RichTextBox StudentFeedBkRTxtBox;
        private System.Windows.Forms.TextBox StudentNameTxtBox;
        private System.Windows.Forms.TextBox StudentPointModifier;
    }
}
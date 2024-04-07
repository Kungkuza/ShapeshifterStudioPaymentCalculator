namespace ShapeshifterStudioPaymentCalculator
{
    partial class AddPoints
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
            this.AddPtsCal = new System.Windows.Forms.MonthCalendar();
            this.TypeofActionCombo = new System.Windows.Forms.ComboBox();
            this.PtsAmountTxtbox = new System.Windows.Forms.TextBox();
            this.BkFromAddPts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WhichInstCombo = new System.Windows.Forms.ComboBox();
            this.AddPtsSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPtsCal
            // 
            this.AddPtsCal.Location = new System.Drawing.Point(49, 96);
            this.AddPtsCal.Name = "AddPtsCal";
            this.AddPtsCal.TabIndex = 0;
            // 
            // TypeofActionCombo
            // 
            this.TypeofActionCombo.FormattingEnabled = true;
            this.TypeofActionCombo.Location = new System.Drawing.Point(633, 187);
            this.TypeofActionCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TypeofActionCombo.Name = "TypeofActionCombo";
            this.TypeofActionCombo.Size = new System.Drawing.Size(121, 24);
            this.TypeofActionCombo.TabIndex = 2;
            // 
            // PtsAmountTxtbox
            // 
            this.PtsAmountTxtbox.Location = new System.Drawing.Point(633, 272);
            this.PtsAmountTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PtsAmountTxtbox.Name = "PtsAmountTxtbox";
            this.PtsAmountTxtbox.Size = new System.Drawing.Size(121, 22);
            this.PtsAmountTxtbox.TabIndex = 3;
            // 
            // BkFromAddPts
            // 
            this.BkFromAddPts.Location = new System.Drawing.Point(49, 369);
            this.BkFromAddPts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BkFromAddPts.Name = "BkFromAddPts";
            this.BkFromAddPts.Size = new System.Drawing.Size(75, 23);
            this.BkFromAddPts.TabIndex = 4;
            this.BkFromAddPts.Text = "Back";
            this.BkFromAddPts.UseVisualStyleBackColor = true;
            this.BkFromAddPts.Click += new System.EventHandler(this.BkFromAddPts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(49, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "When did the event occur?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(403, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Which Instructor will these points be added under?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(403, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Which action was perfomed?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(403, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "How many points do you think it was worth?";
            // 
            // WhichInstCombo
            // 
            this.WhichInstCombo.FormattingEnabled = true;
            this.WhichInstCombo.Location = new System.Drawing.Point(633, 96);
            this.WhichInstCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WhichInstCombo.Name = "WhichInstCombo";
            this.WhichInstCombo.Size = new System.Drawing.Size(121, 24);
            this.WhichInstCombo.TabIndex = 9;
            // 
            // AddPtsSubmit
            // 
            this.AddPtsSubmit.Location = new System.Drawing.Point(551, 354);
            this.AddPtsSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddPtsSubmit.Name = "AddPtsSubmit";
            this.AddPtsSubmit.Size = new System.Drawing.Size(76, 38);
            this.AddPtsSubmit.TabIndex = 10;
            this.AddPtsSubmit.Text = "Submit";
            this.AddPtsSubmit.UseVisualStyleBackColor = true;
            this.AddPtsSubmit.Click += new System.EventHandler(this.AddPtsSubmit_Click);
            // 
            // AddPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddPtsSubmit);
            this.Controls.Add(this.WhichInstCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BkFromAddPts);
            this.Controls.Add(this.PtsAmountTxtbox);
            this.Controls.Add(this.TypeofActionCombo);
            this.Controls.Add(this.AddPtsCal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddPoints";
            this.Text = "Shapershifter Calculator - Add Points";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar AddPtsCal;
        private System.Windows.Forms.ComboBox TypeofActionCombo;
        private System.Windows.Forms.TextBox PtsAmountTxtbox;
        private System.Windows.Forms.Button BkFromAddPts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox WhichInstCombo;
        private System.Windows.Forms.Button AddPtsSubmit;
    }
}
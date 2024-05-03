namespace ShapeshifterStudioPaymentCalculator
{
    partial class PointLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointLogs));
            this.FileReadoutrichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.BkFromViewPtLogs = new System.Windows.Forms.Button();
            this.download = new System.Windows.Forms.Button();
            this.TransferBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileReadoutrichTextBox
            // 
            this.FileReadoutrichTextBox.Location = new System.Drawing.Point(268, 24);
            this.FileReadoutrichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FileReadoutrichTextBox.Name = "FileReadoutrichTextBox";
            this.FileReadoutrichTextBox.ReadOnly = true;
            this.FileReadoutrichTextBox.Size = new System.Drawing.Size(311, 319);
            this.FileReadoutrichTextBox.TabIndex = 0;
            this.FileReadoutrichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Here are the points, as put in the file. ";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(562, 24);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 318);
            this.vScrollBar1.TabIndex = 2;
            // 
            // BkFromViewPtLogs
            // 
            this.BkFromViewPtLogs.Location = new System.Drawing.Point(27, 322);
            this.BkFromViewPtLogs.Name = "BkFromViewPtLogs";
            this.BkFromViewPtLogs.Size = new System.Drawing.Size(49, 20);
            this.BkFromViewPtLogs.TabIndex = 3;
            this.BkFromViewPtLogs.Text = "Back";
            this.BkFromViewPtLogs.UseVisualStyleBackColor = true;
            this.BkFromViewPtLogs.Click += new System.EventHandler(this.BkFromViewPtLogs_Click);
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(188, 319);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(75, 23);
            this.download.TabIndex = 4;
            this.download.Text = "Download Points File";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.Download_click);
            // 
            // TransferBtn
            // 
            this.TransferBtn.Location = new System.Drawing.Point(188, 275);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(75, 38);
            this.TransferBtn.TabIndex = 5;
            this.TransferBtn.Text = "Transfer Backup";
            this.TransferBtn.UseVisualStyleBackColor = true;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // PointLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.TransferBtn);
            this.Controls.Add(this.download);
            this.Controls.Add(this.BkFromViewPtLogs);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileReadoutrichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PointLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shapershifter Calculator - View Point System Logs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox FileReadoutrichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button BkFromViewPtLogs;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button TransferBtn;
    }
}
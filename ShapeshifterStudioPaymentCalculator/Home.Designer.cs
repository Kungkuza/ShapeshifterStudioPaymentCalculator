namespace ShapeshifterStudioPaymentCalculator
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.AddPtsBtn = new System.Windows.Forms.Button();
            this.ViewLogsBtn = new System.Windows.Forms.Button();
            this.AddInstBtn = new System.Windows.Forms.Button();
            this.StdntFdbkBtn = new System.Windows.Forms.Button();
            this.CalcPayBtn = new System.Windows.Forms.Button();
            this.OverallPtsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(243, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome! What are we doing today?";
            // 
            // AddPtsBtn
            // 
            this.AddPtsBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddPtsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.AddPtsBtn.Location = new System.Drawing.Point(76, 178);
            this.AddPtsBtn.Name = "AddPtsBtn";
            this.AddPtsBtn.Size = new System.Drawing.Size(107, 32);
            this.AddPtsBtn.TabIndex = 1;
            this.AddPtsBtn.Text = "Add Points";
            this.AddPtsBtn.UseVisualStyleBackColor = false;
            // 
            // ViewLogsBtn
            // 
            this.ViewLogsBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ViewLogsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ViewLogsBtn.Location = new System.Drawing.Point(565, 286);
            this.ViewLogsBtn.Name = "ViewLogsBtn";
            this.ViewLogsBtn.Size = new System.Drawing.Size(78, 48);
            this.ViewLogsBtn.TabIndex = 2;
            this.ViewLogsBtn.Text = "View Logs";
            this.ViewLogsBtn.UseVisualStyleBackColor = false;
            // 
            // AddInstBtn
            // 
            this.AddInstBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddInstBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.AddInstBtn.Location = new System.Drawing.Point(565, 178);
            this.AddInstBtn.Name = "AddInstBtn";
            this.AddInstBtn.Size = new System.Drawing.Size(78, 47);
            this.AddInstBtn.TabIndex = 3;
            this.AddInstBtn.Text = "Add Instructor";
            this.AddInstBtn.UseVisualStyleBackColor = false;
            // 
            // StdntFdbkBtn
            // 
            this.StdntFdbkBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StdntFdbkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.StdntFdbkBtn.Location = new System.Drawing.Point(346, 286);
            this.StdntFdbkBtn.Name = "StdntFdbkBtn";
            this.StdntFdbkBtn.Size = new System.Drawing.Size(93, 48);
            this.StdntFdbkBtn.TabIndex = 4;
            this.StdntFdbkBtn.Text = "Student Feedback";
            this.StdntFdbkBtn.UseVisualStyleBackColor = false;
            // 
            // CalcPayBtn
            // 
            this.CalcPayBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CalcPayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CalcPayBtn.Location = new System.Drawing.Point(361, 178);
            this.CalcPayBtn.Name = "CalcPayBtn";
            this.CalcPayBtn.Size = new System.Drawing.Size(78, 47);
            this.CalcPayBtn.TabIndex = 5;
            this.CalcPayBtn.Text = "Calculate Pay";
            this.CalcPayBtn.UseVisualStyleBackColor = false;
            // 
            // OverallPtsBtn
            // 
            this.OverallPtsBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.OverallPtsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.OverallPtsBtn.Location = new System.Drawing.Point(76, 286);
            this.OverallPtsBtn.Name = "OverallPtsBtn";
            this.OverallPtsBtn.Size = new System.Drawing.Size(107, 48);
            this.OverallPtsBtn.TabIndex = 6;
            this.OverallPtsBtn.Text = "Overall Points";
            this.OverallPtsBtn.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OverallPtsBtn);
            this.Controls.Add(this.CalcPayBtn);
            this.Controls.Add(this.StdntFdbkBtn);
            this.Controls.Add(this.AddInstBtn);
            this.Controls.Add(this.ViewLogsBtn);
            this.Controls.Add(this.AddPtsBtn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Shapershifter Calculator - Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddPtsBtn;
        private System.Windows.Forms.Button ViewLogsBtn;
        private System.Windows.Forms.Button AddInstBtn;
        private System.Windows.Forms.Button StdntFdbkBtn;
        private System.Windows.Forms.Button CalcPayBtn;
        private System.Windows.Forms.Button OverallPtsBtn;
    }
}


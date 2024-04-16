namespace ShapeshifterStudioPaymentCalculator
{
    partial class AddInstructor
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
            this.BkFromAddInst = new System.Windows.Forms.Button();
            this.NewInstNameTxtbox = new System.Windows.Forms.TextBox();
            this.InstructDCIDTxtbox = new System.Windows.Forms.TextBox();
            this.RmInstrDCIDTxtbox = new System.Windows.Forms.TextBox();
            this.AddInstrSubmit = new System.Windows.Forms.Button();
            this.RmInstrSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BkFromAddInst
            // 
            this.BkFromAddInst.Location = new System.Drawing.Point(35, 317);
            this.BkFromAddInst.Margin = new System.Windows.Forms.Padding(2);
            this.BkFromAddInst.Name = "BkFromAddInst";
            this.BkFromAddInst.Size = new System.Drawing.Size(43, 24);
            this.BkFromAddInst.TabIndex = 8;
            this.BkFromAddInst.Text = "Back";
            this.BkFromAddInst.UseVisualStyleBackColor = true;
            this.BkFromAddInst.Click += new System.EventHandler(this.BkFromAddInst_Click);
            // 
            // NewInstNameTxtbox
            // 
            this.NewInstNameTxtbox.Location = new System.Drawing.Point(89, 103);
            this.NewInstNameTxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.NewInstNameTxtbox.Name = "NewInstNameTxtbox";
            this.NewInstNameTxtbox.Size = new System.Drawing.Size(115, 20);
            this.NewInstNameTxtbox.TabIndex = 9;
            // 
            // InstructDCIDTxtbox
            // 
            this.InstructDCIDTxtbox.Location = new System.Drawing.Point(89, 188);
            this.InstructDCIDTxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.InstructDCIDTxtbox.Name = "InstructDCIDTxtbox";
            this.InstructDCIDTxtbox.Size = new System.Drawing.Size(116, 20);
            this.InstructDCIDTxtbox.TabIndex = 10;
            // 
            // RmInstrDCIDTxtbox
            // 
            this.RmInstrDCIDTxtbox.Location = new System.Drawing.Point(376, 103);
            this.RmInstrDCIDTxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.RmInstrDCIDTxtbox.Name = "RmInstrDCIDTxtbox";
            this.RmInstrDCIDTxtbox.Size = new System.Drawing.Size(122, 20);
            this.RmInstrDCIDTxtbox.TabIndex = 11;
            // 
            // AddInstrSubmit
            // 
            this.AddInstrSubmit.Location = new System.Drawing.Point(89, 254);
            this.AddInstrSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.AddInstrSubmit.Name = "AddInstrSubmit";
            this.AddInstrSubmit.Size = new System.Drawing.Size(86, 24);
            this.AddInstrSubmit.TabIndex = 12;
            this.AddInstrSubmit.Text = "Add Instructor";
            this.AddInstrSubmit.UseVisualStyleBackColor = true;
            this.AddInstrSubmit.Click += new System.EventHandler(this.AddInstrSubmit_Click);
            // 
            // RmInstrSubmit
            // 
            this.RmInstrSubmit.Location = new System.Drawing.Point(376, 254);
            this.RmInstrSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.RmInstrSubmit.Name = "RmInstrSubmit";
            this.RmInstrSubmit.Size = new System.Drawing.Size(94, 24);
            this.RmInstrSubmit.TabIndex = 13;
            this.RmInstrSubmit.Text = "Remove Instructor";
            this.RmInstrSubmit.UseVisualStyleBackColor = true;
            this.RmInstrSubmit.Click += new System.EventHandler(this.RmInstrSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "What is the name of the instructor to add?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "What is their discord ID?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "What is the discord ID of the instructor you wish to remove?";
            // 
            // AddInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(667, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RmInstrSubmit);
            this.Controls.Add(this.AddInstrSubmit);
            this.Controls.Add(this.RmInstrDCIDTxtbox);
            this.Controls.Add(this.InstructDCIDTxtbox);
            this.Controls.Add(this.NewInstNameTxtbox);
            this.Controls.Add(this.BkFromAddInst);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddInstructor";
            this.Text = "Shapershifter Calculator - Add Instructor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BkFromAddInst;
        private System.Windows.Forms.TextBox NewInstNameTxtbox;
        private System.Windows.Forms.TextBox InstructDCIDTxtbox;
        private System.Windows.Forms.TextBox RmInstrDCIDTxtbox;
        private System.Windows.Forms.Button AddInstrSubmit;
        private System.Windows.Forms.Button RmInstrSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
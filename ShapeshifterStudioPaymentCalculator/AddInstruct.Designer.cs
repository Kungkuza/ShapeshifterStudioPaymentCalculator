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
            this.SuspendLayout();
            // 
            // BkFromAddInst
            // 
            this.BkFromAddInst.Location = new System.Drawing.Point(47, 390);
            this.BkFromAddInst.Name = "BkFromAddInst";
            this.BkFromAddInst.Size = new System.Drawing.Size(57, 30);
            this.BkFromAddInst.TabIndex = 8;
            this.BkFromAddInst.Text = "Back";
            this.BkFromAddInst.UseVisualStyleBackColor = true;
            // 
            // NewInstNameTxtbox
            // 
            this.NewInstNameTxtbox.Location = new System.Drawing.Point(119, 127);
            this.NewInstNameTxtbox.Name = "NewInstNameTxtbox";
            this.NewInstNameTxtbox.Size = new System.Drawing.Size(152, 22);
            this.NewInstNameTxtbox.TabIndex = 9;
            // 
            // InstructDCIDTxtbox
            // 
            this.InstructDCIDTxtbox.Location = new System.Drawing.Point(119, 232);
            this.InstructDCIDTxtbox.Name = "InstructDCIDTxtbox";
            this.InstructDCIDTxtbox.Size = new System.Drawing.Size(154, 22);
            this.InstructDCIDTxtbox.TabIndex = 10;
            // 
            // RmInstrDCIDTxtbox
            // 
            this.RmInstrDCIDTxtbox.Location = new System.Drawing.Point(502, 127);
            this.RmInstrDCIDTxtbox.Name = "RmInstrDCIDTxtbox";
            this.RmInstrDCIDTxtbox.Size = new System.Drawing.Size(162, 22);
            this.RmInstrDCIDTxtbox.TabIndex = 11;
            // 
            // AddInstrSubmit
            // 
            this.AddInstrSubmit.Location = new System.Drawing.Point(119, 313);
            this.AddInstrSubmit.Name = "AddInstrSubmit";
            this.AddInstrSubmit.Size = new System.Drawing.Size(114, 29);
            this.AddInstrSubmit.TabIndex = 12;
            this.AddInstrSubmit.Text = "Add Instructor";
            this.AddInstrSubmit.UseVisualStyleBackColor = true;
            // 
            // RmInstrSubmit
            // 
            this.RmInstrSubmit.Location = new System.Drawing.Point(502, 313);
            this.RmInstrSubmit.Name = "RmInstrSubmit";
            this.RmInstrSubmit.Size = new System.Drawing.Size(126, 30);
            this.RmInstrSubmit.TabIndex = 13;
            this.RmInstrSubmit.Text = "Remove Instructor";
            this.RmInstrSubmit.UseVisualStyleBackColor = true;
            // 
            // AddInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RmInstrSubmit);
            this.Controls.Add(this.AddInstrSubmit);
            this.Controls.Add(this.RmInstrDCIDTxtbox);
            this.Controls.Add(this.InstructDCIDTxtbox);
            this.Controls.Add(this.NewInstNameTxtbox);
            this.Controls.Add(this.BkFromAddInst);
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
    }
}
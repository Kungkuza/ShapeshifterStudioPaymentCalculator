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
            this.RmInstrTxtbox = new System.Windows.Forms.TextBox();
            this.AddInstrSubmit = new System.Windows.Forms.Button();
            this.RmInstrSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BkFromAddInst
            // 
            this.BkFromAddInst.Location = new System.Drawing.Point(47, 390);
            this.BkFromAddInst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BkFromAddInst.Name = "BkFromAddInst";
            this.BkFromAddInst.Size = new System.Drawing.Size(57, 30);
            this.BkFromAddInst.TabIndex = 8;
            this.BkFromAddInst.Text = "Back";
            this.BkFromAddInst.UseVisualStyleBackColor = true;
            this.BkFromAddInst.Click += new System.EventHandler(this.BkFromAddInst_Click);
            // 
            // NewInstNameTxtbox
            // 
            this.NewInstNameTxtbox.Location = new System.Drawing.Point(119, 127);
            this.NewInstNameTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewInstNameTxtbox.Name = "NewInstNameTxtbox";
            this.NewInstNameTxtbox.Size = new System.Drawing.Size(152, 22);
            this.NewInstNameTxtbox.TabIndex = 9;
            // 
            // InstructDCIDTxtbox
            // 
            this.InstructDCIDTxtbox.Location = new System.Drawing.Point(119, 231);
            this.InstructDCIDTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InstructDCIDTxtbox.Name = "InstructDCIDTxtbox";
            this.InstructDCIDTxtbox.Size = new System.Drawing.Size(153, 22);
            this.InstructDCIDTxtbox.TabIndex = 10;
            // 
            // RmInstrTxtbox
            // 
            this.RmInstrTxtbox.Location = new System.Drawing.Point(501, 127);
            this.RmInstrTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RmInstrTxtbox.Name = "RmInstrTxtbox";
            this.RmInstrTxtbox.Size = new System.Drawing.Size(161, 22);
            this.RmInstrTxtbox.TabIndex = 11;
            // 
            // AddInstrSubmit
            // 
            this.AddInstrSubmit.Location = new System.Drawing.Point(119, 313);
            this.AddInstrSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddInstrSubmit.Name = "AddInstrSubmit";
            this.AddInstrSubmit.Size = new System.Drawing.Size(115, 30);
            this.AddInstrSubmit.TabIndex = 12;
            this.AddInstrSubmit.Text = "Add Instructor";
            this.AddInstrSubmit.UseVisualStyleBackColor = true;
            this.AddInstrSubmit.Click += new System.EventHandler(this.AddInstrSubmit_Click);
            // 
            // RmInstrSubmit
            // 
            this.RmInstrSubmit.Location = new System.Drawing.Point(501, 313);
            this.RmInstrSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RmInstrSubmit.Name = "RmInstrSubmit";
            this.RmInstrSubmit.Size = new System.Drawing.Size(125, 30);
            this.RmInstrSubmit.TabIndex = 13;
            this.RmInstrSubmit.Text = "Remove Instructor";
            this.RmInstrSubmit.UseVisualStyleBackColor = true;
            this.RmInstrSubmit.Click += new System.EventHandler(this.RmInstrSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "What is the name of the instructor to add?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "What is their discord ID?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "What is the discord ID of the instructor you wish to remove?";
            // 
            // AddInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RmInstrSubmit);
            this.Controls.Add(this.AddInstrSubmit);
            this.Controls.Add(this.RmInstrTxtbox);
            this.Controls.Add(this.InstructDCIDTxtbox);
            this.Controls.Add(this.NewInstNameTxtbox);
            this.Controls.Add(this.BkFromAddInst);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddInstructor";
            this.Text = "Shapershifter Calculator - Add Instructor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BkFromAddInst;
        private System.Windows.Forms.TextBox NewInstNameTxtbox;
        private System.Windows.Forms.TextBox InstructDCIDTxtbox;
        private System.Windows.Forms.TextBox RmInstrTxtbox;
        private System.Windows.Forms.Button AddInstrSubmit;
        private System.Windows.Forms.Button RmInstrSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
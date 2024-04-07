using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeshifterStudioPaymentCalculator
{
    public partial class AddInstructor : Form
    {
        public AddInstructor()
        {
            InitializeComponent();
        }

        private void BkFromAddInst_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void AddInstrSubmit_Click(object sender, EventArgs e)
        {
            string NewInstName = NewInstNameTxtbox.Text;

            string AddInstructDCID = InstructDCIDTxtbox.Text;
        }

        private void RmInstrSubmit_Click(object sender, EventArgs e)
        {
            string RmDCID = RmInstrSubmit.Text;
        }
    }
}

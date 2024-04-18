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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BkFromOverallBreakdown_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void SubmitUSDBtn_Click(object sender, EventArgs e)
        {
            string USDAvail = AvailUSDTxtBox.Text;
            DateTime monthOfPayout = BreakdownPaymentmonthCalendar.SelectionStart;
            string DisplayRTB = OwedAmountALLInstructorsRTB.Text;



            
        }
    }
}

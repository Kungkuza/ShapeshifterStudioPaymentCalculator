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
    public partial class CalculatePay : Form
    {
        //needs ccalculator
        public CalculatePay()
        {
            InitializeComponent();
        }

        private void BkFromCalcPay_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void SubmitCalcPayBtn_Click(object sender, EventArgs e)
        {
            DateTime CalcPayTime = CalcPaymonthCalendar.SelectionStart;
            string CPayInstructor = CPayInstcomboBox.Text;
            string PaymenyReadout = PaymentForTheMonthTxtBox.Text;
            string PercentReadout = PaymentForTheMonthTxtBox.Text;  

            CPayInstcomboBox.Text = CPayInstructor;
            CPayInstcomboBox.DataSource = Program.instructors;

            Calculation calcpay = new Calculation();

        }
    }
}

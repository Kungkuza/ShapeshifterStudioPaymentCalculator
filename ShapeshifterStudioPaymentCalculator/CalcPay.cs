using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShapeshifterStudioPaymentCalculator
{
    public partial class CalculatePay : Form
    {
        //needs ccalculator

        public CalculatePay()
        {
            InitializeComponent();
            CPayInstcomboBox.DataSource = Program.instructors;
            CPayInstcomboBox.DisplayMember = "Name";
            CPayInstcomboBox.ValueMember = "DCID";
            CPayInstcomboBox.Refresh();
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
            Instructor selectedInstructor = (Instructor)CPayInstcomboBox.SelectedItem;
            string USDAvail = USDAvailtxtBox.Text;

            CPayInstcomboBox.Refresh();
            string PointsLogName = "PointsLog.txt";

            IFileOperations fileOperations = new FileOperations();

            // Create an instance of Calculation by passing the fileOperations instance
            Calculator Calc = new Calculator();

            // Now you can use the calculation instance
            List <string> CalculatedList = Calc.GetInstructorRecords(PointsLogName, CPayInstructor);
        }
    }
}

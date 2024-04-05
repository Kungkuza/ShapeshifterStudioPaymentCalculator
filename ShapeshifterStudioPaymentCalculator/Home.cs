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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void AddInstBtn_Click(object sender, EventArgs e)
        {
            AddInstructor Addinst = new AddInstructor();
            Addinst.Show();
            this.Hide();
        }

        private void StdntFdbkBtn_Click(object sender, EventArgs e)
        {
            Feedback Fdbk = new Feedback();
            Fdbk.Show();
            this.Hide();
        }

        private void AddPtsBtn_Click(object sender, EventArgs e)
        {
            AddPoints addPoints = new AddPoints();
            addPoints.Show();
            this.Hide();
        }

        private void OverallPtsBtn_Click(object sender, EventArgs e)
        {
            Form3 breakDown = new Form3();
            breakDown.Show();
            this.Hide();
        }

        private void ViewLogsBtn_Click(object sender, EventArgs e)
        {
            PointLogs viewPtLogs = new PointLogs();
            viewPtLogs.Show();
            this.Hide();
        }

        private void CalcPayBtn_Click(object sender, EventArgs e)
        {
            CalculatePay calcPay = new CalculatePay();
            calcPay.Show();
            this.Hide();
        }
    }
}

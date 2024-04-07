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
    public partial class AddPoints : Form
    {
        public AddPoints()
        {
            InitializeComponent();
        }

        private void BkFromAddPts_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void AddPtsSubmit_Click(object sender, EventArgs e)
        {
            string instructFile = "instructors.txt";
            DateTime selectedDate = AddPtsCal.SelectionStart;
            string whichInstructor = WhichInstCombo.SelectedItem.ToString();
            string typeofAction = TypeofActionCombo.SelectedItem.ToString();
            string pointsawarded = PtsAmountTxtbox.Text;

            Logbook.Log(instructFile, selectedDate + whichInstructor + typeofAction + pointsawarded); 
        }
    }
}

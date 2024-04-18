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
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void BkFromStdntFdbk_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void SubmitFeedBk_Click(object sender, EventArgs e)
        {
            string StudentName = StudentNameTxtBox.Text;
            string StudentFeedback = StudentFeedBkRTxtBox.Text;
            string StudentPoints = StudentPointModifier.Text;
            string InstructorName = InstructorNamecomboBox.SelectedItem.ToString();

            InstructorNamecomboBox.DataSource = Program.instructors;

            //Interacts with the Pointslog text file, feedback goes on the back ofeach string



            
        }
    }
}

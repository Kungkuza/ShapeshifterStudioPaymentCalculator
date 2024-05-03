using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShapeshifterStudioPaymentCalculator
{
    public partial class AddPoints : Form
    {
        //IList<Instructor> instructorsList = Program.instructors;
        public AddPoints()
        {
            InitializeComponent();
            WhichInstCombo.DataSource = Program.instructors;
            WhichInstCombo.DisplayMember = "Name";
            WhichInstCombo.ValueMember = "DCID";

            IList<string> actions = new List<string>();
            actions.Add("Lesson");
            actions.Add("Assist Lesson");
            actions.Add("Lesson Recording");
            actions.Add("Lesson Planning");
            actions.Add("Lesson Workshops");
            actions.Add("TikToks/Socials Help");

            TypeofActionCombo.DataSource = actions;
            TypeofActionCombo.DisplayMember = "ToString";
        }

        private void BkFromAddPts_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void AddPtsSubmit_Click(object sender, EventArgs e)
        {
            string Pointsfile = "PointsLog.txt";
            DateTime selectedDate = AddPtsCal.SelectionStart;
            string whichInstructor = WhichInstCombo.SelectedItem.ToString();
            Instructor selectedInstructor = (Instructor) WhichInstCombo.SelectedItem;

            string instructorName = selectedInstructor.Name;


            string typeofAction = TypeofActionCombo.SelectedItem.ToString();
            string pointsawarded = PtsAmountTxtbox.Text;
            string dateStr = selectedDate.ToString("MM/dd/yyyy");


            Logbook logbook = new Logbook("PointsLog.txt");

            logbook.Log(Pointsfile, $"{dateStr}, {instructorName}, {typeofAction}, {pointsawarded}");
            confirmation.Text = "Submitted";
        }
    }
}

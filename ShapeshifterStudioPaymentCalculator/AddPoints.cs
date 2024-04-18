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
        }

        private void BkFromAddPts_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void AddPtsSubmit_Click(object sender, EventArgs e)
        {
            IList<string> actions = new List<string>();
            actions.Add("Lesson");
            actions.Add("Assist Lesson");
            actions.Add("Lesson Recording");
            actions.Add("Lesson Planning");
            actions.Add("Lesson Workshops");
            actions.Add("TikToks/Socials Help");
            string Pointsfile = "PointsLog.txt";

            DateTime selectedDate = AddPtsCal.SelectionStart;
            string whichInstructor = WhichInstCombo.SelectedItem.ToString();

            //foreach

            WhichInstCombo.DataSource = Program.instructors;
            TypeofActionCombo.DataSource = actions;

            string typeofAction = TypeofActionCombo.SelectedItem.ToString();
            string pointsawarded = PtsAmountTxtbox.Text;

            Logbook logbook = new Logbook();

            logbook.Log(Pointsfile, $"{selectedDate},{whichInstructor},{typeofAction},{pointsawarded}");

        }
    }
}

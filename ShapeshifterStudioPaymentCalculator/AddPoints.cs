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
            actions.Add("");
            actions.Add("");
            actions.Add("");
            string instructFile = "Instructors.txt";

            DateTime selectedDate = AddPtsCal.SelectionStart;
            string whichInstructor = WhichInstCombo.SelectedItem.ToString();



            //foreach

            WhichInstCombo.DataSource = Program.instructors;
            TypeofActionCombo.DataSource = actions;
            

            //WhichInstCombo.DataSource = ;
            //whichInstructor.DisplayMember = "Name";

            string typeofAction = TypeofActionCombo.SelectedItem.ToString();
            string pointsawarded = PtsAmountTxtbox.Text;

            Logbook logbook = new Logbook();

            logbook.Log(instructFile, selectedDate + whichInstructor + typeofAction + pointsawarded);
        }
    }
}

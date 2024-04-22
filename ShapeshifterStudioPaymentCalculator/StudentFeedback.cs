using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            string StudentDiscord = StudentDCIDTxtBox.Text;
            StudentPoints += "PTS";

            string Pointsfile = "PointsLog.txt";
            string Studentsfile = "Students.txt";

            string currentTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm");

            InstructorNamecomboBox.DataSource = Program.instructors;
            Logbook logbook = new Logbook(Pointsfile);

            Program.students.Add(new Student(StudentName, StudentDiscord));

            logbook.Log(Pointsfile, $"{currentTime}, {InstructorName}, {StudentName}, {StudentFeedback}, {StudentPoints}");
            logbook.Log(Studentsfile, $"{currentTime}, {StudentName}, {StudentFeedback}");

            //Interacts with the Pointslog text file, feedback goes on the back ofeach string




        }
    }
}

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
    public partial class AddInstructor : Form
    {
        public AddInstructor()
        {
            InitializeComponent();

        }

        private void BkFromAddInst_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void AddInstrSubmit_Click(object sender, EventArgs e)
        {
            string NewInstName = NewInstNameTxtbox.Text;

            string AddInstructDCID = InstructDCIDTxtbox.Text;
            string StripeAcctId = StripeAcctIdTxtbox.Text;
            Logbook instructorLogbook = Program.instructorLogbook;

            Instructor newInstructor = new Instructor(NewInstName, AddInstructDCID, StripeAcctId);
            Program.instructors.Add(newInstructor);

            //Add instructor to file Instructors.txt
            string logData = $"{NewInstName}, {AddInstructDCID}, {StripeAcctId}";
            instructorLogbook.Log("Instructors.txt", logData);
            confirmation1.Text = "Submitted";
        }

        private void RmInstrSubmit_Click(object sender, EventArgs e)
        {
            var LBook = Program.instructorLogbook; 
            string RmByID = RmInstrTxtbox.Text;

            foreach (Instructor instructor in Program.instructors.ToList())
            {
                string selectedDCID = instructor.DCID;
                if (selectedDCID == RmByID)
                {
                    Program.instructors.Remove(instructor);
                    LBook.RemoveEntry("Instructors.txt", RmByID);
                    LBook.RemoveEntry("PointsLog.txt", RmByID);
                }
            }
            confirmation2.Text = "Submitted";
        }
    }
}

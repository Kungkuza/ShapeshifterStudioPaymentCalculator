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
            Logbook instructorLogbook = Program.instructorLogbook;

            Instructor newInstructor = new Instructor(NewInstName, AddInstructDCID);
            Program.instructors.Add(newInstructor);

            //Add instructor to file Instructors.txt
            string logData = $"{NewInstName} + {AddInstructDCID}";
            //In the format of Name then DCID
            var fileOperations = new FileOperations();

            instructorLogbook.Log("Instructor.txt", logData);

        }

        private void RmInstrSubmit_Click(object sender, EventArgs e)
        {
            string RmDCID = RmInstrSubmit.Text;

            foreach (Instructor instructor in Program.instructors.ToList())
            {
                if (instructor.DCID == RmDCID)
                {
                    Program.instructors.Remove(instructor);
                }
            }

            var LBook = Program.instructorLogbook;
            LBook.RemoveEntry("Instructors.txt", RmDCID);

        }
    }
}

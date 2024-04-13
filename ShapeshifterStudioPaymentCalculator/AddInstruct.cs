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
        //Accessing instructors list.
        IList<Instructor> instructors = Program.instructors;


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

            Instructor newInstructor = new Instructor(NewInstName, AddInstructDCID);
            instructors.Add(newInstructor);

            //Add instructor to file Instructors.txt
            string logData = $"{NewInstName} + {AddInstructDCID}";
            //In the format of Name then DCID
            Program.instructorLogbook.Log("Instructor.txt", logData);



        }

        private void RmInstrSubmit_Click(object sender, EventArgs e)
        {
            string RmDCID = RmInstrSubmit.Text;

            foreach (Instructor instructor in instructors.ToList())
            {
                if (instructor.DCID == RmDCID)
                {
                    instructors.Remove(instructor);
                }
            }

            //Logbook.RemoveEntry("Instructors.txt", DCID);

            //also remove from instructors.txt file

            //Instructor newInstructor = null;
        }
    }
}

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
        public static List<Instructor> instructors = new List<Instructor>();    

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

            //AddToFile
            //instructors.Add("Hi");
            
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

            //also remove from instructos.txt file

            //Instructor newInstructor = null;
        }
    }
}

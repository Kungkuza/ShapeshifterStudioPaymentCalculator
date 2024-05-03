using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShapeshifterStudioPaymentCalculator
{
    public partial class CalculatePay : Form
    {
        //needs ccalculator

        public CalculatePay()
        {
            InitializeComponent();
            CPayInstcomboBox.DataSource = Program.instructors;
            CPayInstcomboBox.DisplayMember = "Name";
            CPayInstcomboBox.ValueMember = "DCID";
            CPayInstcomboBox.Refresh();
        }

        private void BkFromCalcPay_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void SubmitCalcPayBtn_Click(object sender, EventArgs e)
        {
            DateTime CalcPayTime = CalcPaymonthCalendar.SelectionStart;
            string CPayInstructor = CPayInstcomboBox.Text;
            
            Instructor selectedInstructor = (Instructor)CPayInstcomboBox.SelectedItem;
            string USDAvail = USDAvailtxtBox.Text;
            string directoryPath;
            string fileName = "PointsLog.txt";
            string BDFileName = "BreakDown.txt";
            decimal usdAmount = decimal.Parse(USDAvailtxtBox.Text.Replace(",", ""));

            directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            // Navigate back three directories
            for (int i = 0; i < 3; i++)
            {
                directoryPath = Path.GetDirectoryName(directoryPath);
            }

            CPayInstcomboBox.Refresh();
            string PointsLogPath = Path.Combine(directoryPath, fileName);
            string BDTextPath = Path.Combine(directoryPath, BDFileName);
            IFileOperations fileOperations = new FileOperations();

            // Create an instance of Calculation by passing the fileOperations instance
           
            Calculator calcu = new Calculator();
            if (File.Exists(BDTextPath) && new FileInfo(BDTextPath).Length > 0)
            {
                // Clear the file contents
                File.WriteAllText(BDTextPath, string.Empty);
            }


            calcu.GetInstructorRecords("PointsLog.txt", CalcPayTime, usdAmount, CPayInstructor);
            confirmation.Text = "Submitted";

            try
            {
                // Read all lines from the BreakDown.txt file
                string[] lines = File.ReadAllLines(BDTextPath);

                // Set the text of the RichTextBox to the contents of the BreakDown.txt file
                CalcPayRTB.Text = string.Join(Environment.NewLine, lines);
                Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error displaying BreakDown.txt contents: {ex.Message}");
            }
            // Now you can use the calculation instance
            //"PointsLog.txt" , CalcPayTime, usdAmount, CPayInstructor
        }
    }
}

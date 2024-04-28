using System;
using System.IO;
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
    public partial class Form3 : Form
    {       
        public Form3()
        {
            InitializeComponent();
        }

        private void BkFromOverallBreakdown_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void SubmitUSDBtn_Click(object sender, EventArgs e)
        {
            string USDAvail = AvailUSDTxtBox.Text;
            DateTime monthOfPayout = BreakdownPaymentmonthCalendar.SelectionStart;
            string DisplayRTB = OwedAmountALLInstructorsRTB.Text;
            Logbook logbook = new Logbook("PointsLog.txt");
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            for (int i = 0; i < 3; i++)
            {
                directoryPath = Path.GetDirectoryName(directoryPath);
            }
            string filePath = Path.Combine(directoryPath, "PointsLog.txt");
            string breakdownFilePath = Path.Combine(directoryPath, "BreakDown.txt");
            decimal usdAmount = decimal.Parse(AvailUSDTxtBox.Text.Replace(",", ""));


            // Create an instance of the Calculation class
            Calculation calculation = new Calculation(new FileOperations());

            // Call the CalculateInstructorPercentages method
            calculation.CalculateInstructorPercentages("PointsLog.txt", monthOfPayout, usdAmount);

            try
            {
                // Read all lines from the BreakDown.txt file
                string[] lines = File.ReadAllLines(breakdownFilePath);

                // Set the text of the RichTextBox to the contents of the BreakDown.txt file
                OwedAmountALLInstructorsRTB.Text = string.Join(Environment.NewLine, lines);
                Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error displaying BreakDown.txt contents: {ex.Message}");
            }


        }
    }
}

using ShapeshifterStudioPaymentCalculator.stripe;
using Stripe;
using System;
using System.IO;
using System.Windows.Forms;
using File = System.IO.File;

namespace ShapeshifterStudioPaymentCalculator
{
    public partial class CalculatePay : Form
    {
        //needs ccalculator
        decimal pay;

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
            pay = 0;

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


            pay = calcu.GetInstructorRecords("PointsLog.txt", CalcPayTime, usdAmount, CPayInstructor);
            confirmation.Text = "Submitted";

            try
            {
                // Read all lines from the BreakDown.txt file
                string[] lines = System.IO.File.ReadAllLines(BDTextPath);

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

        private void SubmitPayment_Click(object sender, EventArgs e)
        {
            Instructor selectedInstructor = (Instructor)CPayInstcomboBox.SelectedItem;


            if (selectedInstructor == null)
            {
                MessageBox.Show("Error: No instructor selected. Please select an instructor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else if (pay == 0)
            {
                MessageBox.Show("Error: No payment calculated. Please calculate payment first, or check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedInstructor.StripeAccountId == "acct_none") { // If the instructor has no Stripe account
                MessageBox.Show("Error: This instructor has an account id of acct_none. This either means they do not have a stripe account, or they have opted out of using it. Please contact the instructor to resolve this issue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ask for 2 confirmations before processing the payment
            DialogResult confirmPayment = MessageBox.Show("Are you sure you want to process the payment for " + selectedInstructor.Name + "?", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            for (int i = 1; i < 2; i++)
            {
                if (confirmPayment == DialogResult.Yes)
                {
                    confirmPayment = MessageBox.Show("Are you absolutely sure you want to process the payment for " + selectedInstructor.Name + "?", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else
                {
                   MessageBox.Show("Payment cancelled.", "Payment Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Disable the button to prevent multiple payments
            SubmitPayment.Enabled = false;
            SubmitCalcPayBtn.Enabled = false;
            BkFromCalcPay.Enabled = false;

            // Create a unloseable Dialog box with a "intermediate" loading bar and a "processing payment" message
            PaymentStatusForm paymentStatusForm = new PaymentStatusForm();
            paymentStatusForm.Show();

            // Set the title of the form
            paymentStatusForm.SetWindowTitle("Processing Payment");
            paymentStatusForm.SetProgressText("Processing payment for " + selectedInstructor.Name + "...");

            int amount = ShapeshifterStudioPaymentCalculator.Program.stripeHandler.ToStripeAmount(pay);

            // Attempt to send the payment
            try
            {
                // Send the payment
                Transfer transfer = ShapeshifterStudioPaymentCalculator.Program.stripeHandler.PayoutToInstructor(selectedInstructor.StripeAccountId, amount);
                paymentStatusForm.CloseForm();

                MessageBox.Show("Payment successful! Transfer ID: " + transfer.Id + "\n\nThe instructor should see this in their account now.", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (StripeException ex)
            {
                paymentStatusForm.CloseForm();
                Console.WriteLine("Error processing payment: " + ex.Message);
                MessageBox.Show("Error processing payment: " + ex.Message, "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally
            {
                // Re-enable the buttons
                SubmitPayment.Enabled = true;
                SubmitCalcPayBtn.Enabled = true;
                BkFromCalcPay.Enabled = true;
            }
        }
    }
}

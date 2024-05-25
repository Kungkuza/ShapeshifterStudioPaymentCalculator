using System;
using System.Windows.Forms;

namespace ShapeshifterStudioPaymentCalculator.stripe
{
    public partial class PaymentStatusForm : Form
    {
        public PaymentStatusForm()
        {
            InitializeComponent();
        }

        public void OnShown(object sender, EventArgs e)
        {
            // Set progress bar to 0 and indterminate
            paymentProgressBar.Value = 0;
            paymentProgressBar.Style = ProgressBarStyle.Marquee;

            // Set status text
            paymentProgressText.Text = "Initializing...";

            // Call draw method
            paymentProgressBar.Refresh();
            paymentProgressText.Refresh();
        }

        public void SetProgressText(string text)
        {
            paymentProgressText.Text = text;
            paymentProgressText.Refresh();
        }

        public void SetProgressValue(int value)
        {
            paymentProgressBar.Value = value;
            paymentProgressBar.Refresh();
        }

        public void SetProgressStyle(ProgressBarStyle style)
        {
            paymentProgressBar.Style = style;
            paymentProgressBar.Refresh();
        }

        public void SetWindowTitle(string title)
        {
            this.Text = title;
        }

        public void CloseForm()
        {
            this.Close();
            this.Dispose();
        }
    }
}

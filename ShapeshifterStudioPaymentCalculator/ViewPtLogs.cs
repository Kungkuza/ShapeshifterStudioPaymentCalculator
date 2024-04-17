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
    public partial class PointLogs : Form
    {
        public PointLogs()
        {
            InitializeComponent();
            string FileReadoutRTB = FileReadoutrichTextBox.Text;

            string filePath = "PointsLog.txt";
            string fileContents = File.ReadAllText(filePath);

            // Set the text of the RichTextBox to display the file contents
            FileReadoutrichTextBox.Text = fileContents;
        }

        private void BkFromViewPtLogs_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void download_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Set the initial directory and filename (optional)
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.FileName = "PointsLog.txt";

            // Set the file filter to specify the file type (optional)
            //saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            // Show the SaveFileDialog and check if the user clicked the OK button
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file name
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Write your file download logic here
                    // For example, you can use File.WriteAllLines to write content to the file
                    string[] fileContent = File.ReadAllLines("PointsLog.txt");


                    MessageBox.Show("File downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error downloading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

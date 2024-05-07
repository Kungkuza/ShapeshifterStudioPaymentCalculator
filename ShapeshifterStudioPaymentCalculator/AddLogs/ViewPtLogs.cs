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
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            for (int i = 0; i < 3; i++)
            {
                directoryPath = Path.GetDirectoryName(directoryPath);
            }
            string filePath = Path.Combine(directoryPath, "PointsLog.txt");
            string fileContents = File.ReadAllText(filePath);

            // Set the text of the RichTextBox to display the file contents
            FileReadoutrichTextBox.Text = fileContents;
            Refresh();
        }

        private void BkFromViewPtLogs_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Download_click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Set the initial directory and filename (optional)
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.FileName = "PointsLog.txt";

            // Show the SaveFileDialog and check if the user clicked the OK button
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file name
                string filePath = saveFileDialog.FileName;

                try
                {
                    // file download 
                    string[] fileContent = File.ReadAllLines("PointsLog.txt");

                    MessageBox.Show("File downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error downloading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            // Show a file dialog to allow the user to select a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            Logbook logbook = new Logbook("PointsLog.txt");

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string selectedFilePath = openFileDialog.FileName;

                try
                {
                    // Call the method to overwrite the PointsLog.txt file with the contents of the uploaded file
                    logbook.OverwritePointsLogFile(selectedFilePath);

                    // Optionally, display a message to indicate success
                    MessageBox.Show("File uploaded successfully and PointsLog.txt updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Display an error message if something goes wrong
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}


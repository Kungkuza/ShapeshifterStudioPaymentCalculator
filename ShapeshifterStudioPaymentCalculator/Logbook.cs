using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeshifterStudioPaymentCalculator
{
    public interface IFileOperations
    {
        void AppendToFile(string fileName, string data);
        IEnumerable<string> ReadFileLines(string fileName);
    }

    public class FileOperations : IFileOperations
    {
        public void AppendToFile(string fileName, string data)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(data);
            }
        }

        public IEnumerable<string> ReadFileLines(string fileName)
        {
            return File.ReadLines(fileName);
        }
    }

    internal class Logbook
    {

        protected string InstructorName;
        protected string StudentName;
        private protected IFileOperations fileOperations;
        private protected string directoryPath;
        public string DirectoryPath { get; }


        //Constructors
        public void LogBook(IFileOperations fileOperations)
        {
            //fileOperations = fileOp;

            // Get the directory of the solution file
            directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        public void Log(string fileName, string entry = null) //outdated
        {

            string filePath = Path.Combine(directoryPath, fileName);

            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm"); //invalid, work on it

            // Concatenate the current date and time with the entry
            string newData = $"{entry}, {currentDate}";
            if (fileName == "PointsLog.txt")
            {
                entry = newData;
            }
            else
            {
                //Add data to file
                fileOperations.AppendToFile(filePath, entry);
            }
        }

        public IEnumerable<string> ReadLog(string fileName)
        {
            string filePath = Path.Combine(directoryPath, fileName);
            return fileOperations.ReadFileLines(filePath);
        }

        public void RemoveEntry(string fileName, string searchTerm)
        {
            string filePath = Path.Combine(directoryPath, fileName);

            //Read all lines from the file
            List<string> lines = new List<string>(fileOperations.ReadFileLines(filePath));

            //Iterate through the lines and remove the line containing the searchTerm
            for (int i = lines.Count - 1; i >= 0; i--)
            {
                if (lines[i].Contains(searchTerm))
                {
                    lines.RemoveAt(i);
                    //Assuming you want to remove only the first occurrence of the searchTerm
                    break;
                }
            }
            // Write the updated lines back to the file
            File.WriteAllLines(filePath, lines);
        }
        public List<string> Ret6MoPay(string pointsLogFileName, string breakdownFileName, decimal amountOfUSDAvailable)
        {
            // Get the full path of the files used
           
            string pointsLogFilePath = Path.Combine(directoryPath, pointsLogFileName);
            string breakdownFilePath = Path.Combine(directoryPath, breakdownFileName);
            List<string> processedRecords = new List<string>();


            try
            {
                // Read all lines from the PointsLog.txt file
                string[] lines = File.ReadAllLines(pointsLogFilePath);
               
                // Iterate over each line in the PointsLog.txt file
                foreach (string line in lines)
                {
                    // Parse the line
                    string[] parts = line.Split(',');
                    if (parts.Length >= 3)
                    {
                        // Extract instructor name, points, and date from the line
                        string instructorName = parts[0].Trim();
                        int points = int.Parse(parts[1].Trim());
                        DateTime date = DateTime.ParseExact(parts[2].Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture);

                        // Check if the instructor is in the instructors list
                        if (Program.instructors.Any(i => i.Name == instructorName))
                        {
                            // Check if the record is 6 months or younger
                            if (date >= DateTime.Now.AddMonths(-6))
                            {
                                // Calculate percentage of points
                                decimal percentage = (decimal)points / amountOfUSDAvailable * 100;

                                // Format the record for BreakDown.txt
                                string record = $"{instructorName}, DCID {Instructor(InstructorName).DCID} {points} PTS, {percentage:F2}%, ${percentage / 100 * amountOfUSDAvailable:F2}";

                                // Add the record to the processed records list
                                processedRecords.Add(record);
                            }
                        }
                    }
                }
                File.WriteAllLines(breakdownFilePath, processedRecords);

                return processedRecords;
                // Write the processed records to BreakDown.txt file
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error processing PointsLog.txt: {ex.Message}");
            }
            return processedRecords;

        }


    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShapeshifterStudioPaymentCalculator
{
    //This class controls calculations for all instructors aka breakdown
    internal class Calculation
    {
        public IFileOperations fileOperations;
        private readonly string _directoryPath;

        public Calculation(IFileOperations fileOperations)
        {
            this.fileOperations = fileOperations;

            // Get the directory of the solution file
            _directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            for (int i = 0; i < 3; i++)
            {
                _directoryPath = Path.GetDirectoryName(_directoryPath);
            }
        }

        public IFileOperations GetFileOperations()
        {
            return fileOperations;
        }
        public IEnumerable<string> ReadFileLines(string fileName)
        {
            string filePath = Path.Combine(_directoryPath, fileName);
            return fileOperations.ReadFileLines(filePath);
        }

        public void CalculateInstructorPercentages(string fileName, DateTime selectedDate, decimal USDPay)
        {
            string filePath = Path.Combine(_directoryPath, fileName);

            // Get the current date
            //DateTime currentDate = selectedDate.Now;

            // Calculate the date 6 months ago
            DateTime sixMonthsAgo = selectedDate.AddMonths(-6);

            // Read all lines from the log file
            IEnumerable<string> logEntries = fileOperations.ReadFileLines(filePath);

            // Filter log entries within the rolling 6-month period
            IEnumerable<string> entriesWithinPeriod = logEntries
                .Where(entry => IsWithinSixMonths(entry, sixMonthsAgo));

            // Dictionary to store points contributed by each instructor
            Dictionary<string, int> pointsByInstructor = new Dictionary<string, int>();

            // Parse each log entry to extract instructor and points
            foreach (string entry in entriesWithinPeriod)
            {
                // Example entry format: "02/28/2024, Ruby, Otherfield, 89"
                string[] parts = entry.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                string instructor = parts[1].Trim();
                int points = int.Parse(parts[3].Trim());

                // Update points for the instructor
                if (pointsByInstructor.ContainsKey(instructor))
                {
                    pointsByInstructor[instructor] += points;
                }
                else
                {
                    pointsByInstructor[instructor] = points;
                }
            }

            // Calculate the total points contributed in the 6-month period
            int totalPoints = pointsByInstructor.Values.Sum();
            string textfile = "BreakDown.txt";
            // Write the records to the breakdown file
            Logbook BDLogbook = new Logbook(textfile);
            {
                // Write each record
                    foreach (var kvp in pointsByInstructor)
                    {
                        string instructor = kvp.Key;
                        int points = kvp.Value;
                        double percentage = (double)points / totalPoints * 100;
                        decimal payThisMonth = USDPay * (decimal)percentage / 100;

                        BDLogbook.Log(textfile, $"Instructor: {instructor}, Points: {points}, Percentage: {percentage:F2}%, Pay this month: {payThisMonth:F2}");
                    }
            }
        }

        public bool IsWithinSixMonths(string entry, DateTime sixMonthsAgo)
        {
            // Example entry format: "02/28/2024 13:45 - Instructor: Ruby, 89 PTS"
            string[] parts = entry.Split(',').Select(p => p.Trim()).ToArray();
            string dateStr = parts[0];

            // Parse date from entry
            if (DateTime.TryParse(dateStr, out DateTime entryDate))
            {
                // Check if the entry date is within the rolling 6-month period
                return entryDate >= sixMonthsAgo;
            }

            return false; // Return false if date parsing fails
        }

    }
}

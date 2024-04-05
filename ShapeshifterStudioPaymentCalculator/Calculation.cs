using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeshifterStudioPaymentCalculator
{
    internal class Calculation
    {

        {
    private readonly IFileOperations _fileOperations;
        private readonly string _directoryPath;

        public Calculation(IFileOperations fileOperations)
        {
            _fileOperations = fileOperations;

            // Get the directory of the solution file
            _directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        public void CalculateInstructorPercentages(string fileName)
        {
            string filePath = Path.Combine(_directoryPath, fileName);

            // Get the current date
            DateTime currentDate = DateTime.Now;

            // Calculate the date 6 months ago
            DateTime sixMonthsAgo = currentDate.AddMonths(-6);

            // Read all lines from the log file
            IEnumerable<string> logEntries = _fileOperations.ReadFileLines(filePath);

            // Filter log entries within the rolling 6-month period
            IEnumerable<string> entriesWithinPeriod = logEntries
                .Where(entry => IsWithinSixMonths(entry, sixMonthsAgo));

            // Dictionary to store points contributed by each instructor
            Dictionary<string, int> pointsByInstructor = new Dictionary<string, int>();

            // Parse each log entry to extract instructor and points
            foreach (string entry in entriesWithinPeriod)
            {
                // Example entry format: "02/28/2024 13:45 - Instructor: Ruby, 89 PTS"
                string[] parts = entry.Split('-', StringSplitOptions.TrimEntries);
                string instructor = parts[1].Substring("Instructor:".Length).Trim();
                int points = int.Parse(parts[2].Split(' ')[0]);

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

            // Calculate and print the percentage of points contributed by each instructor
            foreach (var kvp in pointsByInstructor)
            {
                string instructor = kvp.Key;
                int points = kvp.Value;
                double percentage = (double)points / totalPoints * 100;

                Console.WriteLine($"Instructor: {instructor}, Points: {points}, Percentage: {percentage:F2}%");
            }
        }

        private bool IsWithinSixMonths(string entry, DateTime sixMonthsAgo)
        {
            // Example entry format: "02/28/2024 13:45 - Instructor: Ruby, 89 PTS"
            string[] parts = entry.Split('-', StringSplitOptions.TrimEntries);
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

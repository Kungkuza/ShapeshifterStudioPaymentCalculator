using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ShapeshifterStudioPaymentCalculator
{
    internal class Calculator
    {
        //This class controls calculations for singular instructors
        
        public Calculator()
        {

        }

        public decimal GetInstructorRecords(string fileName, DateTime selectedDate, decimal USDPay, string specifiedInstructor)
        {
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            for (int i = 0; i < 3; i++)
            {
                directoryPath = Path.GetDirectoryName(directoryPath);
            }
            string filePath = Path.Combine(directoryPath, "PointsLog.txt");
            string BDFile = "BreakDown.txt";

            // Get the current date
            //DateTime currentDate = selectedDate.Now;
            Calculation calculation = new Calculation(new FileOperations());

            // Calculate the date 6 months ago
            DateTime sixMonthsAgo = selectedDate.AddMonths(-6);

            // Read all lines from the log file
            IEnumerable<string> logEntries = calculation.fileOperations.ReadFileLines(filePath);

            // Dictionary to store points contributed by all instructors within the last 6 months
            Dictionary<string, int> totalPointsByInstructor = new Dictionary<string, int>();

            // Parse each log entry to extract points
            foreach (string entry in logEntries)
            {
                // Example entry format: "02/28/2024, Ruby, Otherfield, 89"
                string[] parts = entry.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                DateTime entryDate = DateTime.Parse(parts[0].Trim()); // Assuming date is the first part of the entry
                string instructor = parts[1].Trim();
                int points = int.Parse(parts[3].Trim());

                // Check if the entry is within the last 6 months
                if (entryDate >= sixMonthsAgo)
                {
                    // Accumulate points for all instructors
                    if (totalPointsByInstructor.ContainsKey(instructor))
                    {
                        totalPointsByInstructor[instructor] += points;
                    }
                    else
                    {
                        totalPointsByInstructor[instructor] = points;
                    }
                }
            }

            // Calculate the total points contributed by all instructors in the last 6 months
            int totalPoints = totalPointsByInstructor.Values.Sum();

            Logbook BDLB = new Logbook(BDFile);

            // Write records for all instructors
            {
                // Write header
                BDLB.Log(BDFile, "Instructor, Points, Percentage, Pay this month");

                // Write records for the specified instructor
                if (totalPointsByInstructor.ContainsKey(specifiedInstructor))
                {
                    int points = totalPointsByInstructor[specifiedInstructor];
                    double percentage = (double)points / totalPoints * 100;
                    decimal payThisMonth = USDPay * (decimal)percentage / 100;

                    BDLB.Log(BDFile, $"Instructor: {specifiedInstructor}, Points: {points}, Percentage: {percentage:F2}%, Pay this month: {payThisMonth:F2}");

                    return payThisMonth;
                } else
                {
                    BDLB.Log(BDFile, $"Instructor: {specifiedInstructor}, Points: 0, Percentage: 0.00%, Pay this month: 0.00");
                    return 0;
                }
            }

        }



    }
}

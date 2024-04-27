using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeshifterStudioPaymentCalculator
{
    internal class Calculator
    {
        //This class controls calculations for singular instructors
        protected int dollarAmountAvailUSD { get; set; }
        protected int rollingMonthsNum { get; set; }

        //setamountavailable
        //getamountavailable

        public Calculator()
        {

        }

        public List<string> GetInstructorRecords(string pointsLogFileName, string instructorName)
        {
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string pointsLogFilePath = Path.Combine(directoryPath, pointsLogFileName);
            List<string> instructorRecords = new List<string>();
            decimal totalPoints = 0;

            try
            {
                string[] lines = File.ReadAllLines(pointsLogFilePath);

                // First pass: Calculate total points for the specified instructor within the last 6 months
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 4)
                    {
                        string recordInstructorName = parts[1].Trim();
                        int points = int.Parse(parts[3].Trim());
                        DateTime date = DateTime.ParseExact(parts[0].Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture);

                        if (recordInstructorName == instructorName && date >= DateTime.Now.AddMonths(-6))
                        {
                            totalPoints += points;
                        }
                    }
                }

                // Second pass: Generate records for the specified instructor within the last 6 months
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 4)
                    {
                        string recordInstructorName = parts[1].Trim();
                        int points = int.Parse(parts[3].Trim());
                        DateTime date = DateTime.ParseExact(parts[0].Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture);

                        if (recordInstructorName == instructorName && date >= DateTime.Now.AddMonths(-6))
                        {
                            // Calculate percentage of points
                            decimal percentage = (decimal)points / totalPoints * 100;

                            // Get the DCID of the instructor (assuming you have a list of instructors)
                            string dcid = Program.instructors.FirstOrDefault(i => i.Name == instructorName)?.DCID ?? "null";

                            // Format the record string
                            string record = $"{recordInstructorName}, DCID {dcid} {points} PTS, {percentage:F2}%";

                            // Add the record to the list
                            instructorRecords.Add(record);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading PointsLog.txt: {ex.Message}");
            }

            return instructorRecords;
        }
    }
}

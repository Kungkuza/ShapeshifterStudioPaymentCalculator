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
        protected int dollarAmountAvailUSD {  get; set; }
        protected int rollingMonthsNum {  get; set; }

        //setamountavailable
        //getamountavailable

        public List<string> GetInstructorRecords(string pointsLogFileName, string instructorName)
        {
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string pointsLogFilePath = Path.Combine(directoryPath, pointsLogFileName);
            List<string> instructorRecords = new List<string>();
            decimal totalPoints = 0;

            try
            {
                string[] lines = File.ReadAllLines(pointsLogFilePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 3)
                    {
                        string recordInstructorName = parts[0].Trim();
                        int points = int.Parse(parts[1].Trim());
                        DateTime date = DateTime.ParseExact(parts[2].Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture);

                        if (recordInstructorName == instructorName && date >= DateTime.Now.AddMonths(-6))
                        {
                            totalPoints += points;
                        }
                    }
                }

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 3)
                    {
                        string recordInstructorName = parts[0].Trim();
                        int points = int.Parse(parts[1].Trim());
                        DateTime date = DateTime.ParseExact(parts[2].Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture);

                        if (recordInstructorName == instructorName && date >= DateTime.Now.AddMonths(-6))
                        {
                            decimal percentage = (decimal)points / totalPoints * 100;
                            string record = $"{recordInstructorName}, DCID {this.Instructor.DCID} {points} PTS, {percentage:F2}%";
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

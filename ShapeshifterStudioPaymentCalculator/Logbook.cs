using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //Constructor
        public void LogBook(IFileOperations fileOperations)
        {
            //fileOperations = fileOp;

            // Get the directory of the solution file
            directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }


        public void Log(string fileName, string entry) //outdated
        {

            string filePath = Path.Combine(directoryPath, fileName);

            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm");

            // Concatenate the current date and time with the entry
            string newData = $"{currentDate} - {entry}";
            if (fileName == "PointsLog.txt" )
            {
                entry = newData;
            }
            //Add data to file
            fileOperations.AppendToFile(filePath, entry);
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

    }
}

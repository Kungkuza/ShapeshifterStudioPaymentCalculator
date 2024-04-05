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
        private readonly IFileOperations _fileOperations;
        private readonly string _directoryPath;

        //Constructor
        public LogBook(IFileOperations fileOperations)
        {
            _fileOperations = fileOperations;

            // Get the directory of the solution file
            _directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }


        public void Log(string fileName, string entry)
        {
            string filePath = Path.Combine(_directoryPath, fileName);

            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm");

            // Concatenate the current date and time with the entry
            string newData = $"{currentDate} - {entry}";
            //Add data to file
            _fileOperations.AppendToFile(filePath, entry);
        }

        public IEnumerable<string> ReadLog(string fileName)
        {
            string filePath = Path.Combine(_directoryPath, fileName);
            return _fileOperations.ReadFileLines(filePath);
        }

    }
}

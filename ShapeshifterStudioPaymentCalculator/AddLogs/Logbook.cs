using System.Collections.Generic;
using System.IO;

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
            // Get the current directory of the executing assembly
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            // Navigate back three directories
            for (int i = 0; i < 3; i++)
            {
                directoryPath = Path.GetDirectoryName(directoryPath);
            }

            // Combine the current directory with the specified file name
            string filePath = Path.Combine(directoryPath, fileName);

            // Read and return the lines from the file
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
        private string fileName { get; set; }


        //Constructors
        public Logbook(IFileOperations fileOperations, string directoryPath, string fileName)
        {
            this.fileOperations = fileOperations;
            this.directoryPath = directoryPath;
            this.fileName = fileName;

            directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            // Navigate back three directories
            for (int i = 0; i < 3; i++)
            {
                directoryPath = Path.GetDirectoryName(directoryPath);
            }
        }

        public Logbook(string fileName)
        {
            this.fileName = fileName;
            this.directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            // Navigate back three directories
            for (int i = 0; i < 3; i++)
            {
                directoryPath = Path.GetDirectoryName(directoryPath);
            }

        }
        public void Log(string fileName, string entry = null) //outdated
        {
            if (fileOperations == null)
            {
                fileOperations = new FileOperations();
            }

            string filePath = Path.Combine(directoryPath, fileName);

            //string currentDate = DateTime.Now.ToString("MM/dd/yyyy"); //invalid, work on it

            fileOperations.AppendToFile(filePath, entry);

        }

        public IEnumerable<string> ReadLog(string fileName)
        {
            fileOperations = new FileOperations();

            for (int i = 0; i < 3; i++)
            {
                directoryPath = Path.GetDirectoryName(directoryPath);
            }
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
        public void OverwritePointsLogFile(string newfile)
        {
            string filePath = Path.Combine(directoryPath, fileName);
            // Overwrite the PointsLog.txt file with the contents of the uploaded file
            File.Copy(newfile, filePath, true);
        }

    }
}

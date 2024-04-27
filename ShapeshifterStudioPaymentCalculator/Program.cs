using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace ShapeshifterStudioPaymentCalculator
{

    internal static class Program
    {
        //public static FileOperations ReadF = FileOperations();
        public static Logbook instructorLogbook;
        public static Logbook studentsLogbook;
        public static Logbook pointsLogbook;


        // Declare list of instructors
        public static IList<Instructor> instructors = new List<Instructor>();
        public static IList<Student> students = new List<Student>();

        /// The main entry point for the application.

        [STAThread]
        static void Main()
        {
            // Initialize file operations and directory path
            IFileOperations fileOperations = new FileOperations();
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            // Create Logbook instances
            Program.instructorLogbook = new Logbook(fileOperations, directoryPath, "Instructors.txt");
            Program.pointsLogbook = new Logbook(fileOperations, directoryPath, "PointsLog.txt");
            Program.studentsLogbook = new Logbook(fileOperations, directoryPath, "Students.txt");

            // Read lines from the "Instructors.txt" file and initialize the list of instructors
            InitializeInstructors(instructorLogbook);
            InitializeStudents(studentsLogbook, "Students.txt");


            // Run the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }

        // Method to initialize the list of instructors from "Instructors.txt" file
        private static void InitializeInstructors(Logbook instructorLogbook)
        {
            // Read lines from "Instructors.txt" file
            var fileOperations = new FileOperations();

            //IFileOperations fileOperations = new FileOperations();
            IEnumerable<string> instructorLines = instructorLogbook.ReadLog("Instructors.txt");

            // Parse lines and initialize the list of instructors
            foreach (string line in instructorLines)
            {
                // Parse line and create Instructor object
                string[] parts = line.Split(',');
                if (parts.Length == 2)
                {
                    string name = parts[0].Trim();
                    string dcid = parts[1].Trim();
                    instructors.Add(new Instructor(name, dcid));
                    
                }
                // Add error handling if needed for invalid lines
                else
                {

                }
            }
        }
        static IList<Student> InitializeStudents(Logbook studentsLogbook, string fileName)
        {
            // Read lines from the specified file
            var fileOperations = new FileOperations();

            IEnumerable<string> studentLines = studentsLogbook.ReadLog(fileName);

            // Parse lines and initialize student list
            foreach (string line in studentLines)
            {
                // Parse line and create Student object
                string[] parts = line.Split(',');
                if (parts.Length == 2)
                {
                    string name = parts[0].Trim();
                    string studentID = parts[1].Trim();
                    students.Add(new Student(name, studentID));
                }
                // Add error handling if needed for invalid lines
            }
            return students;
        }
    }
}

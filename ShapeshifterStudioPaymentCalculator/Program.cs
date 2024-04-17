using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ShapeshifterStudioPaymentCalculator
{

    internal static class Program
    {
        // Declare Logbook instances
        public static Logbook instructorLogbook;
        public static Logbook pointsLogbook;
        public static Logbook studentsLogbook;


        // Declare list of instructors
        public static IList<Instructor> instructors = new List<Instructor>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize Logbook instances
            instructorLogbook = new Logbook('Instructors.txt');
            pointsLogbook = new Logbook("PointsLog.txt");
            studentsLogbook = new Logbook("Students.txt");

            // Read lines from the "Instructors.txt" file and initialize the list of instructors
            InitializeInstructors();
            InitializeStudents();
            //Init Students

            // Run the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }

        // Method to initialize the list of instructors from "Instructors.txt" file
        private static void InitializeInstructors()
        {
            // Read lines from "Instructors.txt" file
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
            }
        }
        static List<Student> InitializeStudents(Logbook logbook, string fileName)
        {
            // Read lines from the specified file
            IEnumerable<string> studentLines = logbook.ReadLog(fileName);

            // Parse lines and initialize student list
            List<Student> students = new List<Student>();
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

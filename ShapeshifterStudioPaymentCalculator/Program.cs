using ShapeshifterStudioPaymentCalculator.stripe;
using System;
using System.Collections.Generic;
using System.IO;
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

        // Handlers
        public static stripeHandler stripeHandler;


        /// The main entry point for the application.

        [STAThread]
        static void Main()
        {
            // Initialize file operations and directory path
            IFileOperations fileOperations = new FileOperations();
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            // Create Logbook instances
            instructorLogbook = new Logbook(fileOperations, directoryPath, "Instructors.txt");
            pointsLogbook = new Logbook(fileOperations, directoryPath, "PointsLog.txt");
            studentsLogbook = new Logbook(fileOperations, directoryPath, "Students.txt");

            // Read lines from the "Instructors.txt" file and initialize the list of instructors
            InitializeInstructors(instructorLogbook);
            InitializeStudents(studentsLogbook, "Students.txt");
            InitializeStripe();
            
            // Run the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }

        private static void InitializeStripe()
        {
            // Get our creds from stripe_creds.json
            string credsPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "stripe_creds.json");
            object credsInit = new { secretKey = "", publicKey = "" };

            // Check if the file exists, if not , create it and exit
            if (!File.Exists(credsPath))
            {
                File.WriteAllText(credsPath, Newtonsoft.Json.JsonConvert.SerializeObject(credsInit));
                MessageBox.Show("Fatal Error: stripe_creds.json not found. A new file has been created. Please fill in your Stripe API keys and restart the program.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

            // Read the creds from the file
            string credsJson = File.ReadAllText(credsPath);
            dynamic creds = Newtonsoft.Json.JsonConvert.DeserializeObject(credsJson);

            // Ensure we have both keys
            if (creds.secretKey == "" || creds.publicKey == "")
            {
                MessageBox.Show("Fatal Error: Stripe API keys not found in stripe_creds.json. Please fill in your Stripe API keys and restart the program.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

            // Parse both as strings
            string secretKey = creds.secretKey;
            string publicKey = creds.publicKey;

            // Initialize the stripeHandler
            stripeHandler = new stripeHandler(secretKey, publicKey);
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
                if (parts.Length == 3)
                {
                    string name = parts[0].Trim();
                    string dcid = parts[1].Trim();
                    string stripeAcctId = parts[2].Trim();
                    instructors.Add(new Instructor(name, dcid, stripeAcctId));

                }
                // Add error handling if needed for invalid lines
                else
                {
                    // Check what we are missing
                    bool[] conditions = { parts.Length > 0, parts.Length > 1, parts.Length > 2 };
                    string[] fieldNames = { "Name", "DCID", "Stripe Account ID" };

                    // Collect missing fields
                    List<string> missingFields = new List<string>();
                    for (int i = 0; i < conditions.Length; i++)
                    {
                        if (!conditions[i])
                        {
                            missingFields.Add(fieldNames[i]);
                        }
                    }

                    // Print out the error message based on what is missing
                    if (missingFields.Count > 0)
                    {
                        string errorMessage = "Fatal Error: Invalid line in Instructors.txt! Missing: " + string.Join(", ", missingFields) + " at line: \n\n" + line + "\n\nThe program will now exit.";
                        Console.WriteLine(errorMessage);
                        MessageBox.Show(errorMessage, "Parsing Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(1);
                    }
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
                else
                {
                    // Check what we are missing
                    bool[] conditions = { parts.Length > 0, parts.Length > 1 };
                    string[] fieldNames = { "Name", "Student ID" };

                    // Collect missing fields
                    List<string> missingFields = new List<string>();
                    for (int i = 0; i < conditions.Length; i++)
                    {
                        if (!conditions[i])
                        {
                            missingFields.Add(fieldNames[i]);
                        }
                    }

                    // Print out the error message based on what is missing
                    if (missingFields.Count > 0)
                    {
                        string errorMessage = "Fatal Error: Invalid line in Students.txt! Missing: " + string.Join(", ", missingFields) + " at line: \n\n" + line + "\n\nThe program will now exit.";
                        Console.WriteLine(errorMessage);
                        MessageBox.Show(errorMessage, "Parsing Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return students;
        }
    }
}

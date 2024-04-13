using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeshifterStudioPaymentCalculator
{
    internal class Instructor : Individual
    {

        protected int pointsAttributed {  get; set; }
        public string DCID { get; set; }
        //public List<Instructor> instructors = new List<Instructor>();

        //Constructor
        public Instructor(string name, string discordID) : base(name, discordID)
        {
            
        }

        //Methods
        protected void UpdateInstructorPoints()
        {

        }

        //initialize instructorsFromFile



    }
}

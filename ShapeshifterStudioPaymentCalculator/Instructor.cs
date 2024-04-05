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

        //Constructor
        protected Instructor(string name, string discordID) : base(name, discordID)
        {
            
        }

        //Methods
        protected void UpdateInstructorPoints()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeshifterStudioPaymentCalculator
{
    internal class Student : Individual
    {
        protected string FeedBack {  get; set; }
        protected int pointsGiven {  get; set; }

        protected Student(string name, string discordID, string feedBack, int pointsgiven) : base(name, discordID)
        {

        }
        
    }
}

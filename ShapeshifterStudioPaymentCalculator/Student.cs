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

        public Student(string name, string discordID, string feedBack = "", int pointsGiven = 0) : base(name, discordID)
        {
            string FeedBack = feedBack;
            int PointsGiven = pointsGiven;
        }

        public Student(string name, string discordID) : base(name, discordID)
        {
            //string FeedBack = feedBack;
            //int PointsGiven = pointsGiven;
            string Name = name;
            string DiscordID = discordID;
        }
    }
}

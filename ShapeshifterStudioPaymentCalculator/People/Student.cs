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
            string Name = name;
            string DiscordID = discordID;
        }
    }
}

namespace ShapeshifterStudioPaymentCalculator
{
    internal class Instructor : Individual
    {
        protected int pointsAttributed { get; set; }
        public string DCID { get; set; }
        
        public string StripeAccountId { get; set; }

        //Constructor
        public Instructor(string name, string discordID, string stripeId) : base(name, discordID)
        {
            DCID = discordID;
            StripeAccountId = stripeId;
        }
    }
}

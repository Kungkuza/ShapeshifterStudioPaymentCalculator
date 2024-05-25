namespace ShapeshifterStudioPaymentCalculator
{
    internal abstract class Individual
    {
        public string Name { get; private set; }
        public string DiscordID { get; private set; }

        protected Individual(string name, string discordID)
        {
            Name = name;
            DiscordID = discordID;
        }
    }
}

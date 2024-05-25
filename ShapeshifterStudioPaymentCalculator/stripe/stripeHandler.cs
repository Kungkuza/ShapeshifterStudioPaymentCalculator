using Stripe;
using System;

namespace ShapeshifterStudioPaymentCalculator.stripe
{
    public class stripeHandler
    {

        private protected string stripeKey { get; set; }
        private protected string stripePrivateKey { get; set; }
        private protected RequestOptions requestOptions { get; set; }


        // Create our basic constructor
        public stripeHandler(string stripeKey, string privateStripeKey)
        {
            // Set the stripeKey to the provided key
            this.stripeKey = stripeKey;
            this.stripePrivateKey = privateStripeKey;

            // And configure the Stripe API key in stripe.net's global configuration and RequestOptions
            StripeConfiguration.ApiKey = stripeKey;
            requestOptions = new RequestOptions
            {
                ApiKey = stripeKey
            };
        }

        /// <summary>
        /// Sends a payout to the specified instructor, in usd
        /// </summary>
        /// <param name="instructorAccountId">The instructor's account id. Prefixed with acct_</param>
        /// <param name="amount">The amount to send, in cents.</param>
        /// <returns>A Transfer object if successful, or throws a StripeException</returns>
        public Transfer PayoutToInstructor(string instructorAccountId, int amount)
        {
            // Create a Transfer to the specified instructor
            TransferCreateOptions options = new TransferCreateOptions
            {
                Amount = amount,
                Currency = "usd",
                Destination = instructorAccountId
            };
            
            // Create a new TransferService and call the Create method
            TransferService service = new TransferService();
            try
            {
                return service.Create(options, requestOptions);
            } catch (StripeException e) // This throws an exception if the transfer fails (i.e. the instructor's account is not connected to Stripe, insufficient funds, etc.)
            {
                throw e;
            }
        }

        /// <summary>
        /// Converts a float amount to cents for Stripe to process
        /// </summary>
        /// <param name="amount">The amount in USD. e.g 4.20</param>
        /// <returns>Provided amount in cents.</returns>
        public int ToStripeAmount(decimal amount)
        {
            // Stripe uses cents, so we multiply by 100 and round to the nearest integer
            return (int) Math.Round(amount * 100);
        }
    }
}

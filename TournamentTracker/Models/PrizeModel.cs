namespace TournamentTracker.Models
{
    /// <summary>
    /// Represents Prize for the Rankings.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// An override constructor which Sanitizes the data.
        /// </summary>
        /// <param name="placeNumber">Rank of Team.</param>
        /// <param name="placeName">Specific Name of the Rank.</param>
        /// <param name="prizeAmount">Amount of Prize the Rank will get.</param>
        /// <param name="prizePercentage">Amount of Percentage the Rank will get.</param>
        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);


            PlaceNumber = placeNumberValue;
            PlaceName = placeName;
            PrizeAmount = prizeAmountValue;
            PrizePercentage = prizePercentageValue;
        }

        public PrizeModel()
        {

        }



        /// <summary>
        /// Unique Identifier for the price.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the Rank of the team.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Custom Name for the Rank.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Prize of the Rank in which the team finishes in.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Prize in % of the Rank in which the team finishes in.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}

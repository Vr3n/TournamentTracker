using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker
{
    public class PrizeModel
    {
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

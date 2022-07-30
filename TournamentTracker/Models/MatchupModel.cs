using System.Collections.Generic;

namespace TournamentTracker.Models
{
    /// <summary>
    /// Represent Matchups between team.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Represents The Team and its information such as,
        /// TeamName, Score. 
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Winner of the Matchup.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Round number of the Matchup.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}

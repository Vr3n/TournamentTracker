using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker
{
    /// <summary>
    /// Represents the Entries of Matchup
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one Team in the Matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for the team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup this team came from. 
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}

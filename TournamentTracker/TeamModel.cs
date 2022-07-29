using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker
{
    /// <summary>
    /// Represents a Team.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// List of Team members present in the Team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Represents the name of the Team.
        /// </summary>
        public string TeamName { get; set; }
    }
}

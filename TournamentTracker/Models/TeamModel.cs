using System.Collections.Generic;

namespace TournamentTracker.Models
{
    /// <summary>
    /// Represents a Team.
    /// </summary>
    public class TeamModel
    {

        /// <summary>
        /// Represents Unique Identity of Team.
        /// </summary>
        public int Id { get; set; }

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

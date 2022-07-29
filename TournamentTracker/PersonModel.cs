using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker
{
    /// <summary>
    /// Represents a Person / Team member.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// First name of the person / team member.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the person / team member.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email Address of the person / team member.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Phone Number of the person / team member.
        /// </summary>
        public string CellPhoneNumber { get; set; }
    }
}

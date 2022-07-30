namespace TournamentTracker.Models
{
    /// <summary>
    /// Represents a Person / Team member.
    /// </summary>
    public class PersonModel
    {


        /// <summary>
        /// Unique Identifier for the Person.
        /// </summary>
        public int Id { get; set; }

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

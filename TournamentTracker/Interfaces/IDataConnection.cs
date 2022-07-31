using System.Collections.Generic;

namespace TournamentTracker.Interfaces
{
    /// <summary>
    /// Interface for DataConnections Creating and Saving the Models / Data.
    /// </summary>
    public interface IDataConnection
    {

        /// <summary>
        /// Save the Prize Model
        /// </summary>
        /// <param name="model">Information of the prize model.</param>
        /// <returns>Saved Prize model with its Id.</returns>
        Models.PrizeModel CreatePrize(Models.PrizeModel model);

        Models.PersonModel CreatePerson(Models.PersonModel model);
        List<Models.PersonModel> GetPerson_All();

        Models.TeamModel CreateTeam(Models.TeamModel model);
    }
}

using TournamentTracker.Interfaces;

namespace TournamentTracker.DataAccess
{
    internal class SqlConnector : IDataConnection
    {
        // TODO: Make the CreatePrize method actually save to the database.

        /// <summary>
        /// Saves a new Prize to the Database.
        /// </summary>
        /// <param name="model">The Prize Information</param>
        /// <returns>The prize information, including the unique identifier.</returns>
        public Models.PrizeModel CreatePrize(Models.PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}

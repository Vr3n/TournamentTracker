using TournamentTracker.Interfaces;

namespace TournamentTracker.DataAccess
{
    internal class TextConnector : IDataConnection
    {

        // TODO: Wire Up the CreatePrize for text files.


        /// <summary>
        /// Saves a new Prize to the TextFile.
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

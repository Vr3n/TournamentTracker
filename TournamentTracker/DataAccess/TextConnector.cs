using TournamentTracker.Interfaces;
using TournamentTracker.DataAccess.TextConnHelper;
using System.Collections.Generic;
using System.Linq;

namespace TournamentTracker.DataAccess
{
    public class TextConnector : IDataConnection
    {

        // Constant File Name of the PrizeModel.
        private const string PrizesFile = "PrizeModels.csv";


        /// <summary>
        /// Saves a new Prize to the TextFile.
        /// </summary>
        /// <param name="model">The Prize Information</param>
        /// <returns>The prize information, including the unique identifier.</returns>
        public Models.PrizeModel CreatePrize(Models.PrizeModel model)
        {
            List<Models.PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}

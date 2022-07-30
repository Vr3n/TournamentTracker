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
        private const string PersonsFile = "PersonsModels.csv";


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

        public Models.PersonModel CreatePerson(Models.PersonModel model)
        {
            List<Models.PersonModel> persons = PrizesFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentId = 1;

            if (persons.Count > 0)
            {
                currentId = persons.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            persons.Add(model);

            persons.SaveToPersonFile(PersonsFile);

            return model;
        }

    }
}

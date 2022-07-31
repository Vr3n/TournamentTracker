using TournamentTracker.Interfaces;
using TournamentTracker.DataAccess.TextConnHelper;
using System.Collections.Generic;
using System.Linq;
using TournamentTracker.Models;

namespace TournamentTracker.DataAccess
{
    public class TextConnector : IDataConnection
    {

        // Constant File Name of the PrizeModel.
        private const string PrizesFile = "PrizeModels.csv";
        private const string PersonsFile = "PersonsModels.csv";
        private const string TeamsFile = "TeamsModels.csv";


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

        /// <summary>
        /// Save New Person in Text file.
        /// </summary>
        /// <param name="model">Person Model Data</param>
        /// <returns>Data Saved in Person Model.</returns>
        public Models.PersonModel CreatePerson(Models.PersonModel model)
        {
            List<Models.PersonModel> persons = PersonsFile.FullFilePath().LoadFile().ConvertToPersonModels();

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

        /// <summary>
        /// Helper method to get all the Persons data in text file.
        /// </summary>
        /// <returns>List of all persons in text file.</returns>
        public List<PersonModel> GetPerson_All()
        {
            return PersonsFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels(PersonsFile);

            int currentId = 1;

            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamFile(TeamsFile);

            return model;
        }
    }
}

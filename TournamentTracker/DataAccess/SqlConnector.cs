using Dapper;
using System.Data;
using TournamentTracker.Interfaces;

namespace TournamentTracker.DataAccess
{
    internal class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Saves a new Prize to the Database.
        /// </summary>
        /// <param name="model">The Prize Information</param>
        /// <returns>The prize information, including the unique identifier.</returns>
        public Models.PrizeModel CreatePrize(Models.PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }


        /// <summary>
        /// Saves Create Person Model.
        /// </summary>
        /// <param name="model">Person Model Data</param>
        /// <returns>Current Saved Data.</returns>
        public Models.PersonModel CreatePerson(Models.PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellPhoneNumber", model.CellPhoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPersons_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }

        }

    }
}

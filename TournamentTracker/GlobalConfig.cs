using System.Collections.Generic;
using TournamentTracker.Interfaces;
using TournamentTracker.DataAccess;
using System.Configuration;

namespace TournamentTracker
{
    /// <summary>
    /// Consists of Configs related to the Database Connections.
    /// </summary>
    public static class GlobalConfig
    {

        /// <summary>
        /// List of Database Connections.
        /// Stores Which type of Connections you want to implement.
        /// </summary>
        public static IDataConnection Connections { get; private set; }


        /// <summary>
        /// Initializing the Database Connection.
        /// </summary>
        /// <param name="db">Choose from SQL or TEXTFILE enum</param>
        public static void InitializeConnections(DatabaseType db)
        {
            switch (db)
            {
                case DatabaseType.SQL:

                    // TODO: Set up the SQL Connector Properly.
                    SqlConnector sql = new SqlConnector();
                    Connections = sql;
                    break;

                case DatabaseType.TEXTFILE:

                    // TODO: Create the Text Connection.
                    TextConnector text = new TextConnector();
                    Connections = text;
                    break;

                default:
                    break;
            }
        }

        public static string ConnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}

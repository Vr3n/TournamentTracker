using System.Collections.Generic;
using TournamentTracker.Interfaces;
using TournamentTracker.DataAccess;


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
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();


        /// <summary>
        /// Initializing the Database Connection.
        /// </summary>
        /// <param name="database">True if you want to use database</param>
        /// <param name="textFiles">True if you want to use text file</param>
        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO: Set up the SQL Connector Properly.
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                // TODO: Create the Text Connection.
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace TournamentTrackerUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize The database connections.
            TournamentTracker.GlobalConfig.InitializeConnections(TournamentTracker.DatabaseType.TEXTFILE);

            Application.Run(new CreatePrizeForm());
            // Application.Run(new TournamentDashboardForm());
        }
    }
}

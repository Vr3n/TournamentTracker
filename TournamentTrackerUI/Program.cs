using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            TournamentTracker.GlobalConfig.InitializeConnections(true, true);

            Application.Run(new CreatePrizeForm());
            // Application.Run(new TournamentDashboardForm());
        }
    }
}

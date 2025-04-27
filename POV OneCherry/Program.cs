using System.Data.SqlClient;

namespace POV_OneCherry
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            DBC.nombre = "BAN03";
            DBC.DB = "PruebaPOS";
            ApplicationConfiguration.Initialize();
            Application.Run(new PrimerPantallaLogin());

        }
    }
}
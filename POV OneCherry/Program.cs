using DocumentFormat.OpenXml.Packaging;
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
            DBC.nombre = "localhost";
            DBC.DB = "TiendaDeRegalos";
            ApplicationConfiguration.Initialize();
            Application.Run(new PrimerPantallaLogin());

        }
    }
}
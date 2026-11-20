using DAL;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace HotelManagement_core
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
            DbConnectionFactory.Initialize(ConfigurationManager.ConnectionStrings["MyHotel"].ConnectionString);
            var db = DbConnectionFactory.Create();
            db.Database.Migrate();
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmRegister());
        }
    }
}
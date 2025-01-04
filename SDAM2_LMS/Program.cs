using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SDAM2_LMS.Models;
using SDAM2_LMS.Models.Data;

namespace SDAM2_LMS
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
            ApplicationConfiguration.Initialize();

            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optionsBuilder.UseSqlite("Data Source=./Models/Data/LibraryManagement.db");

            using (var context = new DatabaseContext(optionsBuilder.Options))
            {
                context.Database.Migrate();
            }

            Application.Run(new LoginPage());
        }
    }
}
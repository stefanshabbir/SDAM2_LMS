using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SDAM2_LMS.Controllers;
using SDAM2_LMS.Models;
using SDAM2_LMS.Models.Data;
using SDAM2_LMS.Models.Services;
using SDAM2_LMS.Views;

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

            var serviceProvider = ConfigureServices();

            var loginPage = serviceProvider.GetRequiredService<LoginPage>();
            Application.Run(loginPage);
        }

        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<DatabaseContext>();

            services.AddSingleton<AuthenticationController>();
            services.AddSingleton<BookController>();
            services.AddSingleton<UsersController>();
            services.AddSingleton<ProfileController>();
            services.AddSingleton<BorrowController>();

            services.AddSingleton<AccountService>();
            services.AddSingleton<BookService>();
            services.AddSingleton<UsersService>();

            services.AddTransient<LoginPage>();
            services.AddTransient<AdminDashboard>();
            services.AddTransient<LibrarianDashboard>();
            services.AddTransient<MemberDashboard>();
            services.AddTransient<ViewProfile>();
            services.AddTransient<ViewBooks>();
            services.AddTransient<ManageBooks>();
            services.AddTransient<ManageUsers>();
            services.AddTransient<ManageReservations>();
            services.AddTransient<BorrowedReservedBooks>();
            services.AddTransient<AddUser>();

            return services.BuildServiceProvider();
        }
    }
}
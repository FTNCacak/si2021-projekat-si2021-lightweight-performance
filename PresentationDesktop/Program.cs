using BusinessLayer;
using DataLayer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Interfaces;
using System;
using System.Windows.Forms;

namespace PresentationDesktop
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<ICheckinBusiness, CheckinBusiness>();
            services.AddTransient<ICheckinRepository, CheckinRepository>();
            services.AddTransient<IEmployeeBusiness, EmployeeBusiness>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IMembershipBusiness, MembershipBusiness>();
            services.AddTransient<IMembershipRepository, MembershipRepository>();
            services.AddTransient<ITrainingBusiness, TrainingBusiness>();
            services.AddTransient<ITrainingRepository, TrainingRepository>();
            ServiceProvider = services.BuildServiceProvider();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfigureServices();
            Application.Run(new Login());
        }
    }
}

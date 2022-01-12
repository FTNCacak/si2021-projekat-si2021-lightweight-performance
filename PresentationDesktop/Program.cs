using BusinessLayer;
using DataLayer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationDesktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        /*
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var login = serviceProvider.GetRequiredService<Login>();
                Application.Run(login);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<ICheckinBusiness, CheckinBusiness>();
            services.AddScoped<ICheckinRepository, CheckinRepository>();
            services.AddScoped<IEmployeeBusiness, EmployeeBusiness>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IMembershipBusiness, MembershipBusiness>();
            services.AddScoped<IMembershipRepository, MembershipRepository>();
            services.AddScoped<ITrainingBusiness, TrainingBusiness>();
            services.AddScoped<ITrainingRepository, TrainingRepository>();
            services.AddScoped<Login>();
            services.AddScoped<Terminal>();
            services.AddScoped<NewMember>();
            services.AddScoped<UpdateMembership>();
            services.AddScoped<PersonalTraining>();
            services.AddScoped<MembershipInfo>();
        }
        */
    }
}

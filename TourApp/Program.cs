using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourApp.Context;
using TourApp.Repository;
using TourApp.Repository.IRepository;

namespace TourApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);
            using(ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<FormTest>();
                Application.Run(form1);
            }
            
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<TourContext>();
            services.AddScoped<FormTest>();
            services.AddScoped<ThongTinTour>();
            services.AddScoped<ThemTour>();
            services.AddScoped<IChiTieuRepository, ChiTieuRepository>();
            services.AddScoped<ITourRepository, TourRepository>();
            services.AddScoped<IDiaDiemRepository, DiaDiemRepository>();
            services.AddScoped<IGiaRepository, GiaRepository>();
            services.AddScoped<ICTTourRepository, CTTourRepository>();
        }
    }
}

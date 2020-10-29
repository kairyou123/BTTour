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
        public static List Form;
        public static FormTest Form1;
<<<<<<< HEAD
 
=======
        public static SuaTour SuaTour;
>>>>>>> 72bc4a3709a534c67549fce8cab9c46213b02055
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
                Form = serviceProvider.GetRequiredService<List>();
                Form1 = serviceProvider.GetRequiredService<FormTest>();
                Application.Run(Form);
            }
            
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<TourContext>();
            services.AddTransient<FormTest>();
            services.AddTransient<ThongTinTour>();
            services.AddTransient<ThemTour>();
            services.AddTransient<SuaTour>();
            services.AddTransient<List>();
            services.AddTransient<ThemGia>();
            services.AddTransient<HanhKhach_Form>();
            services.AddTransient<DoanKhach_Form>();
            services.AddTransient<SearchForm>();
            services.AddScoped<IChiTieuRepository, ChiTieuRepository>();
            services.AddScoped<ITourRepository, TourRepository>();
            services.AddScoped<IDiaDiemRepository, DiaDiemRepository>();
            services.AddScoped<IGiaRepository, GiaRepository>();
            services.AddScoped<ICTTourRepository, CTTourRepository>();
            services.AddScoped<IHanhKhachRepository, HanhKhachRepository>();
            services.AddScoped<IDoanKhachRepository, DoanKhachRepository>();
            services.AddScoped<INhanVienRepository, NhanVienRepository>();
        }
    }
}

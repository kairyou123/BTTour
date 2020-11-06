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
            services.AddTransient<NhanVienAdd>();
            services.AddTransient<FormTest>();
            services.AddTransient<ThongTinTour>();
            services.AddTransient<ThemTour>();
            services.AddTransient<SuaTour>();
            services.AddTransient<List>();
            services.AddTransient<ThemGia>();
            services.AddTransient<ThemChiTieu>();
            services.AddTransient<DanhSachDoanKhach>();
            services.AddTransient<HanhKhach_Form>();
            services.AddTransient<DoanKhach_Form>();
            services.AddTransient<SearchForm>();
            services.AddTransient<NhanVienAdd>();
            services.AddTransient<TKChiPhi_Form>();
            services.AddTransient<TKDoanhThu_Form>();
            services.AddTransient<TKTinhHinhHoatDong>();
            services.AddTransient<TK_NhanVienTour>();
            services.AddScoped<IChiTieuRepository, ChiTieuRepository>();
            services.AddScoped<ITourRepository, TourRepository>();
            services.AddScoped<IDiaDiemRepository, DiaDiemRepository>();
            services.AddScoped<IGiaRepository, GiaRepository>();
            services.AddScoped<ICTTourRepository, CTTourRepository>();
            services.AddScoped<IHanhKhachRepository, HanhKhachRepository>();
            services.AddScoped<IDoanKhachRepository, DoanKhachRepository>();
            services.AddScoped<INhanVienRepository, NhanVienRepository>();
            services.AddScoped<ILoaiHinhDuLichRepository, LoaiHinhDuLichRepository>();

        }
    }
}

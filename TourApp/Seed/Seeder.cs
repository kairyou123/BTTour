using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TourApp.Entity;

namespace TourApp.Seed
{
    public static class Seeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiaDiem>().HasData(
                new DiaDiem
                {
                    DDId = 1,
                    TenDD = "Đà Nẵng",
                },
                new DiaDiem
                {
                    DDId = 2,
                    TenDD = "TP. Hồ Chí Minh",
                }
            );
            modelBuilder.Entity<LoaiHinhDL>().HasData(
                new LoaiHinhDL
                {
                    LHDLId = 1,
                    Ten = "Loại Hình 1",
                    moTa = "ABCXYZ",
                }
            );


            modelBuilder.Entity<Tour>().HasData(
                new Tour
                {
                    TourId = 1,
                    MaTour = "T100001",
                    Ten = "Tour1",
                    LHDLId = 1,
                }
            );
            modelBuilder.Entity<Gia>().HasData(
                new Gia
                {
                    GiaId = 1,
                    GiaTri = 100000,
                    TourId = 1,
                    TGBD = new DateTime()
                }
            );
            modelBuilder.Entity<CTTour>().HasData(
                new CTTour
                {
                    TourId = 1,
                    DDId = 1,
                },
                new CTTour
                {
                    TourId = 1,
                    DDId = 2,
                }
            );
        }
    }
}
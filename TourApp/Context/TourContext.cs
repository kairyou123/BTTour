using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TourApp.Entity;
using TourApp.Seed;

namespace TourApp.Context
{
    public class TourContext : DbContext
    {
        public TourContext() : base()
        {
           
        }

        public DbSet<Tour> Tours { set; get; }
        public DbSet<NhanVien> NhanViens { set; get; }
        public DbSet<NV_VT> NV_VTs { set; get; }
        public DbSet<CTTour> CTTours { set; get; }
        public DbSet<Gia> Gias { set; get; }
        public DbSet<DiaDiem> DiaDiems { set; get; }
        public DbSet<HanhKhach> HanhKhachs { set; get; }
        public DbSet<DoanKhach> DoanKhachs { set; get; }
        public DbSet<CTDoan> CTDoans { set; get; }
        public DbSet<CTChitieu> CTChiTieus { set; get; }
        public DbSet<ChiTieu> ChiTieus { set; get; }
        public DbSet<LoaiHinhDL> LoaiHinhDLs { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-1I87EAD;Initial Catalog=TourApp;Integrated Security=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CTChitieu>().HasKey(c => new { c.CTId, c.DoanId });

            modelBuilder.Entity<CTChitieu>()
            .HasOne<ChiTieu>(c => c.ChiTieu)
            .WithMany(c => c.CTChitieus)
            .HasForeignKey(c => c.CTId);

            modelBuilder.Entity<CTChitieu>()
            .HasOne<DoanKhach>(c => c.DoanKhach)
            .WithMany(c => c.CTChitieus)
            .HasForeignKey(c => c.DoanId);


            modelBuilder.Entity<CTDoan>().HasKey(c => new { c.DoanId, c.KhachId });

            modelBuilder.Entity<CTDoan>()
            .HasOne<DoanKhach>(c => c.DoanKhach)
            .WithMany(c => c.CTDoans)
            .HasForeignKey(c => c.DoanId);

            modelBuilder.Entity<CTDoan>()
            .HasOne<HanhKhach>(c => c.HanhKhach)
            .WithMany(c => c.CTDoans)
            .HasForeignKey(c => c.KhachId);

            modelBuilder.Entity<CTTour>().HasKey(c => new { c.TourId, c.DDId });

            modelBuilder.Entity<CTTour>()
            .HasOne<Tour>(c => c.Tour)
            .WithMany(c => c.CTTours)
            .HasForeignKey(c => c.TourId);

            modelBuilder.Entity<CTTour>()
            .HasOne<DiaDiem>(c => c.DiaDiem)
            .WithMany(c => c.CTTours)
            .HasForeignKey(c => c.DDId);

            modelBuilder.Entity<NV_VT>().HasKey(c => new { c.DoanId, c.NVId });

            modelBuilder.Entity<NV_VT>()
            .HasOne<DoanKhach>(c => c.DoanKhach)
            .WithMany(c => c.NV_VTs)
            .HasForeignKey(c => c.DoanId);

            modelBuilder.Entity<NV_VT>()
            .HasOne<NhanVien>(c => c.NhanVien)
            .WithMany(c => c.NV_VTs)
            .HasForeignKey(c => c.NVId);

            modelBuilder.Seed();
        }
    }
}

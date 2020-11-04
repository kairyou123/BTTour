﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TourApp.Context;

namespace TourApp.Migrations
{
    [DbContext(typeof(TourContext))]
    partial class TourContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("TourApp.Entity.CTChitieu", b =>
                {
                    b.Property<int>("CTId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DoanId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TienCT")
                        .HasColumnType("TEXT");

                    b.HasKey("CTId", "DoanId");

                    b.HasIndex("DoanId");

                    b.ToTable("CTChiTieus");
                });

            modelBuilder.Entity("TourApp.Entity.CTDoan", b =>
                {
                    b.Property<int>("DoanId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KhachId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DoanId", "KhachId");

                    b.HasIndex("KhachId");

                    b.ToTable("CTDoans");
                });

            modelBuilder.Entity("TourApp.Entity.CTTour", b =>
                {
                    b.Property<int>("TourId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DDId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ThongTin")
                        .HasColumnType("TEXT");

                    b.HasKey("TourId", "DDId");

                    b.HasIndex("DDId");

                    b.ToTable("CTTours");

                    b.HasData(
                        new
                        {
                            TourId = 1,
                            DDId = 1
                        },
                        new
                        {
                            TourId = 1,
                            DDId = 2
                        });
                });

            modelBuilder.Entity("TourApp.Entity.ChiTieu", b =>
                {
                    b.Property<int>("CTId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ten")
                        .HasColumnType("TEXT");

                    b.HasKey("CTId");

                    b.ToTable("ChiTieus");
                });

            modelBuilder.Entity("TourApp.Entity.DiaDiem", b =>
                {
                    b.Property<int>("DDId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenDD")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("isDeleted")
                        .HasColumnType("INTEGER");

                    b.HasKey("DDId");

                    b.ToTable("DiaDiems");

                    b.HasData(
                        new
                        {
                            DDId = 1,
                            TenDD = "Đà Nẵng",
                            isDeleted = 0
                        },
                        new
                        {
                            DDId = 2,
                            TenDD = "TP. Hồ Chí Minh",
                            isDeleted = 0
                        });
                });

            modelBuilder.Entity("TourApp.Entity.DoanKhach", b =>
                {
                    b.Property<int>("DoanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Chitiet")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaDoan")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenDoan")
                        .HasColumnType("TEXT");

                    b.Property<int>("TourId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("isDeleted")
                        .HasColumnType("INTEGER");

                    b.HasKey("DoanId");

                    b.HasIndex("TourId");

                    b.ToTable("DoanKhachs");
                });

            modelBuilder.Entity("TourApp.Entity.Gia", b =>
                {
                    b.Property<int>("GiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GiaTri")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TGBD")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TGKT")
                        .HasColumnType("TEXT");

                    b.Property<int>("TourId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GiaId");

                    b.HasIndex("TourId");

                    b.ToTable("Gias");

                    b.HasData(
                        new
                        {
                            GiaId = 1,
                            GiaTri = 100000,
                            TGBD = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TGKT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TourId = 1
                        });
                });

            modelBuilder.Entity("TourApp.Entity.HanhKhach", b =>
                {
                    b.Property<int>("KhachId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CMND")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiaChi")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("GioiTinh")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaKhach")
                        .HasColumnType("TEXT");

                    b.Property<string>("Passport")
                        .HasColumnType("TEXT");

                    b.Property<string>("SDT")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ten")
                        .HasColumnType("TEXT");

                    b.Property<int>("isDeleted")
                        .HasColumnType("INTEGER");

                    b.HasKey("KhachId");

                    b.ToTable("HanhKhachs");
                });

            modelBuilder.Entity("TourApp.Entity.LoaiHinhDL", b =>
                {
                    b.Property<int>("LHDLId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("moTa")
                        .HasColumnType("TEXT");

                    b.HasKey("LHDLId");

                    b.ToTable("LoaiHinhDLs");

                    b.HasData(
                        new
                        {
                            LHDLId = 1,
                            Ten = "Loại Hình 1",
                            moTa = "ABCXYZ"
                        });
                });

            modelBuilder.Entity("TourApp.Entity.NV_VT", b =>
                {
                    b.Property<int>("DoanId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NVId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ViTri")
                        .HasColumnType("TEXT");

                    b.HasKey("DoanId", "NVId");

                    b.HasIndex("NVId");

                    b.ToTable("NV_VTs");
                });

            modelBuilder.Entity("TourApp.Entity.NhanVien", b =>
                {
                    b.Property<int>("NVId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaNV")
                        .HasColumnType("TEXT");

                    b.Property<string>("SDT")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ten")
                        .HasColumnType("TEXT");

                    b.Property<int>("isDeleted")
                        .HasColumnType("INTEGER");

                    b.HasKey("NVId");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("TourApp.Entity.Tour", b =>
                {
                    b.Property<int>("TourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("LHDLId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaTour")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("isDeleted")
                        .HasColumnType("INTEGER");

                    b.HasKey("TourId");

                    b.HasIndex("LHDLId");

                    b.ToTable("Tours");

                    b.HasData(
                        new
                        {
                            TourId = 1,
                            LHDLId = 1,
                            MaTour = "T100001",
                            Ten = "Tour1",
                            isDeleted = 0
                        });
                });

            modelBuilder.Entity("TourApp.Entity.CTChitieu", b =>
                {
                    b.HasOne("TourApp.Entity.ChiTieu", "ChiTieu")
                        .WithMany("CTChitieus")
                        .HasForeignKey("CTId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TourApp.Entity.DoanKhach", "DoanKhach")
                        .WithMany("CTChitieus")
                        .HasForeignKey("DoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TourApp.Entity.CTDoan", b =>
                {
                    b.HasOne("TourApp.Entity.DoanKhach", "DoanKhach")
                        .WithMany("CTDoans")
                        .HasForeignKey("DoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TourApp.Entity.HanhKhach", "HanhKhach")
                        .WithMany("CTDoans")
                        .HasForeignKey("KhachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TourApp.Entity.CTTour", b =>
                {
                    b.HasOne("TourApp.Entity.DiaDiem", "DiaDiem")
                        .WithMany("CTTours")
                        .HasForeignKey("DDId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TourApp.Entity.Tour", "Tour")
                        .WithMany("CTTours")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TourApp.Entity.DoanKhach", b =>
                {
                    b.HasOne("TourApp.Entity.Tour", "Tour")
                        .WithMany("DoanKhachs")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TourApp.Entity.Gia", b =>
                {
                    b.HasOne("TourApp.Entity.Tour", "Tour")
                        .WithMany("Gias")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TourApp.Entity.NV_VT", b =>
                {
                    b.HasOne("TourApp.Entity.DoanKhach", "DoanKhach")
                        .WithMany("NV_VTs")
                        .HasForeignKey("DoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TourApp.Entity.NhanVien", "NhanVien")
                        .WithMany("NV_VTs")
                        .HasForeignKey("NVId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TourApp.Entity.Tour", b =>
                {
                    b.HasOne("TourApp.Entity.LoaiHinhDL", "LHDL")
                        .WithMany("Tours")
                        .HasForeignKey("LHDLId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

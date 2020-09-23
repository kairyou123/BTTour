using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TourApp.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiTieus",
                columns: table => new
                {
                    CTId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTieus", x => x.CTId);
                });

            migrationBuilder.CreateTable(
                name: "DiaDiems",
                columns: table => new
                {
                    DDId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDD = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaDiems", x => x.DDId);
                });

            migrationBuilder.CreateTable(
                name: "HanhKhachs",
                columns: table => new
                {
                    KhachId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKhach = table.Column<string>(nullable: true),
                    Ten = table.Column<string>(nullable: true),
                    SDT = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HanhKhachs", x => x.KhachId);
                });

            migrationBuilder.CreateTable(
                name: "LoaiHinhDLs",
                columns: table => new
                {
                    LHDLId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: false),
                    moTa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiHinhDLs", x => x.LHDLId);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    NVId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNV = table.Column<string>(nullable: true),
                    Ten = table.Column<string>(nullable: true),
                    SDT = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.NVId);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    TourId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTour = table.Column<string>(nullable: false),
                    Ten = table.Column<string>(nullable: false),
                    LHDLId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.TourId);
                    table.ForeignKey(
                        name: "FK_Tours_LoaiHinhDLs_LHDLId",
                        column: x => x.LHDLId,
                        principalTable: "LoaiHinhDLs",
                        principalColumn: "LHDLId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CTTours",
                columns: table => new
                {
                    TourId = table.Column<int>(nullable: false),
                    DDId = table.Column<int>(nullable: false),
                    ThongTin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTTours", x => new { x.TourId, x.DDId });
                    table.ForeignKey(
                        name: "FK_CTTours_DiaDiems_DDId",
                        column: x => x.DDId,
                        principalTable: "DiaDiems",
                        principalColumn: "DDId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTTours_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoanKhachs",
                columns: table => new
                {
                    DoanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDoan = table.Column<string>(nullable: true),
                    TenDoan = table.Column<string>(nullable: true),
                    Chitiet = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    TourId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoanKhachs", x => x.DoanId);
                    table.ForeignKey(
                        name: "FK_DoanKhachs_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gias",
                columns: table => new
                {
                    GiaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiaTri = table.Column<int>(nullable: false),
                    TGBD = table.Column<DateTime>(nullable: false),
                    TGKT = table.Column<DateTime>(nullable: false),
                    TourId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gias", x => x.GiaId);
                    table.ForeignKey(
                        name: "FK_Gias_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CTChiTieus",
                columns: table => new
                {
                    CTId = table.Column<int>(nullable: false),
                    DoanId = table.Column<int>(nullable: false),
                    TienCT = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTChiTieus", x => new { x.CTId, x.DoanId });
                    table.ForeignKey(
                        name: "FK_CTChiTieus_ChiTieus_CTId",
                        column: x => x.CTId,
                        principalTable: "ChiTieus",
                        principalColumn: "CTId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTChiTieus_DoanKhachs_DoanId",
                        column: x => x.DoanId,
                        principalTable: "DoanKhachs",
                        principalColumn: "DoanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CTDoans",
                columns: table => new
                {
                    DoanId = table.Column<int>(nullable: false),
                    KhachId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTDoans", x => new { x.DoanId, x.KhachId });
                    table.ForeignKey(
                        name: "FK_CTDoans_DoanKhachs_DoanId",
                        column: x => x.DoanId,
                        principalTable: "DoanKhachs",
                        principalColumn: "DoanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTDoans_HanhKhachs_KhachId",
                        column: x => x.KhachId,
                        principalTable: "HanhKhachs",
                        principalColumn: "KhachId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NV_VTs",
                columns: table => new
                {
                    DoanId = table.Column<int>(nullable: false),
                    NVId = table.Column<int>(nullable: false),
                    ViTri = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NV_VTs", x => new { x.DoanId, x.NVId });
                    table.ForeignKey(
                        name: "FK_NV_VTs_DoanKhachs_DoanId",
                        column: x => x.DoanId,
                        principalTable: "DoanKhachs",
                        principalColumn: "DoanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NV_VTs_NhanViens_NVId",
                        column: x => x.NVId,
                        principalTable: "NhanViens",
                        principalColumn: "NVId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CTChiTieus_DoanId",
                table: "CTChiTieus",
                column: "DoanId");

            migrationBuilder.CreateIndex(
                name: "IX_CTDoans_KhachId",
                table: "CTDoans",
                column: "KhachId");

            migrationBuilder.CreateIndex(
                name: "IX_CTTours_DDId",
                table: "CTTours",
                column: "DDId");

            migrationBuilder.CreateIndex(
                name: "IX_DoanKhachs_TourId",
                table: "DoanKhachs",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Gias_TourId",
                table: "Gias",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_NV_VTs_NVId",
                table: "NV_VTs",
                column: "NVId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_LHDLId",
                table: "Tours",
                column: "LHDLId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CTChiTieus");

            migrationBuilder.DropTable(
                name: "CTDoans");

            migrationBuilder.DropTable(
                name: "CTTours");

            migrationBuilder.DropTable(
                name: "Gias");

            migrationBuilder.DropTable(
                name: "NV_VTs");

            migrationBuilder.DropTable(
                name: "ChiTieus");

            migrationBuilder.DropTable(
                name: "HanhKhachs");

            migrationBuilder.DropTable(
                name: "DiaDiems");

            migrationBuilder.DropTable(
                name: "DoanKhachs");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "LoaiHinhDLs");
        }
    }
}

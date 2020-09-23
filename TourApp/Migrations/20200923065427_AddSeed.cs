using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TourApp.Migrations
{
    public partial class AddSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaDiems",
                columns: new[] { "DDId", "TenDD" },
                values: new object[] { 1, "Đà Nẵng" });

            migrationBuilder.InsertData(
                table: "DiaDiems",
                columns: new[] { "DDId", "TenDD" },
                values: new object[] { 2, "TP. Hồ Chí Minh" });

            migrationBuilder.InsertData(
                table: "LoaiHinhDLs",
                columns: new[] { "LHDLId", "Ten", "moTa" },
                values: new object[] { 1, "Loại Hình 1", "ABCXYZ" });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "TourId", "LHDLId", "MaTour", "Ten" },
                values: new object[] { 1, 1, "T100001", "Tour1" });

            migrationBuilder.InsertData(
                table: "CTTours",
                columns: new[] { "TourId", "DDId", "ThongTin" },
                values: new object[] { 1, 1, null });

            migrationBuilder.InsertData(
                table: "CTTours",
                columns: new[] { "TourId", "DDId", "ThongTin" },
                values: new object[] { 1, 2, null });

            migrationBuilder.InsertData(
                table: "Gias",
                columns: new[] { "GiaId", "GiaTri", "TGBD", "TGKT", "TourId" },
                values: new object[] { 1, 100000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CTTours",
                keyColumns: new[] { "TourId", "DDId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CTTours",
                keyColumns: new[] { "TourId", "DDId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Gias",
                keyColumn: "GiaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaDiems",
                keyColumn: "DDId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaDiems",
                keyColumn: "DDId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LoaiHinhDLs",
                keyColumn: "LHDLId",
                keyValue: 1);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TourApp.Migrations
{
    public partial class seeder1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Gias",
                columns: new[] { "GiaId", "GiaTri", "TGBD", "TGKT", "TourId" },
                values: new object[] { 1, 100000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gias",
                keyColumn: "GiaId",
                keyValue: 1);
        }
    }
}

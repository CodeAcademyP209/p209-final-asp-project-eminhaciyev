using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Final_Project_Asbab.Migrations
{
    public partial class Bc9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "OurBlogs",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "OurBlogs",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}

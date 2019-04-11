using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Final_Project_Asbab.Migrations
{
    public partial class DeleteTitlePropInNewArrival : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "NewArrivals");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "NewArrivals",
                maxLength: 400,
                nullable: false,
                defaultValue: "");
        }
    }
}

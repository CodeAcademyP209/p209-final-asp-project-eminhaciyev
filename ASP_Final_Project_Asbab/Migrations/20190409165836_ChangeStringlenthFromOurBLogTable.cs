using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Final_Project_Asbab.Migrations
{
    public partial class ChangeStringlenthFromOurBLogTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "OurBlogs",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "OurBlogs",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}

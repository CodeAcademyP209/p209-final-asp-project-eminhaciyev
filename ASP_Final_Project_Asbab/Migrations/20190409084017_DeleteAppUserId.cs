using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Final_Project_Asbab.Migrations
{
    public partial class DeleteAppUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProducts_AspNetUsers_ApplicationUserId1",
                table: "UserProducts");

            migrationBuilder.DropIndex(
                name: "IX_UserProducts_ApplicationUserId1",
                table: "UserProducts");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "UserProducts");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "UserProducts",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_UserProducts_ApplicationUserId",
                table: "UserProducts",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProducts_AspNetUsers_ApplicationUserId",
                table: "UserProducts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProducts_AspNetUsers_ApplicationUserId",
                table: "UserProducts");

            migrationBuilder.DropIndex(
                name: "IX_UserProducts_ApplicationUserId",
                table: "UserProducts");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "UserProducts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "UserProducts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserProducts_ApplicationUserId1",
                table: "UserProducts",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProducts_AspNetUsers_ApplicationUserId1",
                table: "UserProducts",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

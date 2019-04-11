using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Final_Project_Asbab.Migrations
{
    public partial class BG1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Products_ProductsId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_ProductsId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "Category");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductsId",
                table: "Category",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_ProductsId",
                table: "Category",
                column: "ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Products_ProductsId",
                table: "Category",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

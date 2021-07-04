using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class updatingArticles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "category",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "category",
                table: "Articles");

            migrationBuilder.AddColumn<int>(
                name: "categoryId",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_categoryId",
                table: "Articles",
                column: "categoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_categories_categoryId",
                table: "Articles",
                column: "categoryId",
                principalTable: "categories",
                principalColumn: "categoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_categories_categoryId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_categoryId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "categoryId",
                table: "Articles");

            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

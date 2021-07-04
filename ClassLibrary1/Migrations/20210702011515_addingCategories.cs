using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class addingCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "categoryID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    categoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    categoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.categoryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_categoryID",
                table: "Products",
                column: "categoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_categories_categoryID",
                table: "Products",
                column: "categoryID",
                principalTable: "categories",
                principalColumn: "categoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_categories_categoryID",
                table: "Products");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropIndex(
                name: "IX_Products_categoryID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "categoryID",
                table: "Products");
        }
    }
}

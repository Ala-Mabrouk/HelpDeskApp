using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class updateTickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Products_relatedProductrefId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "relatedProductRef",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "relatedProductrefId",
                table: "Tickets",
                newName: "relatedProductRefId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_relatedProductrefId",
                table: "Tickets",
                newName: "IX_Tickets_relatedProductRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Products_relatedProductRefId",
                table: "Tickets",
                column: "relatedProductRefId",
                principalTable: "Products",
                principalColumn: "refId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Products_relatedProductRefId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "relatedProductRefId",
                table: "Tickets",
                newName: "relatedProductrefId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_relatedProductRefId",
                table: "Tickets",
                newName: "IX_Tickets_relatedProductrefId");

            migrationBuilder.AddColumn<string>(
                name: "relatedProductRef",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Products_relatedProductrefId",
                table: "Tickets",
                column: "relatedProductrefId",
                principalTable: "Products",
                principalColumn: "refId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class addingA_T_Managment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "relatedProductRef",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "relatedProductrefId",
                table: "Tickets",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "A_T_Managments",
                columns: table => new
                {
                    agentId = table.Column<int>(type: "int", nullable: false),
                    ticketId = table.Column<int>(type: "int", nullable: false),
                    dateAssign = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A_T_Managments", x => new { x.agentId, x.ticketId });
                    table.ForeignKey(
                        name: "FK_A_T_Managments_Tickets_ticketId",
                        column: x => x.ticketId,
                        principalTable: "Tickets",
                        principalColumn: "ticketId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_A_T_Managments_Users_agentId",
                        column: x => x.agentId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_relatedProductrefId",
                table: "Tickets",
                column: "relatedProductrefId");

            migrationBuilder.CreateIndex(
                name: "IX_A_T_Managments_ticketId",
                table: "A_T_Managments",
                column: "ticketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Products_relatedProductrefId",
                table: "Tickets",
                column: "relatedProductrefId",
                principalTable: "Products",
                principalColumn: "refId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Products_relatedProductrefId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "A_T_Managments");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_relatedProductrefId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "relatedProductRef",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "relatedProductrefId",
                table: "Tickets");
        }
    }
}

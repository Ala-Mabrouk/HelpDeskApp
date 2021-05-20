using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class addingProductClientRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductClients",
                columns: table => new
                {
                    clientId = table.Column<int>(type: "int", nullable: false),
                    productRef = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    productrefId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductClients", x => new { x.clientId, x.productRef });
                    table.ForeignKey(
                        name: "FK_ProductClients_Products_productrefId",
                        column: x => x.productrefId,
                        principalTable: "Products",
                        principalColumn: "refId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductClients_Users_clientId",
                        column: x => x.clientId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductClients_productrefId",
                table: "ProductClients",
                column: "productrefId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductClients");
        }
    }
}

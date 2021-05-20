using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class addingProductClientRelation_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductClients_Users_clientId",
                table: "ProductClients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductClients",
                table: "ProductClients");

            migrationBuilder.DropIndex(
                name: "IX_ProductClients_clientId",
                table: "ProductClients");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductClients");

            migrationBuilder.AlterColumn<int>(
                name: "clientId",
                table: "ProductClients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductClients",
                table: "ProductClients",
                columns: new[] { "clientId", "refId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductClients_Users_clientId",
                table: "ProductClients",
                column: "clientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductClients_Users_clientId",
                table: "ProductClients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductClients",
                table: "ProductClients");

            migrationBuilder.AlterColumn<int>(
                name: "clientId",
                table: "ProductClients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProductClients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductClients",
                table: "ProductClients",
                columns: new[] { "Id", "refId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductClients_clientId",
                table: "ProductClients",
                column: "clientId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductClients_Users_clientId",
                table: "ProductClients",
                column: "clientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

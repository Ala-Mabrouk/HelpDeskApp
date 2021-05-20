using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class addingProductClientRelationupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductClients_Products_productrefId",
                table: "ProductClients");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductClients_Users_clientId",
                table: "ProductClients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductClients",
                table: "ProductClients");

            migrationBuilder.DropIndex(
                name: "IX_ProductClients_productrefId",
                table: "ProductClients");

            migrationBuilder.DropColumn(
                name: "productrefId",
                table: "ProductClients");

            migrationBuilder.RenameColumn(
                name: "productRef",
                table: "ProductClients",
                newName: "refId");

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductClients_refId",
                table: "ProductClients",
                column: "refId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductClients_Products_refId",
                table: "ProductClients",
                column: "refId",
                principalTable: "Products",
                principalColumn: "refId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductClients_Users_clientId",
                table: "ProductClients",
                column: "clientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductClients_Products_refId",
                table: "ProductClients");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductClients_Users_clientId",
                table: "ProductClients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductClients",
                table: "ProductClients");

            migrationBuilder.DropIndex(
                name: "IX_ProductClients_clientId",
                table: "ProductClients");

            migrationBuilder.DropIndex(
                name: "IX_ProductClients_refId",
                table: "ProductClients");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductClients");

            migrationBuilder.RenameColumn(
                name: "refId",
                table: "ProductClients",
                newName: "productRef");

            migrationBuilder.AlterColumn<int>(
                name: "clientId",
                table: "ProductClients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "productrefId",
                table: "ProductClients",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductClients",
                table: "ProductClients",
                columns: new[] { "clientId", "productRef" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductClients_productrefId",
                table: "ProductClients",
                column: "productrefId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductClients_Products_productrefId",
                table: "ProductClients",
                column: "productrefId",
                principalTable: "Products",
                principalColumn: "refId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductClients_Users_clientId",
                table: "ProductClients",
                column: "clientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

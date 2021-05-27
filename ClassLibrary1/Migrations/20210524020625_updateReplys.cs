using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class updateReplys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Replys_Users_r_agentId",
                table: "Replys");

            migrationBuilder.DropIndex(
                name: "IX_Replys_r_agentId",
                table: "Replys");

            migrationBuilder.DropColumn(
                name: "r_agentId",
                table: "Replys");

            migrationBuilder.CreateIndex(
                name: "IX_Replys_replyOwnerId",
                table: "Replys",
                column: "replyOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Replys_Users_replyOwnerId",
                table: "Replys",
                column: "replyOwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Replys_Users_replyOwnerId",
                table: "Replys");

            migrationBuilder.DropIndex(
                name: "IX_Replys_replyOwnerId",
                table: "Replys");

            migrationBuilder.AddColumn<int>(
                name: "r_agentId",
                table: "Replys",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Replys_r_agentId",
                table: "Replys",
                column: "r_agentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Replys_Users_r_agentId",
                table: "Replys",
                column: "r_agentId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Pongo.BusinessLogic.Migrations
{
    public partial class Migration10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "PongoTable",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PongoTable_UserId",
                table: "PongoTable",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PongoTable_PongoUser_UserId",
                table: "PongoTable",
                column: "UserId",
                principalTable: "PongoUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PongoTable_PongoUser_UserId",
                table: "PongoTable");

            migrationBuilder.DropIndex(
                name: "IX_PongoTable_UserId",
                table: "PongoTable");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PongoTable");
        }
    }
}

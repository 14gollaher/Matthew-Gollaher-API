using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Pongo.BusinessLogic.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TableId",
                table: "Row",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TableId",
                table: "Column",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cell",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RowId = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cell", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cell_Row_RowId",
                        column: x => x.RowId,
                        principalTable: "Row",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Row_TableId",
                table: "Row",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_Column_TableId",
                table: "Column",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_Cell_RowId",
                table: "Cell",
                column: "RowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Column_Table_TableId",
                table: "Column",
                column: "TableId",
                principalTable: "Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Row_Table_TableId",
                table: "Row",
                column: "TableId",
                principalTable: "Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Column_Table_TableId",
                table: "Column");

            migrationBuilder.DropForeignKey(
                name: "FK_Row_Table_TableId",
                table: "Row");

            migrationBuilder.DropTable(
                name: "Cell");

            migrationBuilder.DropIndex(
                name: "IX_Row_TableId",
                table: "Row");

            migrationBuilder.DropIndex(
                name: "IX_Column_TableId",
                table: "Column");

            migrationBuilder.DropColumn(
                name: "TableId",
                table: "Row");

            migrationBuilder.DropColumn(
                name: "TableId",
                table: "Column");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Pongo.BusinessLogic.Migrations
{
    public partial class Migration9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cell_Column_ColumnId",
                table: "Cell");

            migrationBuilder.DropForeignKey(
                name: "FK_Column_Table_TableId",
                table: "Column");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table",
                table: "Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Column",
                table: "Column");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cell",
                table: "Cell");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "PongoUser");

            migrationBuilder.RenameTable(
                name: "Table",
                newName: "PongoTable");

            migrationBuilder.RenameTable(
                name: "Column",
                newName: "PongoColumn");

            migrationBuilder.RenameTable(
                name: "Cell",
                newName: "PongoCell");

            migrationBuilder.RenameIndex(
                name: "IX_Column_TableId",
                table: "PongoColumn",
                newName: "IX_PongoColumn_TableId");

            migrationBuilder.RenameIndex(
                name: "IX_Cell_ColumnId",
                table: "PongoCell",
                newName: "IX_PongoCell_ColumnId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PongoUser",
                table: "PongoUser",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PongoTable",
                table: "PongoTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PongoColumn",
                table: "PongoColumn",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PongoCell",
                table: "PongoCell",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PongoCell_PongoColumn_ColumnId",
                table: "PongoCell",
                column: "ColumnId",
                principalTable: "PongoColumn",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PongoColumn_PongoTable_TableId",
                table: "PongoColumn",
                column: "TableId",
                principalTable: "PongoTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PongoCell_PongoColumn_ColumnId",
                table: "PongoCell");

            migrationBuilder.DropForeignKey(
                name: "FK_PongoColumn_PongoTable_TableId",
                table: "PongoColumn");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PongoUser",
                table: "PongoUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PongoTable",
                table: "PongoTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PongoColumn",
                table: "PongoColumn");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PongoCell",
                table: "PongoCell");

            migrationBuilder.RenameTable(
                name: "PongoUser",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "PongoTable",
                newName: "Table");

            migrationBuilder.RenameTable(
                name: "PongoColumn",
                newName: "Column");

            migrationBuilder.RenameTable(
                name: "PongoCell",
                newName: "Cell");

            migrationBuilder.RenameIndex(
                name: "IX_PongoColumn_TableId",
                table: "Column",
                newName: "IX_Column_TableId");

            migrationBuilder.RenameIndex(
                name: "IX_PongoCell_ColumnId",
                table: "Cell",
                newName: "IX_Cell_ColumnId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table",
                table: "Table",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Column",
                table: "Column",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cell",
                table: "Cell",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cell_Column_ColumnId",
                table: "Cell",
                column: "ColumnId",
                principalTable: "Column",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Column_Table_TableId",
                table: "Column",
                column: "TableId",
                principalTable: "Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

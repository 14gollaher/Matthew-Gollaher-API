using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Pongo.BusinessLogic.Migrations
{
    public partial class Migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cells_Rows_RowId",
                table: "Cells");

            migrationBuilder.DropForeignKey(
                name: "FK_Cells_Rows_RowId1",
                table: "Cells");

            migrationBuilder.DropForeignKey(
                name: "FK_Columns_Tables_TableId",
                table: "Columns");

            migrationBuilder.DropForeignKey(
                name: "FK_Columns_Tables_TableId1",
                table: "Columns");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Users_UserId",
                table: "Tables");

            migrationBuilder.DropTable(
                name: "Rows");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tables",
                table: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Tables_UserId",
                table: "Tables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Columns",
                table: "Columns");

            migrationBuilder.DropIndex(
                name: "IX_Columns_TableId1",
                table: "Columns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cells",
                table: "Cells");

            migrationBuilder.DropIndex(
                name: "IX_Cells_RowId",
                table: "Cells");

            migrationBuilder.DropIndex(
                name: "IX_Cells_RowId1",
                table: "Cells");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "TableId1",
                table: "Columns");

            migrationBuilder.DropColumn(
                name: "RowId",
                table: "Cells");

            migrationBuilder.DropColumn(
                name: "RowId1",
                table: "Cells");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Tables",
                newName: "Table");

            migrationBuilder.RenameTable(
                name: "Columns",
                newName: "Column");

            migrationBuilder.RenameTable(
                name: "Cells",
                newName: "Cell");

            migrationBuilder.RenameIndex(
                name: "IX_Columns_TableId",
                table: "Column",
                newName: "IX_Column_TableId");

            migrationBuilder.AddColumn<int>(
                name: "ColumnId",
                table: "Cell",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Cell_ColumnId",
                table: "Cell",
                column: "ColumnId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Cell_ColumnId",
                table: "Cell");

            migrationBuilder.DropColumn(
                name: "ColumnId",
                table: "Cell");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Table",
                newName: "Tables");

            migrationBuilder.RenameTable(
                name: "Column",
                newName: "Columns");

            migrationBuilder.RenameTable(
                name: "Cell",
                newName: "Cells");

            migrationBuilder.RenameIndex(
                name: "IX_Column_TableId",
                table: "Columns",
                newName: "IX_Columns_TableId");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Tables",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TableId1",
                table: "Columns",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RowId",
                table: "Cells",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RowId1",
                table: "Cells",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tables",
                table: "Tables",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Columns",
                table: "Columns",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cells",
                table: "Cells",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Rows",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    TableId = table.Column<int>(nullable: true),
                    TableId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rows_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rows_Tables_TableId1",
                        column: x => x.TableId1,
                        principalTable: "Tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tables_UserId",
                table: "Tables",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Columns_TableId1",
                table: "Columns",
                column: "TableId1");

            migrationBuilder.CreateIndex(
                name: "IX_Cells_RowId",
                table: "Cells",
                column: "RowId");

            migrationBuilder.CreateIndex(
                name: "IX_Cells_RowId1",
                table: "Cells",
                column: "RowId1");

            migrationBuilder.CreateIndex(
                name: "IX_Rows_TableId",
                table: "Rows",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_Rows_TableId1",
                table: "Rows",
                column: "TableId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cells_Rows_RowId",
                table: "Cells",
                column: "RowId",
                principalTable: "Rows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cells_Rows_RowId1",
                table: "Cells",
                column: "RowId1",
                principalTable: "Rows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Columns_Tables_TableId",
                table: "Columns",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Columns_Tables_TableId1",
                table: "Columns",
                column: "TableId1",
                principalTable: "Tables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Users_UserId",
                table: "Tables",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

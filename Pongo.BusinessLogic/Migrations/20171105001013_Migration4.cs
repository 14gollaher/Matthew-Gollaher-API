using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Pongo.BusinessLogic.Migrations
{
    public partial class Migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cell_Row_RowId",
                table: "Cell");

            migrationBuilder.DropForeignKey(
                name: "FK_Column_Table_TableId",
                table: "Column");

            migrationBuilder.DropForeignKey(
                name: "FK_Row_Table_TableId",
                table: "Row");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table",
                table: "Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Row",
                table: "Row");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Column",
                table: "Column");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cell",
                table: "Cell");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Table",
                newName: "Tables");

            migrationBuilder.RenameTable(
                name: "Row",
                newName: "Rows");

            migrationBuilder.RenameTable(
                name: "Column",
                newName: "Columns");

            migrationBuilder.RenameTable(
                name: "Cell",
                newName: "Cells");

            migrationBuilder.RenameIndex(
                name: "IX_Row_TableId",
                table: "Rows",
                newName: "IX_Rows_TableId");

            migrationBuilder.RenameIndex(
                name: "IX_Column_TableId",
                table: "Columns",
                newName: "IX_Columns_TableId");

            migrationBuilder.RenameIndex(
                name: "IX_Cell_RowId",
                table: "Cells",
                newName: "IX_Cells_RowId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Tables",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Tables",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TableId1",
                table: "Rows",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TableId1",
                table: "Columns",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Cells",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "RowId1",
                table: "Cells",
                type: "int",
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
                name: "PK_Rows",
                table: "Rows",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Columns",
                table: "Columns",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cells",
                table: "Cells",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tables_UserId",
                table: "Tables",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rows_TableId1",
                table: "Rows",
                column: "TableId1");

            migrationBuilder.CreateIndex(
                name: "IX_Columns_TableId1",
                table: "Columns",
                column: "TableId1");

            migrationBuilder.CreateIndex(
                name: "IX_Cells_RowId1",
                table: "Cells",
                column: "RowId1");

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
                name: "FK_Rows_Tables_TableId",
                table: "Rows",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rows_Tables_TableId1",
                table: "Rows",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_Rows_Tables_TableId",
                table: "Rows");

            migrationBuilder.DropForeignKey(
                name: "FK_Rows_Tables_TableId1",
                table: "Rows");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Users_UserId",
                table: "Tables");

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
                name: "PK_Rows",
                table: "Rows");

            migrationBuilder.DropIndex(
                name: "IX_Rows_TableId1",
                table: "Rows");

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
                name: "IX_Cells_RowId1",
                table: "Cells");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "TableId1",
                table: "Rows");

            migrationBuilder.DropColumn(
                name: "TableId1",
                table: "Columns");

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
                name: "Rows",
                newName: "Row");

            migrationBuilder.RenameTable(
                name: "Columns",
                newName: "Column");

            migrationBuilder.RenameTable(
                name: "Cells",
                newName: "Cell");

            migrationBuilder.RenameIndex(
                name: "IX_Rows_TableId",
                table: "Row",
                newName: "IX_Row_TableId");

            migrationBuilder.RenameIndex(
                name: "IX_Columns_TableId",
                table: "Column",
                newName: "IX_Column_TableId");

            migrationBuilder.RenameIndex(
                name: "IX_Cells_RowId",
                table: "Cell",
                newName: "IX_Cell_RowId");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Cell",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 8000);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table",
                table: "Table",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Row",
                table: "Row",
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
                name: "FK_Cell_Row_RowId",
                table: "Cell",
                column: "RowId",
                principalTable: "Row",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
    }
}

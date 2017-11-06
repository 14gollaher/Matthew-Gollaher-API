using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Pongo.BusinessLogic.Migrations
{
    public partial class Migration12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PongoCell_PongoColumn_ColumnId",
                table: "PongoCell");

            migrationBuilder.DropForeignKey(
                name: "FK_PongoColumn_PongoTable_TableId",
                table: "PongoColumn");

            migrationBuilder.DropForeignKey(
                name: "FK_PongoTable_PongoUser_UserId",
                table: "PongoTable");

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
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "PongoTable",
                newName: "Tables");

            migrationBuilder.RenameTable(
                name: "PongoColumn",
                newName: "Columns");

            migrationBuilder.RenameTable(
                name: "PongoCell",
                newName: "Cell");

            migrationBuilder.RenameIndex(
                name: "IX_PongoTable_UserId",
                table: "Tables",
                newName: "IX_Tables_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_PongoColumn_TableId",
                table: "Columns",
                newName: "IX_Columns_TableId");

            migrationBuilder.RenameIndex(
                name: "IX_PongoCell_ColumnId",
                table: "Cell",
                newName: "IX_Cell_ColumnId");

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
                name: "PK_Cell",
                table: "Cell",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cell_Columns_ColumnId",
                table: "Cell",
                column: "ColumnId",
                principalTable: "Columns",
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
                name: "FK_Cell_Columns_ColumnId",
                table: "Cell");

            migrationBuilder.DropForeignKey(
                name: "FK_Columns_Tables_TableId",
                table: "Columns");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Users_UserId",
                table: "Tables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tables",
                table: "Tables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Columns",
                table: "Columns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cell",
                table: "Cell");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "PongoUser");

            migrationBuilder.RenameTable(
                name: "Tables",
                newName: "PongoTable");

            migrationBuilder.RenameTable(
                name: "Columns",
                newName: "PongoColumn");

            migrationBuilder.RenameTable(
                name: "Cell",
                newName: "PongoCell");

            migrationBuilder.RenameIndex(
                name: "IX_Tables_UserId",
                table: "PongoTable",
                newName: "IX_PongoTable_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Columns_TableId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_PongoTable_PongoUser_UserId",
                table: "PongoTable",
                column: "UserId",
                principalTable: "PongoUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Pongo.BusinessLogic.Migrations
{
    public partial class Migration18 : Migration
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

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "PongoTable",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TableId",
                table: "PongoColumn",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ColumnId",
                table: "PongoCell",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PongoCell_PongoColumn_ColumnId",
                table: "PongoCell",
                column: "ColumnId",
                principalTable: "PongoColumn",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PongoColumn_PongoTable_TableId",
                table: "PongoColumn",
                column: "TableId",
                principalTable: "PongoTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PongoTable_PongoUser_UserId",
                table: "PongoTable",
                column: "UserId",
                principalTable: "PongoUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "PongoTable",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TableId",
                table: "PongoColumn",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ColumnId",
                table: "PongoCell",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

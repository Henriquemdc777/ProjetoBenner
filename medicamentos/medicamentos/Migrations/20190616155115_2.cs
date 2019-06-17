using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace medicamentos.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnidadeID",
                table: "Medicacoes");

            migrationBuilder.AddColumn<int>(
                name: "UnidadeID",
                table: "Medicamentos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnidadeID",
                table: "Medicamentos");

            migrationBuilder.AddColumn<int>(
                name: "UnidadeID",
                table: "Medicacoes",
                nullable: false,
                defaultValue: 0);
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace medicamentos.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receita_Usuarios_UsuarioID",
                table: "Receita");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Unidades",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UsuarioID",
                table: "Receita",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Receita",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Receita_UsuarioID",
                table: "Receita",
                newName: "IX_Receita_UsuarioId");

            migrationBuilder.RenameColumn(
                name: "UnidadeID",
                table: "Medicamentos",
                newName: "UnidadeId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Medicamentos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Medicacoes",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "ReceitaId",
                table: "Medicacoes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medicacoes_ReceitaId",
                table: "Medicacoes",
                column: "ReceitaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicacoes_Receita_ReceitaId",
                table: "Medicacoes",
                column: "ReceitaId",
                principalTable: "Receita",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Receita_Usuarios_UsuarioId",
                table: "Receita",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicacoes_Receita_ReceitaId",
                table: "Medicacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Receita_Usuarios_UsuarioId",
                table: "Receita");

            migrationBuilder.DropIndex(
                name: "IX_Medicacoes_ReceitaId",
                table: "Medicacoes");

            migrationBuilder.DropColumn(
                name: "ReceitaId",
                table: "Medicacoes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Unidades",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Receita",
                newName: "UsuarioID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Receita",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Receita_UsuarioId",
                table: "Receita",
                newName: "IX_Receita_UsuarioID");

            migrationBuilder.RenameColumn(
                name: "UnidadeId",
                table: "Medicamentos",
                newName: "UnidadeID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Medicamentos",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Medicacoes",
                newName: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Receita_Usuarios_UsuarioID",
                table: "Receita",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

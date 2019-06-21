using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace medicamentos.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicacoes_Receita_ReceitaId",
                table: "Medicacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Receita_Usuarios_UsuarioId",
                table: "Receita");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Receita",
                table: "Receita");

            migrationBuilder.DropColumn(
                name: "Autor",
                table: "Receita");

            migrationBuilder.DropColumn(
                name: "Composicao",
                table: "Medicamentos");

            migrationBuilder.RenameTable(
                name: "Receita",
                newName: "Receitas");

            migrationBuilder.RenameIndex(
                name: "IX_Receita_UsuarioId",
                table: "Receitas",
                newName: "IX_Receitas_UsuarioId");

            migrationBuilder.AddColumn<int>(
                name: "MedicoId",
                table: "Receitas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Receitas",
                table: "Receitas",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Composicoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MedicamentoId = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Composicoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Composicoes_Medicamentos_MedicamentoId",
                        column: x => x.MedicamentoId,
                        principalTable: "Medicamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Médicos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CRM = table.Column<int>(nullable: false),
                    Cpf = table.Column<string>(nullable: true),
                    Idade = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Médicos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Composicoes_MedicamentoId",
                table: "Composicoes",
                column: "MedicamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicacoes_Receitas_ReceitaId",
                table: "Medicacoes",
                column: "ReceitaId",
                principalTable: "Receitas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Receitas_Usuarios_UsuarioId",
                table: "Receitas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicacoes_Receitas_ReceitaId",
                table: "Medicacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Receitas_Usuarios_UsuarioId",
                table: "Receitas");

            migrationBuilder.DropTable(
                name: "Composicoes");

            migrationBuilder.DropTable(
                name: "Médicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Receitas",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "MedicoId",
                table: "Receitas");

            migrationBuilder.RenameTable(
                name: "Receitas",
                newName: "Receita");

            migrationBuilder.RenameIndex(
                name: "IX_Receitas_UsuarioId",
                table: "Receita",
                newName: "IX_Receita_UsuarioId");

            migrationBuilder.AddColumn<string>(
                name: "Autor",
                table: "Receita",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Composicao",
                table: "Medicamentos",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Receita",
                table: "Receita",
                column: "Id");

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
    }
}

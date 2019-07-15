using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace medicamentos.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Composicoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Médicos",
                table: "Médicos");

            migrationBuilder.RenameTable(
                name: "Médicos",
                newName: "Medicos");

            migrationBuilder.RenameColumn(
                name: "Idade",
                table: "Usuarios",
                newName: "EnderecoId");

            migrationBuilder.RenameColumn(
                name: "Idade",
                table: "Medicos",
                newName: "EnderecoId");

            migrationBuilder.AddColumn<DateTime>(
                name: "Datanasc",
                table: "Usuarios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Datanasc",
                table: "Medicos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Especialidade",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecretariaId",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Medicamentos",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Medicamentos",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicos",
                table: "Medicos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Secretarias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cpf = table.Column<string>(nullable: true),
                    Datanasc = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secretarias", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_SecretariaId",
                table: "Medicos",
                column: "SecretariaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Secretarias_SecretariaId",
                table: "Medicos",
                column: "SecretariaId",
                principalTable: "Secretarias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Secretarias_SecretariaId",
                table: "Medicos");

            migrationBuilder.DropTable(
                name: "Secretarias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicos",
                table: "Medicos");

            migrationBuilder.DropIndex(
                name: "IX_Medicos_SecretariaId",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Datanasc",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Datanasc",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Especialidade",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "SecretariaId",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Medicamentos");

            migrationBuilder.RenameTable(
                name: "Medicos",
                newName: "Médicos");

            migrationBuilder.RenameColumn(
                name: "EnderecoId",
                table: "Usuarios",
                newName: "Idade");

            migrationBuilder.RenameColumn(
                name: "EnderecoId",
                table: "Médicos",
                newName: "Idade");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Medicamentos",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Médicos",
                table: "Médicos",
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

            migrationBuilder.CreateIndex(
                name: "IX_Composicoes_MedicamentoId",
                table: "Composicoes",
                column: "MedicamentoId");
        }
    }
}

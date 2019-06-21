using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using medicamentos.Models;

namespace medicamentos.Migrations
{
    [DbContext(typeof(MedicamentosContext))]
    partial class MedicamentosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("medicamentos.Models.Composicao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MedicamentoId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("MedicamentoId");

                    b.ToTable("Composicoes");
                });

            modelBuilder.Entity("medicamentos.Models.Medicacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Dose");

                    b.Property<string>("DoseTotal");

                    b.Property<int>("Intervalo");

                    b.Property<int>("MedicamentoID");

                    b.Property<int?>("ReceitaId");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("ReceitaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Medicacoes");
                });

            modelBuilder.Entity("medicamentos.Models.Medicamento", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<int>("UnidadeId");

                    b.HasKey("Id");

                    b.ToTable("Medicamentos");
                });

            modelBuilder.Entity("medicamentos.Models.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CRM");

                    b.Property<string>("Cpf");

                    b.Property<int>("Idade");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("Id");

                    b.ToTable("Médicos");
                });

            modelBuilder.Entity("medicamentos.Models.Receita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Dataehora");

                    b.Property<int>("MedicoId");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Receitas");
                });

            modelBuilder.Entity("medicamentos.Models.Unidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Unidades");
                });

            modelBuilder.Entity("medicamentos.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cpf");

                    b.Property<int>("Idade");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("medicamentos.Models.Composicao", b =>
                {
                    b.HasOne("medicamentos.Models.Medicamento")
                        .WithMany("Composicao")
                        .HasForeignKey("MedicamentoId");
                });

            modelBuilder.Entity("medicamentos.Models.Medicacao", b =>
                {
                    b.HasOne("medicamentos.Models.Receita")
                        .WithMany("Medicacoes")
                        .HasForeignKey("ReceitaId");

                    b.HasOne("medicamentos.Models.Usuario")
                        .WithMany("Medicacoes")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("medicamentos.Models.Receita", b =>
                {
                    b.HasOne("medicamentos.Models.Usuario")
                        .WithMany("Receitas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

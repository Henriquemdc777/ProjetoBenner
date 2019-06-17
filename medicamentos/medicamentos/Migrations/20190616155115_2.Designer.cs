using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using medicamentos.Models;

namespace medicamentos.Migrations
{
    [DbContext(typeof(MedicamentosContext))]
    [Migration("20190616155115_2")]
    partial class _2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("medicamentos.Models.Medicacao", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Dose");

                    b.Property<string>("DoseTotal");

                    b.Property<int>("Intervalo");

                    b.Property<int>("MedicamentoID");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("ID");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Medicacoes");
                });

            modelBuilder.Entity("medicamentos.Models.Medicamento", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Composicao");

                    b.Property<string>("Nome");

                    b.Property<int>("UnidadeID");

                    b.HasKey("ID");

                    b.ToTable("Medicamentos");
                });

            modelBuilder.Entity("medicamentos.Models.Receita", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Autor");

                    b.Property<DateTime>("Dataehora");

                    b.Property<int>("UsuarioID");

                    b.HasKey("ID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Receita");
                });

            modelBuilder.Entity("medicamentos.Models.Unidade", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("ID");

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

            modelBuilder.Entity("medicamentos.Models.Medicacao", b =>
                {
                    b.HasOne("medicamentos.Models.Usuario")
                        .WithMany("Medicacoes")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("medicamentos.Models.Receita", b =>
                {
                    b.HasOne("medicamentos.Models.Usuario")
                        .WithMany("Receitas")
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

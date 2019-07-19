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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.Property<int>("UnidadeId");

                    b.HasKey("Id");

                    b.ToTable("Medicamentos");
                });

            modelBuilder.Entity("medicamentos.Models.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cpf");

                    b.Property<int>("Crm");

                    b.Property<DateTime>("Datanasc");

                    b.Property<string>("Descricao");

                    b.Property<int>("EnderecoId");

                    b.Property<string>("Especialidade");

                    b.Property<string>("Nome");

                    b.Property<int?>("SecretariaId");

                    b.Property<string>("Senha");

                    b.HasKey("Id");

                    b.HasIndex("SecretariaId");

                    b.ToTable("Medicos");
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

            modelBuilder.Entity("medicamentos.Models.Secretaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("Datanasc");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("Id");

                    b.ToTable("Secretarias");
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

                    b.Property<string>("Cep");

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("Datanasc");

                    b.Property<string>("Nome");

                    b.Property<int>("Numero");

                    b.Property<string>("Senha");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
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

            modelBuilder.Entity("medicamentos.Models.Medico", b =>
                {
                    b.HasOne("medicamentos.Models.Secretaria")
                        .WithMany("Medicos")
                        .HasForeignKey("SecretariaId");
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

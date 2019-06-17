using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicamentos.Models
{
    public class MedicamentosContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Medicacao> Medicacoes { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Unidade> Unidades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Medicamentos;Trusted_Connection=true;");

            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Initial Catalog = Medicamentos; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicamentos.Models
{
    public class Receita
    {
        public int Id { get; set; }
        public DateTime Dataehora { get; set; }
        public string Autor { get; set; }
        public int UsuarioId { get; set; }
        public IList<Medicacao> Medicacoes { get; set; }
    }
}
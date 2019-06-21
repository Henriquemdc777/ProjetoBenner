using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicamentos.Models
{
    public class Medicamento
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public IList<Composicao> Composicao { get; set; }
        public int UnidadeId { get; set; }
    }
}
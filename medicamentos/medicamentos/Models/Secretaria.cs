using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicamentos.Models
{
    public class Secretaria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Datanasc { get; set; }
        public string Senha { get; set; }
        public IList<Medico> Medicos { get; set; }
    }
}
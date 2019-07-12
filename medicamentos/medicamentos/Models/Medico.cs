using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicamentos.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int CRM { get; set; }
        public DateTime Datanasc { get; set; }
        public string Senha { get; set; }
        public string Descricao { get; set; }
        public string Especialidade { get; set; }
        public int EnderecoId { get; set; }
    }
} 
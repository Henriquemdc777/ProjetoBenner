using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicamentos.Models
{
    public class Medicamento
    {
        public string Medicamentoid { get; set; }
        public string Nome { get; set; }
        public string Composicao { get; set; }
        public string Unidade { get; set; }
    }
}
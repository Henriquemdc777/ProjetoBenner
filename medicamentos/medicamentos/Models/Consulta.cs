using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicamentos.Models
{
    public class Consulta
    {
        public DateTime Datahora { get; set; }
        public Usuario Paciente { get; set; }
        public string Situacao { get; set; }
    }
}
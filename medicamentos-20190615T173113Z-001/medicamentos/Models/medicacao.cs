using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicamentos.Models
{
    public class Medicacao
    {
        public int Medicacaoid { get; set; }
        public int Medicamentoid { get; set; }
        public int Intervalo { get; set; }
        public string Dose { get; set; }
        public string DoseTotal { get; set; }
    }
}
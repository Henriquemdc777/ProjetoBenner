using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicamentos.Models
{
    public class Medicacao
    {
        public int Id { get; set; }
        public int MedicamentoID { get; set; }
        public int Intervalo { get; set; }
        public string Dose { get; set; }
        public string DoseTotal { get; set; }
    }
}
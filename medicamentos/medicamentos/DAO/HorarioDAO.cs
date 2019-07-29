using medicamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicamentos.DAO
{
    public class ConsultaDAO
    {
        public void Adicionar(Consulta aux, Medico med)
        {
            using (var contexto = new MedicamentosContext())
            {
                med.Agenda.Add(aux);
                contexto.SaveChanges();
            }
        }
        public IList<Consulta> Listar(Medico med)
        {
            using (var contexto = new MedicamentosContext())
            {
                return med.Agenda.ToList();
            }
        }
        public void Excluir(DateTime hr,Medico med)
        {
            using (var contexto = new MedicamentosContext())
            {
                var item = med.Agenda.First(p => p.Datahora == hr);
                med.Agenda.Remove(item);
            }
        }
        public void Atualizar(Consulta aux, Medico med)
        {
            using (var contexto = new MedicamentosContext())
            {
                var comp = med.Agenda.First(x => x.Datahora == aux.Datahora);
                comp = aux;
                contexto.SaveChanges();
            }
        }
    }
}
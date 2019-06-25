using medicamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicamentos.DAO
{
    public class MedicamentoDAO
    {
        public void Adicionar(Medicamento comp)
        {
            using (var contexto = new MedicamentosContext())
            {
                contexto.Medicamentos.Add(comp);
                contexto.SaveChanges();
            }
        }
        public IList<Medicamento> Listar()
        {
            using (var contexto = new MedicamentosContext())
            {
                return contexto.Medicamentos.ToList();
            }
        }
        public void Excluir(int id)
        {
            using (var contexto = new MedicamentosContext())
            {
                var item = contexto.Medicamentos.First(p => p.Id == id);
                contexto.Medicamentos.Remove(item);
            }
        }
        public void Atualizar(Medicamento aux)
        {
            using (var contexto = new MedicamentosContext())
            {
                var comp = contexto.Medicamentos.First(x => x.Id == aux.Id);
                comp = aux;
                contexto.Medicamentos.Update(comp);
                contexto.SaveChanges();
            }
        }
    }
}
}
using medicamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicamentos.DAO
{
    public class MedicoDAO
    {
        public void Adicionar(Medico comp)
        {
            using (var contexto = new MedicamentosContext())
            {
                contexto.Medicos.Add(comp);
                contexto.SaveChanges();
            }
        }
        public IList<Medico> Listar()
        {
            using (var contexto = new MedicamentosContext())
            {
                return contexto.Medicos.ToList();
            }
        }
        public void Excluir(int id)
        {
            using (var contexto = new MedicamentosContext())
            {
                var item = contexto.Medicos.First(p => p.Id == id);
                contexto.Medicos.Remove(item);
            }
        }
        public void Atualizar(Medico aux)
        {
            using (var contexto = new MedicamentosContext())
            {
                var comp = contexto.Medicos.First(x => x.Id == aux.Id);
                comp = aux;
                contexto.Medicos.Update(comp);
                contexto.SaveChanges();
            }
        }
    }
}
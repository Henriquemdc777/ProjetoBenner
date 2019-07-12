using medicamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicamentos.DAO
{
    public class ReceitaDAO
    {
        public void Adicionar(Receita comp)
        {
            using (var contexto = new MedicamentosContext())
            {
                contexto.Receitas.Add(comp);
                contexto.SaveChanges();
            }
        }
        public void Excluir(int id)
        {
            using (var contexto = new MedicamentosContext())
            {
                var item = contexto.Receitas.First(p => p.Id == id);
                contexto.Receitas.Remove(item);
            }
        }
        public void Atualizar(Receita aux)
        {
            using (var contexto = new MedicamentosContext())
            {
                var comp = contexto.Receitas.First(x => x.Id == aux.Id);
                comp = aux;
                contexto.Receitas.Update(comp);
                contexto.SaveChanges();
            }
        }
    }
}
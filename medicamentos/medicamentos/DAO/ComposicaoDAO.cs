using medicamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicamentos.DAO
{
    public class ComposicaoDAO
    {
        public void Adicionar(Composicao comp)
        {
            using (var contexto = new MedicamentosContext())
            {
                contexto.Composicoes.Add(comp);
                contexto.SaveChanges();
            }
        }
        public IList<Composicao> Listar()
        {
            using (var contexto = new MedicamentosContext())
            {  
                return contexto.Composicoes.ToList();
            }
        }
        public void Excluir(int id)
        {
            using (var contexto = new MedicamentosContext())
            {
                var item = contexto.Composicoes.First(p => p.Id == id);
                contexto.Composicoes.Remove(item);
            }
        }
        public void Atualizar(Composicao aux)
        {
            using (var contexto = new MedicamentosContext())
            {
                var comp = contexto.Composicoes.First(x => x.Id == aux.Id);
                comp = aux;
                contexto.Composicoes.Update(comp);
                contexto.SaveChanges();
            }
        }
    }
}
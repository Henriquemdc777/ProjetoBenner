using medicamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicamentos.DAO
{
    public class SecretariaDAO
    {
        public void Adicionar(Secretaria comp)
        {
            using (var contexto = new MedicamentosContext())
            {
                contexto.Secretarias.Add(comp);
                contexto.SaveChanges();
            }
        }
        public void Excluir(int id)
        {
            using (var contexto = new MedicamentosContext())
            {
                var item = contexto.Secretarias.First(p => p.Id == id);
                contexto.Secretarias.Remove(item);
            }
        }
        public void Atualizar(Secretaria aux)
        {
            using (var contexto = new MedicamentosContext())
            {
                var comp = contexto.Secretarias.First(x => x.Id == aux.Id);
                comp = aux;
                contexto.Secretarias.Update(comp);
                contexto.SaveChanges();
            }
        }
        public Secretaria Busca(string CPF, string senha)
        {
            using (var contexto = new MedicamentosContext())
            {
                return contexto.Secretarias.FirstOrDefault(u => u.Cpf == CPF && u.Senha == senha);
            }
        }
    }
}
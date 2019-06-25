using medicamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicamentos.DAO
{
    public class UsuarioDAO
    {
        public void Adicionar(Usuario user)
        {
            using (var contexto = new MedicamentosContext())
            {
                contexto.Usuarios.Add(user);
                contexto.SaveChanges();
            }
        }
        public IList<Usuario> Listar()
        {
            using (var contexto = new MedicamentosContext())
            {
                return contexto.Usuarios.ToList();
            }
        }
        public void Excluir(int id)
        {
            using (var contexto = new MedicamentosContext())
            {
                var item = contexto.Usuarios.First(p => p.Id == id);
                contexto.Usuarios.Remove(item);
            }
        }
        public void Atualizar(Usuario aux)
        {
            using (var contexto = new MedicamentosContext())
            {
                var comp = contexto.Usuarios.First(x => x.Id == aux.Id);
                comp = aux;
                contexto.Usuarios.Update(comp);
                contexto.SaveChanges();
            }
        }
        public Usuario Busca(string CPF, string senha)
        {
            using (var contexto = new MedicamentosContext())
            {
                return contexto.Usuarios.FirstOrDefault(u => u.Cpf == CPF && u.Senha == senha);
            }
        }
    }
}
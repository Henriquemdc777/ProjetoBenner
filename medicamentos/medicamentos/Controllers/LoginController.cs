using medicamentos.DAO;
using medicamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace medicamentos.Controllers
{
    public class LoginController : Controller
    {

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult CadastroUsuario(String Nome, String CPF, String senha, DateTime datanasc)
        {
            MedicamentosContext contexto = new MedicamentosContext();
            UsuarioDAO dao = new UsuarioDAO();
            Usuario usuario = new Usuario();
            usuario.Cpf = CPF;
            usuario.Senha = senha;
            usuario.Nome = Nome;
            usuario.Datanasc = datanasc.Date;
            dao.Adicionar(usuario);
            contexto.SaveChanges();
            return RedirectToAction("Login");
        }
        public ActionResult CadastroMedico(String Nome, String CPF, String senha, DateTime datanasc, int CRM, string Desc, string Esp)
        {
            MedicamentosContext contexto = new MedicamentosContext();
            MedicoDAO dao = new MedicoDAO();
            Medico medico = new Medico();
            medico.Cpf = CPF;
            medico.Senha = senha;
            medico.Nome = Nome;
            medico.Datanasc = datanasc;
            medico.Crm = CRM;
            medico.Descricao = Desc;
            medico.Especialidade = Esp;
            dao.Adicionar(medico);
            contexto.SaveChanges();
            return RedirectToAction("CadastroEndereco");
        }
        public ActionResult CadastroSecretaria(String Nome, String CPF, String senha, DateTime datanasc)
        {
            MedicamentosContext contexto = new MedicamentosContext();
            SecretariaDAO dao = new SecretariaDAO();
            Secretaria secretaria = new Secretaria();
            secretaria.Cpf = CPF;
            secretaria.Senha = senha;
            secretaria.Nome = Nome;
            secretaria.Datanasc = datanasc;
            dao.Adicionar(secretaria);
            contexto.SaveChanges();
            return RedirectToAction("CadastroEndereco");
        }
        
        public ActionResult Autentica(String CPF, String senha)
        {
            UsuarioDAO dao = new UsuarioDAO();
            Usuario usuario = dao.Busca(CPF, senha);
            if (usuario != null)
            {
                Session["usuarioLogado"] = usuario;
                return RedirectToAction("Usuario", "Home");
            }
            MedicoDAO dao2 = new MedicoDAO();
            Medico medico = dao2.Busca(CPF, senha);
            if (medico != null)
            {
                Session["usuarioLogado"] = medico;
                return RedirectToAction("Medico", "Home");
            }
            SecretariaDAO dao3 = new SecretariaDAO();
            Secretaria secretaria = dao3.Busca(CPF, senha);
            if (secretaria != null)
            {
                Session["usuarioLogado"] = secretaria;
                return RedirectToAction("Secretaria", "Home");
            }
            else
            {
                return RedirectToAction("index", "login");
            }
        
        }
    }
}
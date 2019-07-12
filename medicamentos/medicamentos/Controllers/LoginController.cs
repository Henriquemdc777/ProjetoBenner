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
        public ActionResult Autentica(String CPF, String senha)
        {
            UsuarioDAO dao = new UsuarioDAO();
            MedicoDAO dao2 = new MedicoDAO();
            SecretariaDAO dao3 = new SecretariaDAO();
            Usuario usuario = dao.Busca(CPF, senha);
            Medico medico = dao2.Busca(CPF, senha);
            Secretaria secretaria = dao3.Busca(CPF, senha);
            if (usuario != null)
            {
                Session["usuarioLogado"] = usuario;
                return RedirectToAction("Usuario", "Home");
            }
            else if(medico != null)
            {
                Session["usuarioLogado"] = medico;
                return RedirectToAction("Medico", "Home");
            }
            else if (secretaria != null)
            {
                Session["usuarioLogado"] = secretaria;
                return RedirectToAction("Secretaria", "Home");
            }
            else
            {
                return RedirectToAction("index", "login");
            }
            public ActionResult Cadastrousuario()
            {
                
            }
        }
    }
}
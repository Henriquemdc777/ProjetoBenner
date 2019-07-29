using medicamentos.DAO;
using medicamentos.Models;
using System;
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
        public ActionResult CadastroUsuario(Usuario usuario)
        {
            MedicamentosContext contexto = new MedicamentosContext();
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.Adicionar(usuario);
            return RedirectToAction("index");
        }
        public ActionResult CadastroMedico(Medico medico)
        {
            MedicamentosContext contexto = new MedicamentosContext();
            MedicoDAO medicoDAO = new MedicoDAO();
            medicoDAO.Adicionar(medico);
            return RedirectToAction("index");
        }
        public ActionResult CadastroSecretaria(Secretaria secretaria)
        {
            MedicamentosContext contexto = new MedicamentosContext();
            SecretariaDAO secretariaDAO = new SecretariaDAO();
            secretariaDAO.Adicionar(secretaria);
            return RedirectToAction("index");
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
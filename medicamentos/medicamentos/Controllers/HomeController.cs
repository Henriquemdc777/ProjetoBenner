using medicamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace medicamentos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Usuario()
        {
            ViewBag.Usuario = Session["UsuarioLogado"];
            return View();
        }
        public ActionResult Medico()
        {
            ViewBag.Medico = Session["UsuarioLogado"];
            return View();
        }
    }
}
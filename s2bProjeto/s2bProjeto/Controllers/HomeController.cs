using s2bProjeto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace s2bProjeto.Controllers
{
    public class HomeController : Controller
    {
        private ModelContext db = new ModelContext();
        Usuario usu = new Usuario();
        
        public ActionResult Usuario()
        {
            usu.Nome = null;
            return View(usu);
        }
        public ActionResult Index()
        {
            var reclamacoes = db.Reclamacoes.Include(r => r.Categoria).Include(r => r.Usuario);
            return View(reclamacoes);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
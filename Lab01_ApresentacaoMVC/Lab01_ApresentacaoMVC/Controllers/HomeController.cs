using Lab01_ApresentacaoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01_ApresentacaoMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //return View();

            //return "Hello MVC!";
            
            ViewBag.Agora = "Hello MVC!" + DateTime.Now;
            return View();
        }

        // GET: Filme
        public ActionResult Filme()
        {
            Filme filme = new Filme()
            {
                Titulo = "Inglourious Basterds",
                Genero = "War",
                Assistido = true
            };

            return View(filme);
        }
    }
}
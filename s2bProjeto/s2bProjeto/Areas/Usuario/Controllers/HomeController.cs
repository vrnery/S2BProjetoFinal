using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace s2bProjeto.Areas.Usuario.Controllers
{
    public class HomeController : Controller
    {
        // GET: Usuario/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}
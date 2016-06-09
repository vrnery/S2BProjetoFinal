using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class GenreController : Controller
    {
        private MovieDBContext movieDb = new MovieDBContext();
        
        // GET: Genre
        public ActionResult Index()
        {
            //return View();

            var genres = movieDb.Genres.OrderBy(g => g.Name);
            return View(genres.ToList());
        }
    }
}
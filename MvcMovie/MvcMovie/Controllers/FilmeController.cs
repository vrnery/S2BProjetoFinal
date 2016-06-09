using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class FilmeController : Controller
    {
        private MovieDBContext db = new MovieDBContext();
        private MovieDBContext movieDb = new MovieDBContext();

        // GET: Filme
        //public ActionResult Index()
        public ActionResult Index(string searchString, int? SelectedGenre)
        {
            //var movies = db.Movies.Include(m => m.Genre);
            //return View(movies.ToList());

            //var filmes = this.movieDb.Movies.Include("Genre").OrderByDescending(a => a.Gross).Take(10).ToList();
            //return View(filmes);

            //var movies = from movie in movieDb.Movies
            //             select movie;
            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    //movies = movies.Where(s => s.Title.Contains(searchString));
            //    movies = movies.Where(s => s.Title.Contains(searchString) || s.Director.Contains(searchString));
            //}
            //return View(movies.ToList());

            var genres = movieDb.Genres.OrderBy(g => g.Name).ToList();
            ViewBag.SelectedGenre = new SelectList(genres, "GenreID", "Name", SelectedGenre);
            int genreID = SelectedGenre.GetValueOrDefault();
            var movies = movieDb.Movies.Where(c => !SelectedGenre.HasValue || c.GenreID == genreID);
            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString) || s.Director.Contains(searchString));
            }
            return View(movies.ToList());
        }

        // GET: Filme/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // GET: Filme/Create
        public ActionResult Create()
        {
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "Name");
            return View();
        }

        // POST: Filme/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Director,ReleaseDate,Gross,Rating,GenreID")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "Name", movie.GenreID);
            return View(movie);
        }

        // GET: Filme/Edit/5
        public ActionResult Edit(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //Movie movie = db.Movies.Find(id);
            //if (movie == null)
            //{
            //    return HttpNotFound();
            //}
            //ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "Name", movie.GenreID);
            //return View(movie);

            Movie filme = this.movieDb.Movies.Find(id);
            if (filme == null)
            {
                return this.HttpNotFound();
            }
            this.ViewBag.GenreId = new SelectList(this.movieDb.Genres, "GenreId", "Name", filme.GenreID);
            return this.View(filme);
        }

        // POST: Filme/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "ID,Title,Director,ReleaseDate,Gross,Rating,GenreID")] Movie movie)
        public ActionResult Edit(Movie album)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Entry(movie).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "Name", movie.GenreID);
            //return View(movie);

            if (ModelState.IsValid)
            {
                this.movieDb.Entry(album).State = EntityState.Modified;
                this.movieDb.SaveChanges();
                return this.RedirectToAction("Index");
            }
            this.ViewBag.GenreId = new SelectList(this.movieDb.Genres, "GenreId", "Name", album.GenreID);
            return this.View(album);
        }

        // GET: Filme/Delete/5
        public ActionResult Delete(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //Movie movie = db.Movies.Find(id);
            //if (movie == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(movie);

            //Album album = this.storeDB.Albums.Find(id);
            Movie movie = this.movieDb.Movies.Find(id);
            //if (album == null)
            if(movie == null)
            {
                return this.HttpNotFound();
            }
            //return this.View(album);
            return this.View(movie);
        }

        // POST: Filme/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Movie movie = db.Movies.Find(id);
            //db.Movies.Remove(movie);
            //db.SaveChanges();
            //return RedirectToAction("Index");

            //Album album = this.storeDB.Albums.Find(id);
            Movie movie = this.movieDb.Movies.Find(id);
            //this.storeDB.Albums.Remove(album);
            this.movieDb.Movies.Remove(movie);
            //this.storeDB.SaveChanges();
            this.movieDb.SaveChanges();
            return this.RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

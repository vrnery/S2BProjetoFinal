using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using s2bProjeto.Models;

namespace s2bProjeto.Controllers
{
    public class ReclamacaosController : Controller
    {
        private ModelContext db = new ModelContext();

        // GET: Reclamacaos
        public ActionResult Index()
        {
            var reclamacoes = db.Reclamacoes.Include(r => r.Usuario);
            return View(reclamacoes.ToList());
        }

        // GET: Reclamacaos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reclamacao reclamacao = db.Reclamacoes.Find(id);
            if (reclamacao == null)
            {
                return HttpNotFound();
            }
            return View(reclamacao);
        }

        // GET: Reclamacaos/Create
        public ActionResult Create()
        {
            ViewBag.UsuarioId = new SelectList(db.Usuarios, "UsuarioId", "Nome");
            return View();
        }

        // POST: Reclamacaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReclamacaoId,Titulo,Descricao,Data,Bairro,Logradouro,Numero,Cep,Imagem,UsuarioId")] Reclamacao reclamacao)
        {
            if (ModelState.IsValid)
            {
                db.Reclamacoes.Add(reclamacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UsuarioId = new SelectList(db.Usuarios, "UsuarioId", "Nome", reclamacao.UsuarioId);
            return View(reclamacao);
        }

        // GET: Reclamacaos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reclamacao reclamacao = db.Reclamacoes.Find(id);
            if (reclamacao == null)
            {
                return HttpNotFound();
            }
            ViewBag.UsuarioId = new SelectList(db.Usuarios, "UsuarioId", "Nome", reclamacao.UsuarioId);
            return View(reclamacao);
        }

        // POST: Reclamacaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReclamacaoId,Titulo,Descricao,Data,Bairro,Logradouro,Numero,Cep,Imagem,UsuarioId")] Reclamacao reclamacao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reclamacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UsuarioId = new SelectList(db.Usuarios, "UsuarioId", "Nome", reclamacao.UsuarioId);
            return View(reclamacao);
        }

        // GET: Reclamacaos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reclamacao reclamacao = db.Reclamacoes.Find(id);
            if (reclamacao == null)
            {
                return HttpNotFound();
            }
            return View(reclamacao);
        }

        // POST: Reclamacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reclamacao reclamacao = db.Reclamacoes.Find(id);
            db.Reclamacoes.Remove(reclamacao);
            db.SaveChanges();
            return RedirectToAction("Index");
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

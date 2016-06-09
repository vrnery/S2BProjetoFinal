using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using s2bProjeto.Models;
using System.Web.Helpers;

namespace s2bProjeto.Controllers
{
    public class ReclamacaosController : Controller
    {
        private ModelContext db = new ModelContext();

        // GET: Reclamacaos
        public ActionResult Index()
        {
            var reclamacoes = db.Reclamacoes.Include(r => r.Categoria).Include(r => r.Usuario);
            return View(reclamacoes.ToList());
        }
        
        // Retorno da foto
        public void GetImage(int id)
        {
            var reclamacaoFile = db.Reclamacoes.Find(id);
            if (reclamacaoFile != null && reclamacaoFile.ImagemFile != null)
            {
                //return File(reclamacaoFile.ImagemFile, reclamacaoFile.ImagemMimeType);
                WebImage imagem = new WebImage((byte[])reclamacaoFile.ImagemFile);
                imagem.Resize(100, 100);
                imagem.FileName = "upload.jpg";
                imagem.Write();
            }
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
            ViewBag.CategoriaId = new SelectList(db.Categorias, "CategoriaId", "Titulo");
            ViewBag.UsuarioId = new SelectList(db.Usuarios, "UsuarioId", "Nome");
            return View();
        }

        // POST: Reclamacaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReclamacaoId,Titulo,Descricao,Data,Bairro,Logradouro,Numero,Cep,ImagemUrl,UsuarioId,CategoriaId")] Reclamacao reclamacao, HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                // Verifica se foi carregada alguma imagem
                if (image != null)
                {
                    reclamacao.ImagemMimeType = image.ContentType;
                    reclamacao.ImagemFile = new byte[image.ContentLength];
                    //Converte a imagem para byte
                    image.InputStream.Read(reclamacao.ImagemFile, 0, image.ContentLength);
                }
                db.Reclamacoes.Add(reclamacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoriaId = new SelectList(db.Categorias, "CategoriaId", "Titulo", reclamacao.CategoriaId);
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
            ViewBag.CategoriaId = new SelectList(db.Categorias, "CategoriaId", "Titulo", reclamacao.CategoriaId);
            ViewBag.UsuarioId = new SelectList(db.Usuarios, "UsuarioId", "Nome", reclamacao.UsuarioId);
            return View(reclamacao);
        }

        // POST: Reclamacaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReclamacaoId,Titulo,Descricao,Data,Bairro,Logradouro,Numero,Cep,ImagemUrl,UsuarioId,CategoriaId")] Reclamacao reclamacao, HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                // Verifica se foi carregada alguma imagem
                if (image != null)
                {
                    reclamacao.ImagemMimeType = image.ContentType;
                    reclamacao.ImagemFile = new byte[image.ContentLength];
                    //Converte a imagem para byte
                    image.InputStream.Read(reclamacao.ImagemFile, 0, image.ContentLength);
                }
                db.Entry(reclamacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoriaId = new SelectList(db.Categorias, "CategoriaId", "Titulo", reclamacao.CategoriaId);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AkiTek.Models;

namespace AkiTek.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ImagensController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Imagens
        public ActionResult Index()
        {
            var imagens = db.Imagens.Include(i => i.Produto);
            return View(imagens.ToList());
        }

        // GET: Imagens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Imagens imagens = db.Imagens.Find(id);
            if (imagens == null)
            {
                return HttpNotFound();
            }
            return View(imagens);
        }

        // GET: Imagens/Create
        public ActionResult Create(int ProdutoFK)
        {
            //ViewBag.ProdutoFK = new SelectList(db.Produtos, "ID", "Nome");
            return View();
        }

        // POST: Imagens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nome,Ordem,ProdutoFK")] Imagens imagens,HttpPostedFileBase img)
        {
            

            if (ModelState.IsValid)
            {
                string nome = "/img/" +  imagens.Nome + ".jpg";
                string url = Path.Combine(Server.MapPath("~/img/"), imagens.Nome + ".jpg"); // indica onde a imagem será guardada
                imagens.Nome = nome;

                // verificar se chega efetivamente um ficheiro ao servidor
                if (img == null) {
                    // não há imagem...
                    ModelState.AddModelError("", "Não foi fornecida uma imagem..."); // gera MSG de erro
                    //ViewBag.ProdutoFK = new SelectList(db.Produtos, "ID", "Nome", imagens.ProdutoFK);
                    return View(imagens); 
                }
                db.Imagens.Add(imagens);
                db.SaveChanges();
                // guardar a imagem no disco rígido
                img.SaveAs(url);
                return View("Close");
            }

            //ViewBag.ProdutoFK = new SelectList(db.Produtos, "ID", "Nome", imagens.ProdutoFK);
            return View(imagens);
        }

        // GET: Imagens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Imagens imagens = db.Imagens.Find(id);
            if (imagens == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProdutoFK = db.Imagens.Find(id).ProdutoFK;//new SelectList(db.Produtos, "ID", "Nome", imagens.ProdutoFK);
            return View(imagens);
        }

        // POST: Imagens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nome,Ordem,ProdutoFK")] Imagens imagens)
        {
            if (ModelState.IsValid)
            {
                db.Entry(imagens).State = EntityState.Modified;
                db.SaveChanges();
                return View("Close");
            }
            //ViewBag.ProdutoFK = new SelectList(db.Produtos, "ID", "Nome", imagens.ProdutoFK);
            return View("Close");
        }

        // GET: Imagens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Imagens imagens = db.Imagens.Find(id);
            if (imagens == null)
            {
                return HttpNotFound();
            }
            return View(imagens);
        }

        // POST: Imagens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Imagens imagens = db.Imagens.Find(id);
            db.Imagens.Remove(imagens);
            db.SaveChanges();
            return View("Close");
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

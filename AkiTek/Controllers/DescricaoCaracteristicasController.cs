using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AkiTek.Models;

namespace AkiTek.Controllers
{
    public class DescricaoCaracteristicasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DescricaoCaracteristicas
        public ActionResult Index()
        {
            var descricaoCaracteristica = db.DescricaoCaracteristica.Include(d => d.Caracteristica).Include(d => d.Produto);
            return View(descricaoCaracteristica.ToList());
        }

        // GET: DescricaoCaracteristicas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DescricaoCaracteristica descricaoCaracteristica = db.DescricaoCaracteristica.Find(id);
            if (descricaoCaracteristica == null)
            {
                return HttpNotFound();
            }
            return View(descricaoCaracteristica);
        }

        // GET: DescricaoCaracteristicas/Create
        public ActionResult Create()
        {
            ViewBag.CaracteristicaFK = new SelectList(db.Caracteristicas, "ID", "Nome");
            ViewBag.ProdutoFK = new SelectList(db.Produtos, "ID", "Nome");
            return View();
        }

        // POST: DescricaoCaracteristicas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Descricao,CaracteristicaFK,ProdutoFK")] DescricaoCaracteristica descricaoCaracteristica)
        {
            if (ModelState.IsValid)
            {
                db.DescricaoCaracteristica.Add(descricaoCaracteristica);
                db.SaveChanges();
                return View("Close");
            }

            ViewBag.CaracteristicaFK = new SelectList(db.Caracteristicas, "ID", "Nome", descricaoCaracteristica.CaracteristicaFK);
            ViewBag.ProdutoFK = new SelectList(db.Produtos, "ID", "Nome", descricaoCaracteristica.ProdutoFK);
            return View(descricaoCaracteristica);
        }

        // GET: DescricaoCaracteristicas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DescricaoCaracteristica descricaoCaracteristica = db.DescricaoCaracteristica.Find(id);
            if (descricaoCaracteristica == null)
            {
                return HttpNotFound();
            }
            ViewBag.CaracteristicaFK = new SelectList(db.Caracteristicas, "ID", "Nome", descricaoCaracteristica.CaracteristicaFK);
            ViewBag.ProdutoFK = new SelectList(db.Produtos, "ID", "Nome", descricaoCaracteristica.ProdutoFK);
            return View(descricaoCaracteristica);
        }

        // POST: DescricaoCaracteristicas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Descricao,CaracteristicaFK,ProdutoFK")] DescricaoCaracteristica descricaoCaracteristica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(descricaoCaracteristica).State = EntityState.Modified;
                db.SaveChanges();
                return View("Close");
            }
            ViewBag.CaracteristicaFK = new SelectList(db.Caracteristicas, "ID", "Nome", descricaoCaracteristica.CaracteristicaFK);
            ViewBag.ProdutoFK = new SelectList(db.Produtos, "ID", "Nome", descricaoCaracteristica.ProdutoFK);
            return View(descricaoCaracteristica);
        }

        // GET: DescricaoCaracteristicas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DescricaoCaracteristica descricaoCaracteristica = db.DescricaoCaracteristica.Find(id);
            if (descricaoCaracteristica == null)
            {
                return HttpNotFound();
            }
            return View(descricaoCaracteristica);
        }

        // POST: DescricaoCaracteristicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DescricaoCaracteristica descricaoCaracteristica = db.DescricaoCaracteristica.Find(id);
            db.DescricaoCaracteristica.Remove(descricaoCaracteristica);
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

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
    [Authorize(Roles = "Admin")]
    public class CaracteristicasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Caracteristicas
        public ActionResult Index(int id)
        {
            return View(db.Caracteristicas.ToList());
        }

        // GET: Caracteristicas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caracteristicas caracteristicas = db.Caracteristicas.Find(id);
            if (caracteristicas == null)
            {
                return HttpNotFound();
            }
            return View(caracteristicas);
        }

        // GET: Caracteristicas/Create
        public ActionResult Create(/*int idProduto*/)
        {
            return View();
        }

        // POST: Caracteristicas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nome,Descricao")] Caracteristicas caracteristicas, int idProduto)
        {
            if (ModelState.IsValid)
            {
                // fecha a janela
                return View("Close");
            }

            return View(caracteristicas);
        }

        // GET: Caracteristicas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caracteristicas caracteristicas = db.Caracteristicas.Find(id);
            if (caracteristicas == null)
            {
                return HttpNotFound();
            }
            return View(caracteristicas);
        }

        // POST: Caracteristicas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nome,Descricao")] Caracteristicas caracteristicas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(caracteristicas).State = EntityState.Modified;
                db.SaveChanges();
                // fecha a janela
                return View("Close");
            }
            return View(caracteristicas);
        }

        // GET: Caracteristicas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caracteristicas caracteristicas = db.Caracteristicas.Find(id);
            if (caracteristicas == null)
            {
                return HttpNotFound();
            }
            return View(caracteristicas);
        }

        // POST: Caracteristicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Caracteristicas caracteristicas = db.Caracteristicas.Find(id);
            db.Caracteristicas.Remove(caracteristicas);
            db.SaveChanges();
            // fecha a janela
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

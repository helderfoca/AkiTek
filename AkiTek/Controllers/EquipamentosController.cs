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
    public class EquipamentosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Equipamentos
        public ActionResult Index()
        {
            var equipamentos = db.Equipamentos.Include(e => e.Compra).Include(e => e.Produto);
            return View(equipamentos.ToList());
        }

        // GET: Equipamentos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equipamentos equipamentos = db.Equipamentos.Find(id);
            if (equipamentos == null)
            {
                return HttpNotFound();
            }
            return View(equipamentos);
        }

        // GET: Equipamentos/Create
        public ActionResult Create(int produtoFK)
        {
            ViewBag.CompraFK = new SelectList(db.OrderDetails, "NumFatura", "NumFatura");
            //ViewBag.ProdutoFK = new SelectList(db.Produtos, "ID", "Nome");
            return View();
        }

        // POST: Equipamentos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NumSerie,PrecoVenda,Vendido,CompraFK,ProdutoFK")] Equipamentos equipamentos)
        {
            if (ModelState.IsValid)
            {
                equipamentos.NumSerie = Guid.NewGuid().ToString();
                db.Equipamentos.Add(equipamentos);
                db.SaveChanges();
                return View("Close");
            }

            ViewBag.CompraFK = new SelectList(db.OrderDetails, "NumFatura", "NumFatura", equipamentos.CompraFK);
            //ViewBag.ProdutoFK = new SelectList(db.Produtos, "ID", "Nome", equipamentos.ProdutoFK);
            return View(equipamentos);
        }

        // GET: Equipamentos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equipamentos equipamentos = db.Equipamentos.Find(id);
            if (equipamentos == null)
            {
                return HttpNotFound();
            }
            ViewBag.CompraFK = new SelectList(db.OrderDetails, "NumFatura", "NumFatura", equipamentos.CompraFK);
            ViewBag.ProdutoFK = new SelectList(db.Produtos, "ID", "Nome", equipamentos.ProdutoFK);
            return View(equipamentos);
        }

        // POST: Equipamentos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NumSerie,PrecoVenda,Vendido,CompraFK,ProdutoFK")] Equipamentos equipamentos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipamentos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CompraFK = new SelectList(db.OrderDetails, "NumFatura", "NumFatura", equipamentos.CompraFK);
            ViewBag.ProdutoFK = new SelectList(db.Produtos, "ID", "Nome", equipamentos.ProdutoFK);
            return View(equipamentos);
        }

        // GET: Equipamentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equipamentos equipamentos = db.Equipamentos.Find(id);
            if (equipamentos == null)
            {
                return HttpNotFound();
            }
            return View(equipamentos);
        }

        // POST: Equipamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Equipamentos equipamentos = db.Equipamentos.Find(id);
            db.Equipamentos.Remove(equipamentos);
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

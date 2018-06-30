using AkiTek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AkiTek.Controllers {
    public class HomeController : Controller {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var lastProd = db.Produtos.OrderByDescending(p => p.ID).First();
            ViewBag.LastProd = lastProd;
            var lastImg = lastProd.Imagens.OrderBy(i => i.Ordem).First();
            ViewBag.LastImg = lastImg;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
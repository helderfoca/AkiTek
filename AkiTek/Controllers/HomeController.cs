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
            // descobre o produto mais recente e manda-o pela ViewBag
            var lastProd = db.Produtos.OrderByDescending(p => p.ID).First();
            ViewBag.LastProd = lastProd;
            // como inicialmente os produtos são criados sem imagem existe uma imagem padrão
            var lastImg = "img/default.png";
            // se o produto tiver imagem manda-a, senão manda a padrão e uma variavél de controlo para remover o link para os detalhes para não provocar erro
            try {
                // imagem do produto mais recente
                lastImg = lastProd.Imagens.OrderBy(i => i.Ordem).First().Nome;
            } catch {
                // variavel de controlo
                ViewBag.Erro = 1;
            }
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
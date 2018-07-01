using AkiTek.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace AkiTek.Controllers {
    [Authorize]
    public class CheckoutController : Controller {
        ApplicationDbContext storeDB = new ApplicationDbContext();
        //
        // GET: /Checkout/AddressAndPayment
        public ActionResult AddressAndPayment() {
            return View();
        }
        //
        // POST: /Checkout/AddressAndPayment
        [HttpPost]
        public ActionResult AddressAndPayment(FormCollection values) {
            var order = new Order();

            TryUpdateModel(order);

            try {
                    // email do utilizador logado
                    order.Username = User.Identity.Name;
                    // referência para a tabela utilizadores
                    var utilizador = storeDB.Utilizadores.Where(user => user.UserName == order.Username).Single();
                    order.UserFK = utilizador.ID;
                    // data da encomenda
                    order.OrderDate = DateTime.Now;
                    

                    //Save Order
                    storeDB.Orders.Add(order);
                    storeDB.SaveChanges();
                    //Process the order
                    var cart = ShoppingCart.GetCart(this.HttpContext);
                    cart.CreateOrder(order);

                    return RedirectToAction("Complete",new { id = order.OrderId });
            }
            catch {
                //Invalid - redisplay with errors
                return View(order);
            }
        }
        //
        // GET: /Checkout/Complete
        public ActionResult Complete(int id) {
            // Validate customer owns this order
            bool isValid = storeDB.Orders.Any(
                o => o.OrderId == id &&
                o.Username == User.Identity.Name);

            if (isValid) {
                return View(id);
            }
            else {
                return View("Error");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AkiTek.Models {
    public partial class ShoppingCart {
        ApplicationDbContext storeDB = new ApplicationDbContext();
        string ShoppingCartId { get; set; }
        public const string CartSessionKey = "CartId";
        public static ShoppingCart GetCart(HttpContextBase context) {
            var cart = new ShoppingCart();
            cart.ShoppingCartId = cart.GetCartId(context);
            return cart;
        }
        // Helper method to simplify shopping cart calls
        public static ShoppingCart GetCart(Controller controller) {
            return GetCart(controller.HttpContext);
        }
        public void AddToCart(Produtos produto) {
            // Get the matching cart and album instances
            var cartItem = storeDB.Carts.SingleOrDefault(
                c => c.CartId == ShoppingCartId
                && c.ProdutoId == produto.ID);

            var equips = produto.ListaEquipamentos.Where(eq => !eq.Vendido);
            var numEquips = equips.Count();
            if (cartItem == null && numEquips>0) {
                // Create a new cart item if no cart item exists
                cartItem = new Cart {
                    ProdutoId = produto.ID,
                    CartId = ShoppingCartId,
                    Quantity = 1,
                    DateCreated = DateTime.Now,
                };
                storeDB.Carts.Add(cartItem);
            }
            else {
                if (cartItem.Quantity < numEquips) {
                    // If the item does exist in the cart, 
                    // then add one to the quantity
                    cartItem.Quantity++;
                }
            }
            // Save changes
            storeDB.SaveChanges();
        }
        public int RemoveFromCart(int id) {
            // Get the cart
            var cartItem = storeDB.Carts.Single(
                cart => cart.CartId == ShoppingCartId
                && cart.RecordId == id);

            int itemCount = 0;

            if (cartItem != null) {
                if (cartItem.Quantity > 1) {
                    cartItem.Quantity--;
                    itemCount = cartItem.Quantity;
                }
                else {
                    storeDB.Carts.Remove(cartItem);
                }
                // Save changes
                storeDB.SaveChanges();
            }
            return itemCount;
        }
        public void EmptyCart() {
            var cartItems = storeDB.Carts.Where(
                cart => cart.CartId == ShoppingCartId);

            foreach (var cartItem in cartItems) {
                storeDB.Carts.Remove(cartItem);
            }
            // Save changes
            storeDB.SaveChanges();
        }
        public List<Cart> GetCartItems() {
            return storeDB.Carts.Where(
                cart => cart.CartId == ShoppingCartId).ToList();
        }
        public int GetCount() {
            // Get the count of each item in the cart and sum them up
            int? count = (from cartItems in storeDB.Carts
                          where cartItems.CartId == ShoppingCartId
                          select (int?)cartItems.Quantity).Sum();
            // Return 0 if all entries are null
            return count ?? 0;
        }
        public decimal GetTotal() {
            // Multiply album price by count of that album to get 
            // the current price for each of those albums in the cart
            // sum all album price totals to get the cart total
            decimal? total = (from cartItems in storeDB.Carts
                              where cartItems.CartId == ShoppingCartId
                              select (int?)cartItems.Quantity *
                              cartItems.Produto.Preco).Sum();

            return total ?? decimal.Zero;
        }
        public int CreateOrder(Order order) {
            decimal orderTotal = 0;

            var cartItems = GetCartItems();
            // Iterate over the items in the cart, 
            // adding the order details for each
            foreach (var item in cartItems) {
                var orderDetail = new OrderDetail {
                    ProdutoId = item.ProdutoId,
                    OrderId = order.OrderId,
                    UnitPrice = item.Produto.Preco,
                    Quantity = item.Quantity,
                    ListaEquip = item.Produto.ListaEquipamentos.Take(item.Quantity).ToList()
                };
                foreach (var eq in orderDetail.ListaEquip) {
                        eq.Vendido = true;
                }
                    
                // Set the order total of the shopping cart
                orderTotal += (item.Quantity * item.Produto.Preco);

                storeDB.OrderDetails.Add(orderDetail);

            }
            // Set the order's total to the orderTotal count
            order.Total = orderTotal;

            // Save the order
            storeDB.SaveChanges();
            // Empty the shopping cart
            EmptyCart();
            // Return the OrderId as the confirmation number
            return order.OrderId;
        }
        // We're using HttpContextBase to allow access to cookies.
        public string GetCartId(HttpContextBase context) {
            if (context.Session[CartSessionKey] == null) {
                if (!string.IsNullOrWhiteSpace(context.User.Identity.Name)) {
                    context.Session[CartSessionKey] =
                        context.User.Identity.Name;
                }
                else {
                    // Generate a new random GUID using System.Guid class
                    Guid tempCartId = Guid.NewGuid();
                    // Send tempCartId back to client as a cookie
                    context.Session[CartSessionKey] = tempCartId.ToString();
                }
            }
            return context.Session[CartSessionKey].ToString();
        }
        // When a user has logged in, migrate their shopping cart to
        // be associated with their username
        public void MigrateCart(string userName) {
            var shoppingCart = storeDB.Carts.Where(
                c => c.CartId == ShoppingCartId);

            foreach (Cart item in shoppingCart) {
                item.CartId = userName;
            }
            storeDB.SaveChanges();
        }
    }
}
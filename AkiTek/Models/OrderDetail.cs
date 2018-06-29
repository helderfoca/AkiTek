using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkiTek.Models {
    public class OrderDetail {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual Produtos Produto { get; set; }
        public virtual Order Order { get; set; }
    }
}
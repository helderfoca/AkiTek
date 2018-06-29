using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AkiTek.Models {
    public class Cart {
        [Key]
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantity { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual Produtos Produto { get; set; }
    }
}
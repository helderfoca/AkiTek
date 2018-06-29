using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AkiTek.Models {
    public class Equipamentos {

        public int ID { get; set; }

        public string NumSerie { get; set; }

        public decimal? PrecoVenda { get; set; }

        public bool Vendido { get; set; }

        //*************************************************************************************
        [ForeignKey("Compra")]
        public int? CompraFK { get; set; }
        public virtual OrderDetail Compra { get; set; }

        [ForeignKey(nameof(Produto))]
        public int ProdutoFK { get; set; }
        public virtual Produtos Produto { get; set; }
    }
}
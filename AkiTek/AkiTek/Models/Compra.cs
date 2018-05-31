using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AkiTek.Models
{
    public class Compra
    {

        [Key]
        //[ForeignKey("Produto")]
        public int NumFatura { get; set; }
        
        public DateTime DataCompra { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteFK { get; set; }
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("Produto")]
        public int ProdutoFK { get; set; }
        public virtual Produto Produto { get; set; }

        
    }
}
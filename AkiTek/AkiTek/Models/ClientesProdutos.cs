using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AkiTek.Models
{
    public class ClientesProdutos
    {

        [Key]
        [ForeignKey("Cliente")]
        public int ClienteFK { get; set; }

        public virtual Clientes Cliente { get; set; }


        [Key]
        [ForeignKey("Produto")]
        public int ProdutooFK { get; set; }

        public virtual Produtos Produto { get; set; }


        public DateTime DataCompra { get; set; }

    }
}
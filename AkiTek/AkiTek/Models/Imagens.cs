using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AkiTek.Models
{
    public class Imagens
    {
      
        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }
        
        public int Ordem { get; set; }

        [ForeignKey("Produto")]
        public int ProdutoFK { get; set; }
        public virtual Produtos Produto { get; set; }
        
    }
}
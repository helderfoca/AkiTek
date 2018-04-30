using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AkiTek.Models
{
    public class Produtos
    {

        [Key]
        public int ID { get; set; }
        
        public string Nome { get; set; }

        public decimal Preco { get; set; }
        
        public string Descricao { get; set; }

    }
}
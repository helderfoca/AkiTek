using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AkiTek.Models
{
    public class Imagem
    {
      
        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }
        
        public int Ordem { get; set; }

        [ForeignKey("Computador")]
        public int ComputadorFK { get; set; }
        public virtual Computador Computador { get; set; }
        
    }
}
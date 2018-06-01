﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AkiTek.Models
{
    public class Compra
    {
        public Compra() {
            ListaProdutos = new HashSet<Equipamentos>();
        }

        [Key]
        public int NumFatura { get; set; }
        
        public DateTime DataCompra { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteFK { get; set; }
        public virtual Cliente Cliente { get; set; }


        public virtual ICollection<Equipamentos> ListaProdutos { get; set; }


    }
}
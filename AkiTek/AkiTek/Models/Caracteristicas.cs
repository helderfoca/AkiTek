using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AkiTek.Models
{
    public class Caracteristicas
    {

        public Caracteristicas()
        {
            ListaProdutos = new HashSet<Produtos>();
        }

        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<Produtos> ListaProdutos { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AkiTek.Models
{
    public class Caracteristica
    {

        public Caracteristica()
        {
            ListaProdutos = new HashSet<Produto>();
        }

        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Categoria { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<Produto> ListaProdutos { get; set; }

    }
}
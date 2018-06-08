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
            ListaProdutos = new HashSet<DescricaoCaracteristica>();
        }

        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<DescricaoCaracteristica> ListaProdutos { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AkiTek.Models
{
    public class Computador
    {

        public Computador()
        {
            Imagens = new HashSet<Imagem>();
            ListaComponentes = new HashSet<Componente>();
        }

        [Key]
        public int ID { get; set; }
        
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        [ForeignKey("Compra")]
        public int CompraFK { get; set; }
        public virtual Compra Compra { get; set; }

        public virtual ICollection<Imagem> Imagens { get; set; }

        public virtual ICollection<Componente> ListaComponentes { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AkiTek.Models
{
    public class Produto
    {

        public Produto()
        {
            Imagens = new HashSet<Imagem>();
            ListaCaracteristicas = new HashSet<Caracteristica>();
        }

        [Key]
        //[ForeignKey("Compra")]
        public int ID { get; set; }
        
        public string Nome { get; set; }

        public string ImgUrl { get; set; }

        public decimal Preco { get; set; }

        public string Descricao { get; set; }

        /*[ForeignKey("Compra")]
        public int CompraFK { get; set; }
        public virtual Compra Compra { get; set; }*/

        public virtual ICollection<Imagem> Imagens { get; set; }

        public virtual ICollection<Caracteristica> ListaCaracteristicas { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AkiTek.Models
{
    public class Clientes
    {

        public Clientes()
        {
            ProdutosAdquiridos = new HashSet<Produtos>();
        }
        

        [Key]
        public int ID { get; set; }
        
        public string Nome { get; set; }
        
        public string Morada { get; set; }

        public DateTime DataNasc { get; set; }

        public string Telemovel { get; set; }

        public string NIF { get; set; }

        public virtual ICollection<Produtos> ProdutosAdquiridos { get; set; }

    }
}
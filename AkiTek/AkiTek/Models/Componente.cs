using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AkiTek.Models
{
    public class Componente
    {

        public Componente()
        {
            ListaComputadores = new HashSet<Computador>();
        }

        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Categoria { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<Computador> ListaComputadores { get; set; }

    }
}
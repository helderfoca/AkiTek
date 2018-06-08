using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AkiTek.Models {
    public class DescricaoCaracteristica {

        [Key]
        public int ID { get; set; }

        public string Descricao { get; set; }

        [ForeignKey("Caracteristica")]
        public int CaracteristicaFK { get; set; }
        public virtual Caracteristicas Caracteristica { get; set; }


        [ForeignKey("Produto")]
        public int ProdutoFK { get; set; }
        public virtual Produtos Produto { get; set; }
    }
}
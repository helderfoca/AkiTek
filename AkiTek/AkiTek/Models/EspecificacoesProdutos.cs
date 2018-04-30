using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AkiTek.Models
{
    public class EspecificacoesProdutos
    {
        [Key]
        [ForeignKey("Produto")]
        public int ProdutoFK { get; set; }

        public virtual Produtos Produto { get; set; }


        [Key]
        [ForeignKey("Especificacao")]
        public int EspecificacaoFK { get; set; }

        public virtual Especificacoes Especificacao { get; set; }
        

        public string Descricao { get; set; }

    }
}
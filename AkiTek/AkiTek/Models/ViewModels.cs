using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkiTek.Models {


    public class ProdutosViewModel {

        public int ID { get; set; }
        public string NomeProduto { get; set; }
        public string Imagem { get; set; }
        public int Stock { get; set; }
        public Decimal Preco { get; set; }


    }
}
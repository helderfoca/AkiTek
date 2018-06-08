using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AkiTek.Models
{
    public class Produtos
    {

        public Produtos()
        {
            Imagens = new HashSet<Imagens>();
            ListaCaracteristicas = new HashSet<DescricaoCaracteristica>();
            ListaEquipamentos = new HashSet<Equipamentos>();
        }

        [Key]
        public int ID { get; set; }
        
        public string Nome { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public virtual ICollection<Imagens> Imagens { get; set; }

        public virtual ICollection<DescricaoCaracteristica> ListaCaracteristicas { get; set; }

        public virtual ICollection<Equipamentos>ListaEquipamentos { get; set; }
    }
}
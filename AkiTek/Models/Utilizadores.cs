using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AkiTek.Models
{
    public class Utilizadores
    {

        public Utilizadores()
        {
            Compras = new HashSet<Order>();
        }
        

        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Nome Próprio é necessário")]
        [DisplayName("Nome Próprio")]
        [StringLength(20)]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Apelido é necessário")]
        [StringLength(20)]
        public string Apelido { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "Data de Nascimento é necessária")]
        public DateTime? DataNasc { get; set; }

        [DisplayName("Telemóvel")]
        [Required(ErrorMessage = "Telemóvel é necessário")]
        [StringLength(15)]
        public string Telemovel { get; set; }

        public virtual ICollection<Order> Compras { get; set; }

        //*********************************************
        /// <summary>
        /// este atributo destina-se a servir como ponte de ligação
        /// entre os objetos desta classe
        /// e os dados da tabela de autenticação
        /// </summary>
        public string UserName { get; set; }

    }
}
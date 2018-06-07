using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AkiTek.Models
{
    public class Utilizadores
    {

        public Utilizadores()
        {
            Compras = new HashSet<Compras>();
        }
        

        [Key]
        public int ID { get; set; }
        
        public string Nome { get; set; }
        
        public string Morada { get; set; }

        public string CodPostal { get; set; }

        public DateTime? DataNasc { get; set; }

        public string Telemovel { get; set; }

        public string NIF { get; set; }

        public virtual ICollection<Compras> Compras { get; set; }

        //*********************************************
        /// <summary>
        /// este atributo destina-se a servir como ponte de ligação
        /// entre os objetos desta classe
        /// e os dados da tabela de autenticação
        /// </summary>
        public string UserName { get; set; }

    }
}
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace AkiTek.Models {
    [Bind(Exclude = "OrderId")]
    public partial class Order {

        [ScaffoldColumn(false)]
        public int OrderId { get; set; }

        [ScaffoldColumn(false)]
        public System.DateTime OrderDate { get; set; }

        [ScaffoldColumn(false)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Nome Próprio é necessário")]
        [DisplayName("Nome Próprio")]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Apelido é necessário")]
        [DisplayName("Apelido")]
        [StringLength(20)]
        public string LastName { get; set; }

        [DisplayName("Morada")]
        [Required(ErrorMessage = "Morada é necessária")]
        [StringLength(70)]
        public string Address { get; set; }

        [DisplayName("Cidade")]
        [Required(ErrorMessage = "Cidade é necessária")]
        [StringLength(20)]
        public string City { get; set; }

        [Required(ErrorMessage = "NIF é necessário")]
        [StringLength(9)]
        public string NIF { get; set; }

        [Required(ErrorMessage = "Código Postal é necessário")]
        [DisplayName("Código Postal")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        [DisplayName("País")]
        [Required(ErrorMessage = "País é necessário")]
        [StringLength(20)]
        public string Country { get; set; }


        [DisplayName("Telemóvel")]
        [Required(ErrorMessage = "Telemóvel é necessário")]
        [StringLength(15)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email é necessário")]
        [DisplayName("Endereço de Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Endereço de Email inválido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        [ScaffoldColumn(false)]
        public List<OrderDetail> OrderDetails { get; set; }

        [ScaffoldColumn(false)]
        [ForeignKey("User")]
        public int? UserFK { get; set; }
        public virtual Utilizadores User { get; set; }
    }
}
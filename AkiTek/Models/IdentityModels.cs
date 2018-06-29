using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AkiTek.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("AkiTekDbConnectionString", throwIfV1Schema: false)
        {
        }

        // tabelas da base de dados

        public virtual DbSet<Utilizadores> Utilizadores { get; set; }

        public virtual DbSet<Compras> Compras { get; set; }

        public virtual DbSet<Imagens> Imagens { get; set; }

        public virtual DbSet<Caracteristicas> Caracteristicas { get; set; }

        public virtual DbSet<Produtos> Produtos { get; set; }
        
        public virtual DbSet<Equipamentos> Equipamentos { get; set; }

        public virtual DbSet<DescricaoCaracteristica> DescricaoCaracteristica { get; set; }

        // Carrinho

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }




        ///// <summary>
        ///// configura a forma como as tabelas são criadas
        ///// </summary>
        ///// <param name="modelBuilder">objeto que referencia o gerador de base de dados</param>
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{

        //    modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        //    modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

        //    base.OnModelCreating(modelBuilder);
        //}

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<AkiTek.ViewModels.ShoppingCartViewModel> ShoppingCartViewModels { get; set; }
    }
}
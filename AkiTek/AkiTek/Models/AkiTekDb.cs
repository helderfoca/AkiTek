using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AkiTek.Models
{
    public class AkiTekDb : DbContext
    {
        // construtor da classe

        public AkiTekDb() : base("AkiTekDbConnectionString")
        {

        }



        // tabelas da base de dados

        public virtual DbSet<Cliente> Clientes { get; set; }

        public virtual DbSet<Compra> Compras { get; set; }

        public virtual DbSet<Imagem> Imagens { get; set; }

        public virtual DbSet<Componente> Componentes { get; set; }

        public virtual DbSet<Computador> Computadores { get; set; }

        



        /// <summary>
        /// configura a forma como as tabelas são criadas
        /// </summary>
        /// <param name="modelBuilder">objeto que referencia o gerador de base de dados</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

    }
}
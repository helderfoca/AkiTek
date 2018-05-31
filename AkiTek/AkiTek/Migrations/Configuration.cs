namespace AkiTek.Migrations
{
    using AkiTek.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AkiTek.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AkiTek.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //*********************************************************************
            // adiciona Clientes
            var clientes = new List<Cliente> {
                new Cliente {ID=1, Nome="Tânia Vieira", Morada="Rua do Mouchão nº430 Tomar", DataNasc=new DateTime(1993,11,19), Telemovel="912353434", NIF="346234654" },
                new Cliente {ID=2, Nome="Edgar Vinhas", Morada="Rua do Falcão nº102 Ourém", DataNasc=new DateTime(1990,01,29), Telemovel="924653434", NIF="346734654" },
                new Cliente {ID=3, Nome="Miguel Rodrigues", Morada="Rua D.Nuno nº14 Gaia", DataNasc=new DateTime(1983,09,02), Telemovel="964895644", NIF="346285674" }
            };
            clientes.ForEach(aa => context.Clientes.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Caracteristicas
            var caracteristicas = new List<Caracteristica> {
                new Caracteristica {ID=1, Nome="Operador", Descricao="Livre"},
                new Caracteristica {ID=2, Nome="Tipo de SIM", Descricao="Nano SIM"},
                new Caracteristica {ID=3, Nome="Rede", Descricao="4G LTE"},
                new Caracteristica {ID=4, Nome="Sistema Operativo",  Descricao="Android OS, v8.0 (Oreo)"},
                new Caracteristica {ID=5, Nome="Memória RAM", Descricao="2GB"},
                new Caracteristica {ID=6, Nome="Dimensões", Descricao="152.4 x 73 x 7.8 mm"},
                new Caracteristica {ID=7, Nome="Bateria",  Descricao="3000 mAh"},

                new Caracteristica {ID=8, Nome="Processador", Descricao="Intel® Celeron® N3350 Dual-Core, 1.10 GHz com Turbo até 2.40 GHz, 2 MB Cache"},
                new Caracteristica {ID=9, Nome="Sistema Operativo", Descricao="Windows 10 Home, 64 Bits"},
                new Caracteristica {ID=10, Nome="Memória RAM", Descricao="2GB DDR4 1600MHz"},
                new Caracteristica {ID=11, Nome="Gráficos", Descricao="Intel® HD Graphics 500"},
                new Caracteristica {ID=12, Nome="Armazenamento", Descricao="eMMC 32GB"},
                new Caracteristica {ID=13, Nome="Dimensões", Descricao="295 x 205 x 20.9mm"}
            };
            caracteristicas.ForEach(aa => context.Caracteristicas.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Produtos
            var produtos = new List<Produto> {
                new Produto {ID=1, Nome="Smartphone Huawei Y6 2018", ImgUrl="/img/HuaweiY6-1.jpg", Preco=new Decimal(159.90) ,
                    Descricao ="Amplie a sua visão com o Huawei Y5 2018. O ecrã HD+ de 5.45 polegadas com uma resolução impressionante de 1440 x 720 proporciona um mundo maior à sua visualização. Com um elegante design de ecrã que se harmoniza perfeitamente com a parte traseira, destaca o flash de cor com o quadro da câmara. Leve, vital, requintado, isto é mais que um telefone, é uma declaração de moda.", //Compra=new Compra{ NumFatura=1},
                    ListaCaracteristicas =new List<Caracteristica>{ caracteristicas[0], caracteristicas[1],caracteristicas[2], caracteristicas[3],caracteristicas[4], caracteristicas[5], caracteristicas[6] } },
                new Produto {ID=2, Nome="Smartphone Huawei Y6 2018", ImgUrl="/img/HuaweiY6-1.jpg", Preco=new Decimal(159.90),
                    Descricao ="Amplie a sua visão com o Huawei Y5 2018. O ecrã HD+ de 5.45 polegadas com uma resolução impressionante de 1440 x 720 proporciona um mundo maior à sua visualização. Com um elegante design de ecrã que se harmoniza perfeitamente com a parte traseira, destaca o flash de cor com o quadro da câmara. Leve, vital, requintado, isto é mais que um telefone, é uma declaração de moda.", //Compra=new Compra{ NumFatura=2},
                    ListaCaracteristicas =new List<Caracteristica>{ caracteristicas[0], caracteristicas[1],caracteristicas[2], caracteristicas[3],caracteristicas[4], caracteristicas[5], caracteristicas[6] } },
                new Produto {ID=3, Nome="Portátil Lenovo Yoga 310 11.6' 310-11IAP-564", Preco=new Decimal(249.00), //Compra=new Compra{ NumFatura=3},
                    ListaCaracteristicas =new List<Caracteristica>{ caracteristicas[7], caracteristicas[8], caracteristicas[9], caracteristicas[10], caracteristicas[11], caracteristicas[12] } },
                new Produto {ID=4, Nome="Portátil Lenovo Yoga 310 11.6' 310-11IAP-564", Preco=new Decimal(249.00), //Compra=new Compra{ NumFatura=4},
                    ListaCaracteristicas =new List<Caracteristica>{ caracteristicas[7], caracteristicas[8], caracteristicas[9], caracteristicas[10], caracteristicas[11], caracteristicas[12] } }
            };
            produtos.ForEach(aa => context.Produtos.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Compras
            var compras = new List<Compra> {
                new Compra {NumFatura=1, DataCompra=new DateTime(2017,05,02), ClienteFK=1, ProdutoFK=1 },//Produto=new Produto{ ID=1}
                new Compra {NumFatura=2, DataCompra=new DateTime(2016,04,29), ClienteFK=2, ProdutoFK=2 },//Produto=new Produto{ ID=2}
                new Compra {NumFatura=3, DataCompra=new DateTime(2018,07,13), ClienteFK=3, ProdutoFK=3 },//Produto=new Produto{ ID=3}
                new Compra {NumFatura=4, DataCompra=new DateTime(2018,07,13), ClienteFK=3, ProdutoFK=4 }//Produto=new Produto{ ID=4}
            };
            compras.ForEach(aa => context.Compras.AddOrUpdate(a => a.NumFatura, aa));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Imagens
            var imagens = new List<Imagem> {
                new Imagem {ID=1, Nome="/img/HuaweiY6-1.jpg", Ordem=1, ProdutoFK=1},
                new Imagem {ID=2, Nome="/img/HuaweiY6-2.jpg", Ordem=2, ProdutoFK=1},
                new Imagem {ID=3, Nome="/img/HuaweiY6-3.jpg", Ordem=3, ProdutoFK=1},
                new Imagem {ID=4, Nome="/img/HuaweiY6-4.jpg", Ordem=4, ProdutoFK=1},
                new Imagem {ID=5, Nome="/img/HuaweiY6-5.jpg", Ordem=5, ProdutoFK=1},
                new Imagem {ID=6, Nome="/img/HuaweiY6-6.jpg", Ordem=6, ProdutoFK=1},
                new Imagem {ID=7, Nome="/img/HuaweiY6-7.jpg", Ordem=1, ProdutoFK=1},
                new Imagem {ID=8, Nome="/img/HuaweiY6-8.jpg", Ordem=2, ProdutoFK=1},
                new Imagem {ID=9, Nome="/img/HuaweiY6-9.jpg", Ordem=3, ProdutoFK=1},
                new Imagem {ID=10, Nome="/img/HuaweiY6-10.jpg", Ordem=4, ProdutoFK=1},
                new Imagem {ID=11, Nome="/img/HuaweiY6-11.jpg", Ordem=5, ProdutoFK=1},
                new Imagem {ID=12, Nome="/img/HuaweiY6-12.jpg", Ordem=6, ProdutoFK=1},
                new Imagem {ID=13, Nome="/img/HuaweiY6-13.jpg", Ordem=6, ProdutoFK=1}
            };
            imagens.ForEach(aa => context.Imagens.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();



        }
    }
}

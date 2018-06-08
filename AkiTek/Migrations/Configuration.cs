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
            var clientes = new List<Utilizadores> {
                new Utilizadores {ID=1, Nome="T�nia Vieira", Morada="Rua do Mouch�o n�430 Tomar", DataNasc=new DateTime(1993,11,19), Telemovel="912353434", NIF="346234654" },
                new Utilizadores {ID=2, Nome="Edgar Vinhas", Morada="Rua do Falc�o n�102 Our�m", DataNasc=new DateTime(1990,01,29), Telemovel="924653434", NIF="346734654" },
                new Utilizadores {ID=3, Nome="Miguel Rodrigues", Morada="Rua D.Nuno n�14 Gaia", DataNasc=new DateTime(1983,09,02), Telemovel="964895644", NIF="346285674" }
            };
            clientes.ForEach(aa => context.Utilizadores.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Caracteristicas
            var caracteristicas = new List<Caracteristicas> {
                new Caracteristicas {ID=1, Nome="Operador"},
                new Caracteristicas {ID=2, Nome="Dual SIM"},
                new Caracteristicas {ID=3, Nome="Tipo de SIM"},
                new Caracteristicas {ID=4, Nome="Rede"},
                //new Caracteristicas {ID=5, Nome="Sistema Operativo",  Descricao="Android OS, v8.0 (Oreo)"},
                //new Caracteristicas {ID=6, Nome="Chipset",  Descricao="Qualcomm MSM8917 Snapdragon 425"},
                //new Caracteristicas {ID=7, Nome="Processador",  Descricao="Quad-core 1.4 GHz Cortex-A53"},
                //new Caracteristicas {ID=8, Nome="Gr�ficos",  Descricao="Adreno 308"},
                //new Caracteristicas {ID=9, Nome="Armazenamento",  Descricao="16GB - expans�vel via microSD"},
                //new Caracteristicas {ID=10, Nome="Mem�ria RAM", Descricao="2GB"},
                //new Caracteristicas {ID=11, Nome="Ecr�", Descricao="Tipo: Touchscreen capacitivo, S-IPS LCD, 16 Milh�es de Cores " +
                //                                                    "Tamanho: 18:9, 720 x 1440 pixels, 5.7 polegadas(~282 ppi)"},
                //new Caracteristicas {ID=12, Nome="C�maras", Descricao="C�mara traseira: 13 MP, phase detection autofocus, LED flash" +
                //                                                    "Funcionalidades: Geo - tagging, touch focus, face detection, HDR, panorama" +
                //                                                    "  V�deo: 1080p" +
                //                                                    "  C�mara frontal: 5 MP, LED flash"},
                //new Caracteristicas {ID=13, Nome="Dados", Descricao="WLAN: Wi - Fi 802.11 b / g / n, Wi - Fi Direct, hotspot" +
                //                                                    "Bluetooth: v4.2, A2DP, LE" +
                //                                                    "USB: microUSB v2.0"},
                //new Caracteristicas {ID=14, Nome="Sensores", Descricao="Aceler�metro, proximidade"},
                //new Caracteristicas {ID=15, Nome="GPS", Descricao="A-GPS, GLONASS"},
                //new Caracteristicas {ID=16, Nome="Bateria",  Descricao="N�o remov�vel Li-Ion 3000 mAh"},
                //new Caracteristicas {ID=17, Nome="Dimens�es", Descricao="152.4 x 73 x 7.8 mm"},
                //new Caracteristicas {ID=18, Nome="Peso", Descricao="150 g"},
                //new Caracteristicas {ID=19, Nome="Dual SIM", Descricao="N�o"},
                //new Caracteristicas {ID=20, Nome="Sistema Operativo",  Descricao="Apple iOS"},
                //new Caracteristicas {ID=21, Nome="Chipset",  Descricao="Apple A10 Fusion"},
                //new Caracteristicas {ID=22, Nome="Processador",  Descricao="Quad-core 2.34 GHz (2x Hurricane + 2x Zephyr)"},
                //new Caracteristicas {ID=23, Nome="Gr�ficos",  Descricao="PowerVR Series7XT Plus (six-core graphics)"},
                //new Caracteristicas {ID=24, Nome="Armazenamento",  Descricao="32GB"},
                //new Caracteristicas {ID=25, Nome="Ecr�", Descricao="Tamanho: 4.7 polegadas IPS LCD" +
                //                                                    "Resolu��o: 750 x 1334(~326 ppi)"},
                //new Caracteristicas {ID=26, Nome="C�maras", Descricao="C�mara traseira: 12 MP, f/1.8, 28mm, phase detection autofocus, OIS, quad-LED (dual tone) flash" +
                //                                                    "Caracter�sticas: 1 / 3'' sensor size, geo-tagging, simultaneous 4K video and 8MP image recording, touch focus, face/smile detection, HDR (photo/panorama)" +
                //                                                    "V�deo: 2160p@30fps, 1080p@30 / 60 / 120fps, 720p@240fps" +
                //                                                    "C�mara frontal: 7 MP, f / 2.2, 32mm, 1080p@30fps, 720p@240fps, face detection, HDR, panorama"},
                //new Caracteristicas {ID=27, Nome="Dados", Descricao="WLAN: Wi-Fi 802.11 a/b/g/n/ac, dual-band, hotspot" +
                //                                                    "Bluetooth: 4.2, A2DP, LE"},
                //new Caracteristicas {ID=28, Nome="Sensores", Descricao="Impress�o digital (frontal), aceler�metro, girosc�pio, proximidade, b�ssola, bar�metro"},
                //new Caracteristicas {ID=29, Nome="Bateria", Descricao="N�o remov�vel Li-Ion 1960 mAh"},
                //new Caracteristicas {ID=30, Nome="Dimens�es", Descricao="138.3 x 67.1 x 7.1 mm"},
                //new Caracteristicas {ID=31, Nome="Peso", Descricao="138 g"},
            };
            caracteristicas.ForEach(aa => context.Caracteristicas.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();


            //*********************************************************************
            // adiciona Produtos
            var produtos = new List<Produtos> {
                new Produtos {ID=1, Nome="Smartphone Huawei Y6 2018", Preco=new Decimal(159.90) ,
                    Descricao ="Amplie a sua vis�o com o Huawei Y6 2018. O ecr� HUAWEI FullView Display HD+ de 5.7 polegadas com uma resolu��o impressionante de 1440 x 720 proporciona um mundo maior � sua visualiza��o. Com um elegante design de ecr� 2.5D que se harmoniza perfeitamente com o mate suave da parte traseira, destaca o flash de cor com o quadro da c�mara. Leve, vital, requintado, isto � mais que um telefone, � uma declara��o de moda.", //Compra=new Compra{ NumFatura=1},
                     
                },
                new Produtos {ID=2, Nome="Smartphone Apple iPhone 7 32GB Dourado", Preco=new Decimal(579.00),
                    Descricao ="Conhe�a o iPhone SE, o telefone de 4 polegadas mais avan�ado de sempre. Para o criar, peg�mos num design reconhecido por muitos e reinvent�mo-lo por completo. O avan�ado processador A9 � o mesmo do iPhone 6s. A c�mara de 12 megap�xeis capta fotografias e v�deos em 4K incr�veis. E o Live Photos d� vida �s suas fotografias. O resultado � um iPhone que parece pequeno, mas tem tudo para ser grande.",
                    
                },
                //new Produtos {ID=3, Nome="Port�til Lenovo Yoga 310 11.6' 310-11IAP-564", Preco=new Decimal(249.00), //Compra=new Compra{ NumFatura=3},
                //    ListaCaracteristicas =new List<Caracteristicas>{ caracteristicas[7], caracteristicas[8], caracteristicas[9], caracteristicas[10], caracteristicas[11], caracteristicas[12] } 
                //},
                //new Produtos {ID=4, Nome="Port�til Lenovo Yoga", Preco=new Decimal(500.00), //Compra=new Compra{ NumFatura=4},
                //    ListaCaracteristicas =new List<Caracteristicas>{ caracteristicas[7], caracteristicas[8], caracteristicas[9], caracteristicas[10], caracteristicas[11], caracteristicas[12] } 
                //}
            };
            produtos.ForEach(aa => context.Produtos.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();


            //*********************************************************************
            // adiciona 
            var desc = new List<DescricaoCaracteristica> {
                new DescricaoCaracteristica {ID=1, Descricao="Livre", ProdutoFK=1, CaracteristicaFK=1 },
                new DescricaoCaracteristica {ID=2, Descricao="Livre", ProdutoFK=2, CaracteristicaFK=1 },
                new DescricaoCaracteristica {ID=3, Descricao="Sim", ProdutoFK=1, CaracteristicaFK=2 },
                new DescricaoCaracteristica {ID=4, Descricao="N�o", ProdutoFK=2, CaracteristicaFK=2 },
                new DescricaoCaracteristica {ID=5, Descricao="Nano SIM", ProdutoFK=1, CaracteristicaFK=3 },
                new DescricaoCaracteristica {ID=6, Descricao="Nano SIM", ProdutoFK=2, CaracteristicaFK=3 },
                new DescricaoCaracteristica {ID=7, Descricao="4G LTE", ProdutoFK=1, CaracteristicaFK=4 },
                new DescricaoCaracteristica {ID=8, Descricao="4G LTE", ProdutoFK=2, CaracteristicaFK=4 },
            };
            desc.ForEach(aa => context.DescricaoCaracteristica.AddOrUpdate(a => a.ID, aa));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Equipamentos
            var equip = new List<Equipamentos> {
                new Equipamentos {NumSerie =Guid.NewGuid().ToString() , ProdutoFK=1 , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=1 , Vendido=false },
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=1 , Vendido=false },
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=2  , Vendido=false},
                //new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=2  , Vendido=false},
                //new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=3  , Vendido=false},
                //new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=3  , Vendido=false},
                //new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=3  , Vendido=false},
                //new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=4  , Vendido=false},
            };
            equip.ForEach(aa => context.Equipamentos.AddOrUpdate(a => a.ID, aa));
            context.SaveChanges();




            //*********************************************************************
            //// adiciona Compras
            //var compras = new List<Compra> {
            //    new Compra {NumFatura=1, DataCompra=new DateTime(2017,05,02), ClienteFK=1,
            //    ListaProdutos=new List<Produto> {produtos[0]} },
            //    new Compra {NumFatura=2, DataCompra=new DateTime(2016,04,29), ClienteFK=2,
            //    ListaProdutos=new List<Produto> {produtos[1], produtos[2]}},
            //   // new Compra {NumFatura=3, DataCompra=new DateTime(2018,07,13), ClienteFK=3 },
            //    //new Compra {NumFatura=4, DataCompra=new DateTime(2018,07,13), ClienteFK=3 }
            //};
            //compras.ForEach(aa => context.Compras.AddOrUpdate(a => a.NumFatura, aa));
            //context.SaveChanges();

            //*********************************************************************
            // adiciona Imagens
            var imagens = new List<Imagens> {
                new Imagens {ID=1, Nome="/img/HuaweiY6-1.jpg", Ordem=1, ProdutoFK=1},
                new Imagens {ID=2, Nome="/img/HuaweiY6-2.jpg", Ordem=2, ProdutoFK=1},
                new Imagens {ID=3, Nome="/img/HuaweiY6-3.jpg", Ordem=3, ProdutoFK=1},
                new Imagens {ID=4, Nome="/img/HuaweiY6-4.jpg", Ordem=4, ProdutoFK=1},
                new Imagens {ID=5, Nome="/img/HuaweiY6-5.jpg", Ordem=5, ProdutoFK=1},
                new Imagens {ID=6, Nome="/img/HuaweiY6-6.jpg", Ordem=6, ProdutoFK=1},
                new Imagens {ID=7, Nome="/img/HuaweiY6-7.jpg", Ordem=1, ProdutoFK=1},
                new Imagens {ID=8, Nome="/img/HuaweiY6-8.jpg", Ordem=2, ProdutoFK=1},
                new Imagens {ID=9, Nome="/img/HuaweiY6-9.jpg", Ordem=3, ProdutoFK=1},
                new Imagens {ID=10, Nome="/img/HuaweiY6-10.jpg", Ordem=4, ProdutoFK=1},
                new Imagens {ID=11, Nome="/img/HuaweiY6-11.jpg", Ordem=5, ProdutoFK=1},
                new Imagens {ID=12, Nome="/img/HuaweiY6-12.jpg", Ordem=6, ProdutoFK=1},
                new Imagens {ID=13, Nome="/img/HuaweiY6-13.jpg", Ordem=6, ProdutoFK=1},
                new Imagens {ID=14, Nome="/img/iPhone7Gold-1.jpg", Ordem=1, ProdutoFK=2},
                new Imagens {ID=15, Nome="/img/iPhone7Gold-2.jpg", Ordem=2, ProdutoFK=2}
            };
            imagens.ForEach(aa => context.Imagens.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();



        }
    }
}

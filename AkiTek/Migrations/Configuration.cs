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
                new Utilizadores {ID=1, Nome="Tânia Vieira", Morada="Rua do Mouchão nº430 Tomar", DataNasc=new DateTime(1993,11,19), Telemovel="912353434", NIF="346234654" },
                new Utilizadores {ID=2, Nome="Edgar Vinhas", Morada="Rua do Falcão nº102 Ourém", DataNasc=new DateTime(1990,01,29), Telemovel="924653434", NIF="346734654" },
                new Utilizadores {ID=3, Nome="Miguel Rodrigues", Morada="Rua D.Nuno nº14 Gaia", DataNasc=new DateTime(1983,09,02), Telemovel="964895644", NIF="346285674" }
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
                new Caracteristicas {ID=5, Nome="Sistema Operativo"},
                new Caracteristicas {ID=6, Nome="Chipset"},
                new Caracteristicas {ID=7, Nome="Processador"},
                new Caracteristicas {ID=8, Nome="Gráficos"},
                new Caracteristicas {ID=9, Nome="Armazenamento"},
                new Caracteristicas {ID=10, Nome="Memória RAM"},
                new Caracteristicas {ID=11, Nome="Ecrã"},
                new Caracteristicas {ID=12, Nome="Câmaras"},
                new Caracteristicas {ID=13, Nome="Dados"},
                new Caracteristicas {ID=14, Nome="Sensores"},
                new Caracteristicas {ID=15, Nome="GPS"},
                new Caracteristicas {ID=16, Nome="Bateria"},
                new Caracteristicas {ID=17, Nome="Dimensões"},
                new Caracteristicas {ID=18, Nome="Peso"},
            };
            caracteristicas.ForEach(aa => context.Caracteristicas.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();


            //*********************************************************************
            // adiciona Produtos
            var produtos = new List<Produtos> {
                new Produtos {ID=1, Nome="Smartphone Huawei Y6 2018", Preco=new Decimal(159.90) ,
                    Descricao ="Amplie a sua visão com o Huawei Y6 2018. O ecrã HUAWEI FullView Display HD+ de 5.7 polegadas com uma resolução impressionante de 1440 x 720 proporciona um mundo maior à sua visualização. Com um elegante design de ecrã 2.5D que se harmoniza perfeitamente com o mate suave da parte traseira, destaca o flash de cor com o quadro da câmara. Leve, vital, requintado, isto é mais que um telefone, é uma declaração de moda.", //Compra=new Compra{ NumFatura=1},
                     
                },
                new Produtos {ID=2, Nome="Smartphone Apple iPhone 7 32GB Dourado", Preco=new Decimal(579.00),
                    Descricao ="Conheça o iPhone SE, o telefone de 4 polegadas mais avançado de sempre. Para o criar, pegámos num design reconhecido por muitos e reinventámo-lo por completo. O avançado processador A9 é o mesmo do iPhone 6s. A câmara de 12 megapíxeis capta fotografias e vídeos em 4K incríveis. E o Live Photos dá vida às suas fotografias. O resultado é um iPhone que parece pequeno, mas tem tudo para ser grande.",
                    
                },
            };
            produtos.ForEach(aa => context.Produtos.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();


            //*********************************************************************
            // adiciona 
            var desc = new List<DescricaoCaracteristica> {
                new DescricaoCaracteristica {ID=1, Descricao="Livre", ProdutoFK=1, CaracteristicaFK=1 },
                new DescricaoCaracteristica {ID=2, Descricao="Sim", ProdutoFK=1, CaracteristicaFK=2 },
                new DescricaoCaracteristica {ID=3, Descricao="Nano SIM", ProdutoFK=1, CaracteristicaFK=3 },
                new DescricaoCaracteristica {ID=4, Descricao="4G LTE", ProdutoFK=1, CaracteristicaFK=4 },
                new DescricaoCaracteristica {ID=5, Descricao="Android OS, v8.0 (Oreo)", ProdutoFK=1, CaracteristicaFK=5 },
                new DescricaoCaracteristica {ID=6, Descricao="Qualcomm MSM8917 Snapdragon 425", ProdutoFK=1, CaracteristicaFK=6 },
                new DescricaoCaracteristica {ID=7, Descricao="Quad-core 1.4 GHz Cortex-A53", ProdutoFK=1, CaracteristicaFK=7 },
                new DescricaoCaracteristica {ID=8, Descricao="Adreno 308", ProdutoFK=1, CaracteristicaFK=8 },
                new DescricaoCaracteristica {ID=9, Descricao="16GB - expansível via microSD", ProdutoFK=1, CaracteristicaFK=9 },
                new DescricaoCaracteristica {ID=10, Descricao="2GB", ProdutoFK=1, CaracteristicaFK=10 },
                new DescricaoCaracteristica {ID=11, Descricao="Tipo: Touchscreen capacitivo, S-IPS LCD, 16 Milhões de Cores " +
                                                                "Tamanho: 18:9, 720 x 1440 pixels, 5.7 polegadas(~282 ppi)",
                    ProdutoFK =1, CaracteristicaFK=11 },
                new DescricaoCaracteristica {ID=12, Descricao="Câmara traseira: 13 MP, phase detection autofocus, LED flash" +
                                                                "Funcionalidades: Geo - tagging, touch focus, face detection, HDR, panorama" +
                                                                "Vídeo: 1080p" +
                                                                "Câmara frontal: 5 MP, LED flash",
                    ProdutoFK =1, CaracteristicaFK=12 },
                new DescricaoCaracteristica {ID=13, Descricao="WLAN: Wi - Fi 802.11 b / g / n, Wi - Fi Direct, hotspot" +
                                                                "Bluetooth: v4.2, A2DP, LE" +
                                                                "USB: microUSB v2.0",
                    ProdutoFK =1, CaracteristicaFK=13 },
                new DescricaoCaracteristica {ID=14, Descricao="Acelerômetro, proximidade",
                    ProdutoFK =1, CaracteristicaFK=14 },
                new DescricaoCaracteristica {ID=15, Descricao="A-GPS, GLONASS",
                    ProdutoFK =1, CaracteristicaFK=15 },
                new DescricaoCaracteristica {ID=16, Descricao="Não removível Li-Ion 3000 mAh",
                    ProdutoFK =1, CaracteristicaFK=16 },
                new DescricaoCaracteristica {ID=17, Descricao="152.4 x 73 x 7.8 mm",
                    ProdutoFK =1, CaracteristicaFK=17 },
                new DescricaoCaracteristica {ID=18, Descricao="150 g",
                    ProdutoFK =1, CaracteristicaFK=18 },
                new DescricaoCaracteristica {ID=19, Descricao="Livre", ProdutoFK=2, CaracteristicaFK=1 },
                new DescricaoCaracteristica {ID=20, Descricao="Não", ProdutoFK=2, CaracteristicaFK=2 },
                new DescricaoCaracteristica {ID=21, Descricao="Nano SIM", ProdutoFK=2, CaracteristicaFK=3 },
                new DescricaoCaracteristica {ID=22, Descricao="4G LTE", ProdutoFK=2, CaracteristicaFK=4 },
                new DescricaoCaracteristica {ID=23, Descricao="Apple iOS", ProdutoFK=2, CaracteristicaFK=5 },
                new DescricaoCaracteristica {ID=24, Descricao="Apple A10 Fusion", ProdutoFK=2, CaracteristicaFK=6 },
                new DescricaoCaracteristica {ID=25, Descricao="Quad-core 2.34 GHz (2x Hurricane + 2x Zephyr)", ProdutoFK=2, CaracteristicaFK=7 },
                new DescricaoCaracteristica {ID=26, Descricao="PowerVR Series7XT Plus (six-core graphics)", ProdutoFK=2, CaracteristicaFK=8 },
                new DescricaoCaracteristica {ID=27, Descricao="32GB", ProdutoFK=2, CaracteristicaFK=9 },
                new DescricaoCaracteristica {ID=28, Descricao="2GB", ProdutoFK=2, CaracteristicaFK=10 },
                new DescricaoCaracteristica {ID=29, Descricao="Tamanho: 4.7 polegadas IPS LCD" +
                                                                "Resolução: 750 x 1334(~326 ppi)",
                    ProdutoFK =2, CaracteristicaFK=11 },
                new DescricaoCaracteristica {ID=30, Descricao="Câmara traseira: 12 MP, f/1.8, 28mm, phase detection autofocus, OIS, quad-LED (dual tone) flash" +
                                                                "Características: 1 / 3'' sensor size, geo-tagging, simultaneous 4K video and 8MP image recording, touch focus, face/smile detection, HDR (photo/panorama)" +
                                                                "Vídeo: 2160p@30fps, 1080p@30 / 60 / 120fps, 720p@240fps" +
                                                                "Câmara frontal: 7 MP, f / 2.2, 32mm, 1080p@30fps, 720p@240fps, face detection, HDR, panorama",
                    ProdutoFK =2, CaracteristicaFK=12 },
                new DescricaoCaracteristica {ID=31, Descricao="WLAN: Wi-Fi 802.11 a/b/g/n/ac, dual-band, hotspot" +
                                                                "Bluetooth: 4.2, A2DP, LE",
                    ProdutoFK =2, CaracteristicaFK=13 },
                new DescricaoCaracteristica {ID=32, Descricao="Impressão digital (frontal), acelerômetro, giroscópio, proximidade, bússola, barómetro",
                    ProdutoFK =2, CaracteristicaFK=14 },
                new DescricaoCaracteristica {ID=33, Descricao="A-GPS, GLONASS",
                    ProdutoFK =2, CaracteristicaFK=15 },
                new DescricaoCaracteristica {ID=34, Descricao="Não removível Li-Ion 1960 mAh",
                    ProdutoFK =2, CaracteristicaFK=16 },
                new DescricaoCaracteristica {ID=35, Descricao="138.3 x 67.1 x 7.1 mm",
                    ProdutoFK =2, CaracteristicaFK=17 },
                new DescricaoCaracteristica {ID=36, Descricao="138 g",
                    ProdutoFK =2, CaracteristicaFK=18 },
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

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
            // adiciona Utilizadores
            var clientes = new List<Utilizadores> {
                new Utilizadores {ID=1, Nome="Hélder", Apelido="Lopes", DataNasc=new DateTime(1997,01,14), Telemovel="913725253", UserName="admin@akitek.pt" },
                new Utilizadores {ID=2, Nome="Tânia", Apelido="Vieira", DataNasc=new DateTime(1993,11,19), Telemovel="912353434", UserName="gestor@akitek.pt" },
                new Utilizadores {ID=3, Nome="Edgar", Apelido="Vinhas", DataNasc=new DateTime(1990,01,29), Telemovel="924653434", UserName="vinhas@akitek.pt" },
                new Utilizadores {ID=4, Nome="Miguel", Apelido="Rodrigues", DataNasc=new DateTime(1983,09,02), Telemovel="964895644", UserName="rod@akitek.pt" }
            };
            clientes.ForEach(aa => context.Utilizadores.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();

            //*********************************************************************
            // adiciona específicações
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
                new Caracteristicas {ID=19, Nome="Áudio"},
                new Caracteristicas {ID=20, Nome="Resistente à água"},
                new Caracteristicas {ID=21, Nome="Conteúdo da Embalagem"},
                new Caracteristicas {ID=22, Nome="Rádio"},
            };
            caracteristicas.ForEach(aa => context.Caracteristicas.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();


            //*********************************************************************
            // adiciona Produtos
            var produtos = new List<Produtos> {
                new Produtos {ID=1, Nome="Smartphone Huawei Y6 2018", Preco=new Decimal(159.90) ,
                    Descricao ="Amplie a sua visão com o Huawei Y6 2018. O ecrã HUAWEI FullView Display HD+ de 5.7 polegadas com uma resolução impressionante de 1440 x 720 proporciona um mundo maior à sua visualização. Com um elegante design de ecrã 2.5D que se harmoniza perfeitamente com o mate suave da parte traseira, destaca o flash de cor com o quadro da câmara. Leve, vital, requintado, isto é mais que um telefone, é uma declaração de moda.",
                     
                },
                new Produtos {ID=2, Nome="Smartphone Apple iPhone 7 32GB Dourado", Preco=new Decimal(579.00),
                    Descricao ="Conheça o iPhone SE, o telefone de 4 polegadas mais avançado de sempre. Para o criar, pegámos num design reconhecido por muitos e reinventámo-lo por completo. O avançado processador A9 é o mesmo do iPhone 6s. A câmara de 12 megapíxeis capta fotografias e vídeos em 4K incríveis. E o Live Photos dá vida às suas fotografias. O resultado é um iPhone que parece pequeno, mas tem tudo para ser grande.",
                    
                },
                new Produtos {ID=3, Nome="Smartphone Xiaomi Redmi Note 5A Prime Cinza", Preco=new Decimal(169.90),
                    Descricao ="O Redmi Note 5A Prime está otimizado para uma vida útil mais longa da bateria. É alimentado por uma bateria de 3080mAh de grande capacidade, e juntamente com a otimização MIUI ao nível do sistema, ele oferece até 10 horas de reprodução de vídeo, até 12 horas de jogo e até 21 horas de leitura.",
                    
                },
                new Produtos {ID=4, Nome="Smartphone Honor 5X Cinza", Preco=new Decimal(139.90),
                    Descricao ="O Honor 5x inclui uma das características mais úteis possibilitadas pelo sistema operativo Android - o led de notificações. Através do led de notificações multicolor o Honor 5x transmite ao utilizador de forma imediata e sem ser preciso tocar no smartphone várias informações úteis tais como a existência ou não de chamadas não atendidas entre outras.",
                    
                },
                new Produtos {ID=5, Nome="Smartphone Motorola Moto G5 Cinzento", Preco=new Decimal(149.90),
                    Descricao ="O Moto G5 vem com memória de 16 GB e opção de armazenar até 128 GB adicionais com um cartão de memória microSD (não incluído), para você desfrutar de espaço suficiente para aplicativos, música, filmes e fotos.",
                    
                },
                new Produtos {ID=6, Nome="Smartphone Lenovo Moto G4 Branco", Preco=new Decimal(149.90),
                    Descricao ="Ao fazer uma chamada o Moto G sugere ou seleciona automaticamente um chip com base na operadora do seu contato ou histórico. Ele também seleciona automaticamente a tecnologia mais rápida para a sua conexão de dados.",

                },
                new Produtos {ID=7, Nome="Microsoft Lumia 550 Branco", Preco=new Decimal(128.90),
                    Descricao ="Com o Windows 10 no seu Lumia 550 você pode aceder aos mesmos serviços e apps da Microsoft que você está familiarizado no seu laptop. O armazenamento gratuito onedrive ajuda-o a manter os seus documentos seguros na nuvem e dá-lhe a liberdade para aceder e editá-los no seu telefone.",
                    
                },
                new Produtos {ID=8, Nome="Smartphone Apple iPhone 8 Vermelho", Preco=new Decimal(829.00),
                    Descricao ="Com o iPhone 8 foi criado um novo design em vidro. A câmara mais popular do mundo está ainda melhor. Mas a inovação estende-se a muito mais: ao processador de smartphone mais potente e inteligente de sempre, a um carregamento sem fios sem o mínimo de esforço e às experiências inéditas com realidade aumentada, impossíveis até agora. iPhone 8. A nova geração de iPhone.",

                },
            };
            produtos.ForEach(aa => context.Produtos.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();


            //*********************************************************************
            // adiciona as características da específicação
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
                new DescricaoCaracteristica {ID=11, Descricao="Tipo: Touchscreen capacitivo, S-IPS LCD, 16 Milhões de Cores, " +
                                                                "Tamanho: 18:9, 720 x 1440 pixels, 5.7 polegadas(~282 ppi)",
                    ProdutoFK =1, CaracteristicaFK=11 },
                new DescricaoCaracteristica {ID=12, Descricao="Câmara traseira: 13 MP, phase detection autofocus, LED flash, " +
                                                                "Funcionalidades: Geo - tagging, touch focus, face detection, HDR, panorama, " +
                                                                "Vídeo: 1080p, " +
                                                                "Câmara frontal: 5 MP, LED flash",
                    ProdutoFK =1, CaracteristicaFK=12 },
                new DescricaoCaracteristica {ID=13, Descricao="WLAN: Wi - Fi 802.11 b / g / n, Wi - Fi Direct, hotspot, " +
                                                                "Bluetooth: v4.2, A2DP, LE, " +
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
                    ProdutoFK=2, CaracteristicaFK=11 },
                new DescricaoCaracteristica {ID=30, Descricao="Câmara traseira: 12 MP, f/1.8, 28mm, phase detection autofocus, OIS, quad-LED (dual tone) flash, " +
                                                                "Características: 1 / 3'' sensor size, geo-tagging, simultaneous 4K video and 8MP image recording, touch focus, face/smile detection, HDR (photo/panorama), " +
                                                                "Vídeo: 2160p@30fps, 1080p@30 / 60 / 120fps, 720p@240fps, " +
                                                                "Câmara frontal: 7 MP, f / 2.2, 32mm, 1080p@30fps, 720p@240fps, face detection, HDR, panorama",
                    ProdutoFK=2, CaracteristicaFK=12 },
                new DescricaoCaracteristica {ID=31, Descricao="WLAN: Wi-Fi 802.11 a/b/g/n/ac, dual-band, hotspot, " +
                                                                "Bluetooth: 4.2, A2DP, LE",
                    ProdutoFK=2, CaracteristicaFK=13 },
                new DescricaoCaracteristica {ID=32, Descricao="Impressão digital (frontal), acelerômetro, giroscópio, proximidade, bússola, barómetro",
                    ProdutoFK=2, CaracteristicaFK=14 },
                new DescricaoCaracteristica {ID=33, Descricao="A-GPS, GLONASS",
                    ProdutoFK=2, CaracteristicaFK=15 },
                new DescricaoCaracteristica {ID=34, Descricao="Não removível Li-Ion 1960 mAh",
                    ProdutoFK=2, CaracteristicaFK=16 },
                new DescricaoCaracteristica {ID=35, Descricao="138.3 x 67.1 x 7.1 mm",
                    ProdutoFK=2, CaracteristicaFK=17 },
                new DescricaoCaracteristica {ID=36, Descricao="138 g",
                    ProdutoFK=2, CaracteristicaFK=18 },
                new DescricaoCaracteristica {ID=37, Descricao="Livre",
                    ProdutoFK=3, CaracteristicaFK=1 },
                new DescricaoCaracteristica {ID=38, Descricao="Sim",
                    ProdutoFK=3, CaracteristicaFK=2 },
                new DescricaoCaracteristica {ID=39, Descricao="Nano-SIM dual stand-by",
                    ProdutoFK=3, CaracteristicaFK=3 },
                new DescricaoCaracteristica {ID=40, Descricao="2G / 3G / 4G",
                    ProdutoFK=3, CaracteristicaFK=4 },
                new DescricaoCaracteristica {ID=41, Descricao="Android 7.0 (Nougat)",
                    ProdutoFK=3, CaracteristicaFK=5 },
                new DescricaoCaracteristica {ID=42 , Descricao="Qualcomm Snapdragon 435",
                    ProdutoFK=3, CaracteristicaFK=6 },
                new DescricaoCaracteristica {ID=43 , Descricao="Octa-Core",
                    ProdutoFK=3, CaracteristicaFK=7 },
                new DescricaoCaracteristica {ID=44 , Descricao="Adreno 505",
                    ProdutoFK=3, CaracteristicaFK=8 },
                new DescricaoCaracteristica {ID=45 , Descricao="32GB (espaço utilizável será inferior) - expansível via microSD até 256GB (utilizando um dos slots SIM)",
                    ProdutoFK=3, CaracteristicaFK=9 },
                new DescricaoCaracteristica {ID=46 , Descricao="3GB",
                    ProdutoFK=3, CaracteristicaFK=10 },
                new DescricaoCaracteristica {ID=47 , Descricao="Tipo: Touchscreen capacitivo IPS LCD 16 Milhões de Cores, " +
                                                                "Tamanho: 720 x 1280 pixels 5.5 polegadas(~267 ppi)",
                    ProdutoFK=3, CaracteristicaFK=11 },
                new DescricaoCaracteristica {ID=48 , Descricao="Câmara traseira: 13 MP, f/2.2, phase detection autofocus, LED flash, " +
                                                                "Funcionalidades: Geo - tagging, touch focus, face detection, HDR, panorama, " +
                                                                "Vídeo: 1080p@30fps, " +
                                                                "Câmara frontal: 16 MP, f / 2.0",
                    ProdutoFK=3, CaracteristicaFK=12 },
                new DescricaoCaracteristica {ID=49 , Descricao="WLAN: Wi-Fi 802.11 b/g/n, Wi-Fi Direct, hotspot, " +
                                                                "Bluetooth: Sim, 4.2, A2DP, LE, " +
                                                                "Infravermelhos: Sim, " +
                                                                "USB: Sim, microUSB v2.0",
                    ProdutoFK=3, CaracteristicaFK=13 },
                new DescricaoCaracteristica {ID=50 , Descricao=" Impressão Digital (montado na traseira), Acelerómetro, giroscópio, proximidade, bússola",
                    ProdutoFK=3, CaracteristicaFK=14 },
                new DescricaoCaracteristica {ID=51 , Descricao="Sim, com suporte A-GPS, GLONASS, BDS",
                    ProdutoFK=3, CaracteristicaFK=15 },
                new DescricaoCaracteristica {ID=52 , Descricao="Não removível Li-Ion 3080 mAh",
                    ProdutoFK=3, CaracteristicaFK=16 },
                new DescricaoCaracteristica {ID=53 , Descricao="153 x 76.2 x 7.7 mm",
                    ProdutoFK=3, CaracteristicaFK=17 },
                new DescricaoCaracteristica {ID=54 , Descricao="153 g",
                    ProdutoFK=3, CaracteristicaFK=18 },
                new DescricaoCaracteristica {ID=55, Descricao="Livre",
                    ProdutoFK=4, CaracteristicaFK=1 },
                new DescricaoCaracteristica {ID=56, Descricao="Sim",
                    ProdutoFK=4, CaracteristicaFK=2 },
                new DescricaoCaracteristica {ID=57, Descricao="Nano-SIM dual stand-by",
                    ProdutoFK=4, CaracteristicaFK=3 },
                new DescricaoCaracteristica {ID=58, Descricao="2G / 3G / 4G",
                    ProdutoFK=4, CaracteristicaFK=4 },
                new DescricaoCaracteristica {ID=59, Descricao="Android OS v5.1.1 (Lollipop)",
                    ProdutoFK=4, CaracteristicaFK=5 },
                new DescricaoCaracteristica {ID=60, Descricao="Qualcomm Snapdragon 616",
                    ProdutoFK=4, CaracteristicaFK=6 },
                new DescricaoCaracteristica {ID=61, Descricao="Octa-core (4x1.2 GHz Cortex-A53 & 4x1.5 GHz Cortex-A53)",
                    ProdutoFK=4, CaracteristicaFK=7 },
                new DescricaoCaracteristica {ID=62, Descricao="Adreno 405",
                    ProdutoFK=4, CaracteristicaFK=8 },
                new DescricaoCaracteristica {ID=63, Descricao="16GB (espaço utilizável será inferior), " +
                                                                "Expansível via microSD até 128GB",
                    ProdutoFK=4, CaracteristicaFK=9 },
                new DescricaoCaracteristica {ID=64, Descricao="2GB",
                    ProdutoFK=4, CaracteristicaFK=10 },
                new DescricaoCaracteristica {ID=65, Descricao="Tipo: Touchscreen capacitivo IPS LCD 16 Milhões de Cores, " +
                                                                "Tamanho: 1080 x 1920 pixels 5.5 polegadas(~401 ppi)",
                    ProdutoFK=4, CaracteristicaFK=11 },
                new DescricaoCaracteristica {ID=66, Descricao="Câmara traseira: 13 MP f/2.0 28mm autofocus dual-LED (dual tone) flash, " +
                                                                "Características: Geo - tagging touch focus deteção de face panorama HDR, " +
                                                                "Vídeo: 1080p@30fps Slow Motion 720p@120fps, " +
                                                                "Câmara frontal: 5 MP f/ 2.4 22mm",
                    ProdutoFK=4, CaracteristicaFK=12 },
                new DescricaoCaracteristica {ID=67, Descricao="WLAN: Wi-Fi 802.11 b/g/n 2.4GHz Wi-Fi Direct hotspot, " +
                                                                "Bluetooth: Sim v4.1 A2DP, " +
                                                                "NFC: Não, " +
                                                                "USB: Sim microUSB v2.0 USB Host",
                    ProdutoFK=4, CaracteristicaFK=13 },
                new DescricaoCaracteristica {ID=68, Descricao="Altifalante mono com amplificador inteligente 1884% mais alto com excelente gama de áudio",
                    ProdutoFK=4, CaracteristicaFK=19 },
                new DescricaoCaracteristica {ID=69, Descricao="Impressão digital acelerómetro proximidade bússola",
                    ProdutoFK=4, CaracteristicaFK=14 },
                new DescricaoCaracteristica {ID=70, Descricao="Sim com suporte A-GPS / Glonass",
                    ProdutoFK=4, CaracteristicaFK=15 },
                new DescricaoCaracteristica {ID=71, Descricao="Não removível Li-Ion 3000 mAh",
                    ProdutoFK=4, CaracteristicaFK=16 },
                new DescricaoCaracteristica {ID=72, Descricao="151.3 x 76.3 x 8.2 mm",
                    ProdutoFK=4, CaracteristicaFK=17 },
                new DescricaoCaracteristica {ID=73, Descricao="158 g",
                    ProdutoFK=4, CaracteristicaFK=18 },
                new DescricaoCaracteristica {ID=74, Descricao="Livre",
                    ProdutoFK=5, CaracteristicaFK=1 },
                new DescricaoCaracteristica {ID=75, Descricao="Sim",
                    ProdutoFK=5, CaracteristicaFK=2 },
                new DescricaoCaracteristica {ID=76, Descricao="Nano-SIM dual stand-by",
                    ProdutoFK=5, CaracteristicaFK=3 },
                new DescricaoCaracteristica {ID=76, Descricao="4G LTE, " +
                                                                "Velocidade: HSPA 42.2 / 5.76 Mbps, LTE Cat4 150 / 50 Mbps",
                    ProdutoFK=5, CaracteristicaFK=4 },
                new DescricaoCaracteristica {ID=77, Descricao="Android OS, v7.0 (Nougat)",
                    ProdutoFK=5, CaracteristicaFK=5 },
                new DescricaoCaracteristica {ID=78, Descricao="Qualcomm MSM8937 Snapdragon 430",
                    ProdutoFK=5, CaracteristicaFK=6 },
                new DescricaoCaracteristica {ID=79, Descricao="Octa-core 1.4 GHz Cortex-A53",
                    ProdutoFK=5, CaracteristicaFK=7 },
                new DescricaoCaracteristica {ID=80, Descricao="Adreno 505",
                    ProdutoFK=5, CaracteristicaFK=8 },
                new DescricaoCaracteristica {ID=81, Descricao="16GB internos (a capacidade real disponível p/ o utilizador será sempre inferior), " +
                                                                "Expansível via cartão microSD até 128GB (cartão não incluído)",
                    ProdutoFK=5, CaracteristicaFK=9 },
                new DescricaoCaracteristica {ID=82, Descricao="3GB",
                    ProdutoFK=5, CaracteristicaFK=10 },
                new DescricaoCaracteristica {ID=83, Descricao="Tipo: IPS LCD capacitivo touchscreen 16 Milhões de Cores, " +
                                                                "Tamanho: 1080 x 1920 pixels 5 polegadas(~441 ppi), " +
                                                                "Protecção: Corning Gorilla Glass 3",
                    ProdutoFK=5, CaracteristicaFK=11 },
                new DescricaoCaracteristica {ID=84, Descricao="Principal (traseira): 13 MP, f/2.0, phase detection autofocus, LED flash, " +
                                                                "Características: Geo - tagging, touch focus, face detection, panorama, auto - HDR, " +
                                                                "Vídeo: 1080p@30fps, " +
                                                                "Secundária(frontal): 5 MP, f / 2.2",
                    ProdutoFK=5, CaracteristicaFK=12 },
                new DescricaoCaracteristica {ID=85, Descricao="WLAN: Wi-Fi 802.11 a/b/g/n, dual-band, WiFi Direct, hotspot, " +
                                                                "Bluetooth: v4.2, A2DP, LE, EDR, " +
                                                                "Rádio: Sim, " +
                                                                "USB: microUSB v2.0, USB Host",
                    ProdutoFK=5, CaracteristicaFK=13 },
                new DescricaoCaracteristica {ID=86, Descricao="Coluna frontal, " +
                                                                "2 x Microfones",
                    ProdutoFK=5, CaracteristicaFK=19 },
                new DescricaoCaracteristica {ID=87, Descricao="Sim de acordo com o padrão IPX7",
                    ProdutoFK=5, CaracteristicaFK=20 },
                new DescricaoCaracteristica {ID=88, Descricao="Leitor de Impressão Digital (montado na frontal), Acelerômetro, Giroscópio, Sensor de Luz Ambiente, Sensor de Proximidade",
                    ProdutoFK=5, CaracteristicaFK=14 },
                new DescricaoCaracteristica {ID=89, Descricao="Sim, A-GPS, GLONASS",
                    ProdutoFK=5, CaracteristicaFK=15 },
                new DescricaoCaracteristica {ID=90, Descricao="Removível, Li-Ion 2800 mAh",
                    ProdutoFK=5, CaracteristicaFK=16 },
                new DescricaoCaracteristica {ID=91, Descricao="144.3 x 73 x 9.5 mm",
                    ProdutoFK=5, CaracteristicaFK=17 },
                new DescricaoCaracteristica {ID=92, Descricao="145 g",
                    ProdutoFK=5, CaracteristicaFK=18 },
                new DescricaoCaracteristica {ID=93, Descricao="Livre",
                    ProdutoFK=6, CaracteristicaFK=1 },
                new DescricaoCaracteristica {ID=94, Descricao="Sim",
                    ProdutoFK=6, CaracteristicaFK=2 },
                new DescricaoCaracteristica {ID=95, Descricao="2G / 3G / 4G LTE, " +
                                                                "Velocidade: HSPA 42.2 / 5.76 Mbps LTE Cat4 150 / 50 Mbps",
                    ProdutoFK=6, CaracteristicaFK=4 },
                new DescricaoCaracteristica {ID=96, Descricao="Android OS v6.0.1 (Marshmallow)",
                    ProdutoFK=6, CaracteristicaFK=5 },
                new DescricaoCaracteristica {ID=97, Descricao="Qualcomm MSM8952 Snapdragon 617",
                    ProdutoFK=6, CaracteristicaFK=6 },
                new DescricaoCaracteristica {ID=98, Descricao="Quad-core 1.5 GHz Cortex-A53 & quad-core 1.2 GHz Cortex-A53",
                    ProdutoFK=6, CaracteristicaFK=7 },
                new DescricaoCaracteristica {ID=99, Descricao="Adreno 405",
                    ProdutoFK=6, CaracteristicaFK=8 },
                new DescricaoCaracteristica {ID=100, Descricao="16GB internos (a capacidade real disponível p/ o utilizador será sempre inferior), " +
                                                                "Expansível via cartão microSD até 128GB (cartão não incluído)",
                    ProdutoFK=6, CaracteristicaFK=9 },
                new DescricaoCaracteristica {ID=101, Descricao="2GB",
                    ProdutoFK=6, CaracteristicaFK=10 },
                new DescricaoCaracteristica {ID=102, Descricao="Tipo: IPS LCD capacitivo touchscreen 16 Milhões de Cores, " +
                                                                "Tamanho: 1080 x 1920 pixels 5.5 polegadas(~401 ppi), " +
                                                                "Protecção: Corning Gorilla Glass 3",
                    ProdutoFK=6, CaracteristicaFK=11 },
                new DescricaoCaracteristica {ID=103, Descricao="Câmara Traseira: " +
                                                                "13 MP, " +
                                                                "Abertura da lente de ƒ / 20, " +
                                                                "Flash dual LED com equilíbrio de cores, " +
                                                                "Câmara instantânea, " +
                                                                "Melhor foto, " +
                                                                "Toque (em qualquer lugar) para capturar, " +
                                                                "Zoom digital de 4X, " +
                                                                "Disparo contínuo, " +
                                                                "Auto HDR, " +
                                                                "Panorama, " +
                                                                "Arraste para definir foco e exposição, " +
                                                                "Estabilização de vídeo, " +
                                                                "Vídeo em HD 1080p (30 fps), " +
                                                                "Vídeo em câmara lenta, " +
                                                                "Câmara Frontal:" +
                                                                "5 MP, " +
                                                                "Abertura da lente: ƒ / 22, " +
                                                                "Lente de ângulo aberto, " +
                                                                "Flash do ecrã",
                    ProdutoFK=6, CaracteristicaFK=12 },
                new DescricaoCaracteristica {ID=104, Descricao="WLAN: Wi-Fi 802.11 a/b/g/n Wi-Fi Direct hotspot, " +
                                                                "Bluetooth: Sim v4.1 A2DP LE, " +
                                                                "USB: Sim microUSB v2.0 USB Host",
                    ProdutoFK=6, CaracteristicaFK=13 },
                new DescricaoCaracteristica {ID=105, Descricao="Coluna frontal, " +
                                                                "2 x Microfones",
                    ProdutoFK=6, CaracteristicaFK=19 },
                new DescricaoCaracteristica {ID=106, Descricao="Sim Nanorrevestimento resistente a pingos de água",
                    ProdutoFK=6, CaracteristicaFK=20 },
                new DescricaoCaracteristica {ID=107, Descricao="Acelerômetro Giroscópio Sensor de luz ambiente",
                    ProdutoFK=6, CaracteristicaFK=14 },
                new DescricaoCaracteristica {ID=108, Descricao="Sim GPS A-GPS GLONASS BDS",
                    ProdutoFK=6, CaracteristicaFK=15 },
                new DescricaoCaracteristica {ID=109, Descricao="Não Removível Li-Ion 3000 mAh",
                    ProdutoFK=6, CaracteristicaFK=16 },
                new DescricaoCaracteristica {ID=110, Descricao="153 x 76.6 x 9.8 mm",
                    ProdutoFK=6, CaracteristicaFK=17 },
                new DescricaoCaracteristica {ID=111, Descricao="157 g",
                    ProdutoFK=6, CaracteristicaFK=18 },
                new DescricaoCaracteristica {ID=112, Descricao="Smartphone, " +
                                                                "Travel Charger",
                    ProdutoFK=6, CaracteristicaFK=21 },
                new DescricaoCaracteristica {ID=113, Descricao="Livre",
                    ProdutoFK=7, CaracteristicaFK=1 },
                new DescricaoCaracteristica {ID=114, Descricao="Não",
                    ProdutoFK=7, CaracteristicaFK=2 },
                new DescricaoCaracteristica {ID=115, Descricao="Nano SIM",
                    ProdutoFK=7, CaracteristicaFK=3 },
                new DescricaoCaracteristica {ID=116, Descricao="2G: GSM 850 / 900 / 1800 / 1900, " +
                                                                "3G: HSDPA 850 / 900 / 2100, " +
                                                                "4G LTE: LTE banda 1(2100) 3(1800) 7(2600) 8(900) 20(800), " +
                                                                "Velocidade: HSPA 42.2 / 5.76 Mbps LTE Cat4 150 / 50 Mbps",
                    ProdutoFK=7, CaracteristicaFK=4 },
                new DescricaoCaracteristica {ID=117, Descricao="Microsoft Windows 10",
                    ProdutoFK=7, CaracteristicaFK=5 },
                new DescricaoCaracteristica {ID=118, Descricao="Qualcomm MSM8909 Snapdragon 210",
                    ProdutoFK=7, CaracteristicaFK=6 },
                new DescricaoCaracteristica {ID=119, Descricao="Quad-core 1.1 GHz Cortex-A7",
                    ProdutoFK=7, CaracteristicaFK=7 },
                new DescricaoCaracteristica {ID=120, Descricao="Adreno 304",
                    ProdutoFK=7, CaracteristicaFK=8 },
                new DescricaoCaracteristica {ID=121, Descricao="8GB - expansível via cartão microSD até 200GB",
                    ProdutoFK=7, CaracteristicaFK=9 },
                new DescricaoCaracteristica {ID=122, Descricao="1GB",
                    ProdutoFK=7, CaracteristicaFK=10 },
                new DescricaoCaracteristica {ID=123, Descricao="Tipo: Touchscreen LCD capacitivo 16 Milhões de Cores, " +
                                                                "Tamanho: 720 x 1280 pixels 4.7 polegadas(~315 ppi)",
                    ProdutoFK=7, CaracteristicaFK=11 },
                new DescricaoCaracteristica {ID=124, Descricao="Principal (traseira): 5 MP f/2.4 autofocus LED flash, " +
                                                                "Características: 1 / 4'' sensor size geo-tagging touch focus, " +
                                                                "Vídeo: Sim 720p@30fps, " +
                                                                "Secundária(frontal): 2 MP f/ 2.8 480p",
                    ProdutoFK=7, CaracteristicaFK=12 },
                new DescricaoCaracteristica {ID=125, Descricao="WLAN: Wi-Fi 802.11 b/g/n hotspot, " +
                                                                "Bluetooth: Sim v4.1 A2DP, " +
                                                                "USB: Sim microUSB v2.0",
                    ProdutoFK=7, CaracteristicaFK=13 },
                new DescricaoCaracteristica {ID=126, Descricao="Sensor de luz ambiente Acelerômetro Sensor de proximidade",
                    ProdutoFK=7, CaracteristicaFK=14 },
                new DescricaoCaracteristica {ID=127, Descricao="Sim com suporte A-GPS GLONASS BDS",
                    ProdutoFK=7, CaracteristicaFK=15 },
                new DescricaoCaracteristica {ID=128, Descricao="Sim Rádio FM com RDS",
                    ProdutoFK=7, CaracteristicaFK=22 },
                new DescricaoCaracteristica {ID=128, Descricao="Removível Li-Ion 2100 mAh",
                    ProdutoFK=7, CaracteristicaFK=16 },
                new DescricaoCaracteristica {ID=129, Descricao="136.1 x 67.8 x 9.9 mm",
                    ProdutoFK=7, CaracteristicaFK=17 },
                new DescricaoCaracteristica {ID=130, Descricao="141.9 g",
                    ProdutoFK=7, CaracteristicaFK=18 },
                new DescricaoCaracteristica {ID=131, Descricao="Microsoft Lumia 550, " +
                                                                "Carregador Nokia, " +
                                                                "Bateria, " +
                                                                "Guia rápido",
                    ProdutoFK=7, CaracteristicaFK=21 },
                new DescricaoCaracteristica {ID=132, Descricao="Livre",
                    ProdutoFK=8, CaracteristicaFK=1 },
                new DescricaoCaracteristica {ID=133, Descricao="Não",
                    ProdutoFK=8, CaracteristicaFK=2 },
                new DescricaoCaracteristica {ID=134, Descricao="4G LTE",
                    ProdutoFK=8, CaracteristicaFK=4 },
                new DescricaoCaracteristica {ID=135, Descricao="Apple iOS",
                    ProdutoFK=8, CaracteristicaFK=5 },
                new DescricaoCaracteristica {ID=136, Descricao="Apple A11 Bionic",
                    ProdutoFK=8, CaracteristicaFK=6 },
                new DescricaoCaracteristica {ID=137, Descricao="Hexa-core (2x Monsoon + 4x Mistral)",
                    ProdutoFK=8, CaracteristicaFK=7 },
                new DescricaoCaracteristica {ID=138, Descricao="Apple GPU (three-core graphics)",
                    ProdutoFK=8, CaracteristicaFK=8 },
                new DescricaoCaracteristica {ID=139, Descricao="64GB",
                    ProdutoFK=8, CaracteristicaFK=9 },
                new DescricaoCaracteristica {ID=140, Descricao="2GB",
                    ProdutoFK=8, CaracteristicaFK=10 },
                new DescricaoCaracteristica {ID=141, Descricao="Tamanho: 4.7 polegadas IPS LCD, " +
                                                                "Resolução: 750 x 1334(~326 ppi)",
                    ProdutoFK=8, CaracteristicaFK=11 },
                new DescricaoCaracteristica {ID=142, Descricao="Câmara traseira: Dual 12 MP, (28mm, f/1.8, OIS & 56mm, f/2.8), phase detection autofocus, 2x optical zoom, quad-LED (dual tone) flash, " +
                                                                "Vídeo: 2160p@24 / 30 / 60fps, 1080p@30 / 60 / 120 / 240fps, " +
                                                                "Câmara frontal: 7 MP, f / 2.2, 1080p@30fps, 720p@240fps, face detection, HDR, panorama",
                    ProdutoFK=8, CaracteristicaFK=12 },
                new DescricaoCaracteristica {ID=143, Descricao="WLAN: Wi-Fi 802.11 a/b/g/n/ac, dual-band, hotspot, " +
                                                                "Bluetooth: 5.0, A2DP, LE",
                    ProdutoFK=8, CaracteristicaFK=13 },
                new DescricaoCaracteristica {ID=144, Descricao="Impressão digital (frontal), acelerômetro, giroscópio, proximidade, bússola, barómetro",
                    ProdutoFK=8, CaracteristicaFK=14 },
                new DescricaoCaracteristica {ID=145, Descricao="Sim com suporte A-GPS, GLONASS, BDS, GALILEO",
                    ProdutoFK=8, CaracteristicaFK=15 },
                new DescricaoCaracteristica {ID=146, Descricao="Não removível Li-Ion 1821 mAh",
                    ProdutoFK=8, CaracteristicaFK=16 },
                new DescricaoCaracteristica {ID=147, Descricao="138.4 x 67.3 x 7.3 mm",
                    ProdutoFK=8, CaracteristicaFK=17 },
                new DescricaoCaracteristica {ID=148, Descricao="148 g",
                    ProdutoFK=8, CaracteristicaFK=18 },
            };
            desc.ForEach(aa => context.DescricaoCaracteristica.AddOrUpdate(a => a.ID, aa));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Equipamentos
            var equip = new List<Equipamentos> {
                new Equipamentos {NumSerie =Guid.NewGuid().ToString() , ProdutoFK=1 , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=1 , Vendido=false },
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=1 , Vendido=false },
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=1 , Vendido=false },
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=1 , Vendido=false },
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=2  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=3  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=3  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=3  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=3  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=3  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=3  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=4  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid().ToString() , ProdutoFK=4 , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=4 , Vendido=false },
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=4 , Vendido=false },
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=5  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=5  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=5  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=5  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=6  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=6  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=6  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=6  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=6  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=6  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=6  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=8  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=8  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=8  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=8  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=8  , Vendido=false},
                new Equipamentos {NumSerie =Guid.NewGuid ().ToString() , ProdutoFK=8  , Vendido=false},
            };
            equip.ForEach(aa => context.Equipamentos.AddOrUpdate(a => a.ID, aa));
            context.SaveChanges();

            
            //*********************************************************************
            // adiciona Imagens
            var imagens = new List<Imagens> {
                new Imagens {ID=1, Nome="/img/HuaweiY6-1.jpg", Ordem=1, ProdutoFK=1},
                new Imagens {ID=2, Nome="/img/HuaweiY6-2.jpg", Ordem=2, ProdutoFK=1},
                new Imagens {ID=3, Nome="/img/HuaweiY6-3.jpg", Ordem=3, ProdutoFK=1},
                new Imagens {ID=4, Nome="/img/HuaweiY6-4.jpg", Ordem=4, ProdutoFK=1},
                new Imagens {ID=5, Nome="/img/HuaweiY6-5.jpg", Ordem=5, ProdutoFK=1},
                new Imagens {ID=6, Nome="/img/HuaweiY6-6.jpg", Ordem=6, ProdutoFK=1},
                new Imagens {ID=7, Nome="/img/HuaweiY6-7.jpg", Ordem=7, ProdutoFK=1},
                new Imagens {ID=8, Nome="/img/HuaweiY6-8.jpg", Ordem=8, ProdutoFK=1},
                new Imagens {ID=9, Nome="/img/HuaweiY6-9.jpg", Ordem=9, ProdutoFK=1},
                new Imagens {ID=10, Nome="/img/HuaweiY6-10.jpg", Ordem=10, ProdutoFK=1},
                new Imagens {ID=11, Nome="/img/HuaweiY6-11.jpg", Ordem=11, ProdutoFK=1},
                new Imagens {ID=12, Nome="/img/HuaweiY6-12.jpg", Ordem=12, ProdutoFK=1},
                new Imagens {ID=13, Nome="/img/HuaweiY6-13.jpg", Ordem=13, ProdutoFK=1},
                new Imagens {ID=14, Nome="/img/iPhone7Gold-1.jpg", Ordem=1, ProdutoFK=2},
                new Imagens {ID=15, Nome="/img/iPhone7Gold-2.jpg", Ordem=2, ProdutoFK=2},
                new Imagens {ID=16, Nome="/img/XiaomiNote5APrimeCinzento-1.jpg", Ordem=1, ProdutoFK=3},
                new Imagens {ID=17, Nome="/img/XiaomiNote5APrimeCinzento-2.jpg", Ordem=2, ProdutoFK=3},
                new Imagens {ID=18, Nome="/img/XiaomiNote5APrimeCinzento-3.jpg", Ordem=3, ProdutoFK=3},
                new Imagens {ID=19, Nome="/img/XiaomiNote5APrimeCinzento-4.jpg", Ordem=4, ProdutoFK=3},
                new Imagens {ID=20, Nome="/img/Honor5XCinza-1.jpg", Ordem=1, ProdutoFK=4},
                new Imagens {ID=21, Nome="/img/Honor5XCinza-2.jpg", Ordem=2, ProdutoFK=4},
                new Imagens {ID=22, Nome="/img/Honor5XCinza-3.jpg", Ordem=3, ProdutoFK=4},
                new Imagens {ID=23, Nome="/img/Honor5XCinza-4.jpg", Ordem=4, ProdutoFK=4},
                new Imagens {ID=24, Nome="/img/Honor5XCinza-5.jpg", Ordem=5, ProdutoFK=4},
                new Imagens {ID=25, Nome="/img/Honor5XCinza-6.jpg", Ordem=6, ProdutoFK=4},
                new Imagens {ID=26, Nome="/img/MotorolaMotoG5Cinzento-1.jpg", Ordem=1, ProdutoFK=5},
                new Imagens {ID=27, Nome="/img/MotorolaMotoG5Cinzento-2.jpg", Ordem=2, ProdutoFK=5},
                new Imagens {ID=28, Nome="/img/MotorolaMotoG5Cinzento-3.jpg", Ordem=3, ProdutoFK=5},
                new Imagens {ID=29, Nome="/img/MotorolaMotoG5Cinzento-4.jpg", Ordem=4, ProdutoFK=5},
                new Imagens {ID=30, Nome="/img/LenovoMotoG4Branco-1.jpg", Ordem=1, ProdutoFK=6},
                new Imagens {ID=31, Nome="/img/LenovoMotoG4Branco-2.jpg", Ordem=2, ProdutoFK=6},
                new Imagens {ID=31, Nome="/img/MicrosoftLumia550Branco-1.jpg", Ordem=1, ProdutoFK=7},
                new Imagens {ID=32, Nome="/img/MicrosoftLumia550Branco-2.jpg", Ordem=2, ProdutoFK=7},
                new Imagens {ID=33, Nome="/img/MicrosoftLumia550Branco-3.jpg", Ordem=3, ProdutoFK=7},
                new Imagens {ID=34, Nome="/img/MicrosoftLumia550Branco-4.jpg", Ordem=4, ProdutoFK=7},
                new Imagens {ID=35, Nome="/img/AppleiPhone8Vermelho-1.jpg", Ordem=1, ProdutoFK=8},
                new Imagens {ID=36, Nome="/img/AppleiPhone8Vermelho-2.jpg", Ordem=2, ProdutoFK=8},
                new Imagens {ID=37, Nome="/img/AppleiPhone8Vermelho-3.jpg", Ordem=3, ProdutoFK=8},
                new Imagens {ID=38, Nome="/img/AppleiPhone8Vermelho-4.jpg", Ordem=4, ProdutoFK=8}
            };
            imagens.ForEach(aa => context.Imagens.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();



        }
    }
}

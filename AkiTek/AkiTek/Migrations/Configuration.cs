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
            // adiciona Componentes
            var componentes = new List<Componente> {
                new Componente {ID=1, Nome="Processador Intel Core i5-8600 Quad-Core, 3.00 GHz com Turbo até 3.50 GHz, 6 MB Cache", Categoria="Processador", Descricao="Este modelo inclui Cooler"},
                new Componente {ID=2, Nome="Gráfica MSI GeForce GTX 1050 Ti Gaming X 4G", Categoria="Placa Gráfica", Descricao="A experiência de jogo mais suave e mais rápida cada vez mais emocionante eliminando o screen tearing shutter e input lag com a NVIDIA G-SYNC"},
                new Componente {ID=3, Nome="Motherboard ATX MSI Z370 GAMING PLUS", Categoria="Motherboard", Descricao="Esta motherboard foi projetada para utilizar plenamente os processadores Intel Coffee Lake"},

                new Componente {ID=4, Nome="Fonte Corsair VS650W", Categoria="Fonte de Alimentação", Descricao="Certificação 80Plus White"},
                new Componente {ID=5, Nome="Memória RAM G.SKILL Aegis 16GB (2x8GB)", Categoria="Memória RAM", Descricao="DDR4-3000MHz CL16 Preta"},
                new Componente {ID=6, Nome="Caixa ATX Sharkoon VG5-W", Categoria="Caixa", Descricao="Led Vermelho com Janela Preta"},
                new Componente {ID=7, Nome="SSD 2.5 SanDisk Plus 240GB", Categoria="Armazenamento", Descricao="MLC SATA"},
                new Componente {ID=8, Nome="HDD 3.5 Seagate Barracuda 1TB", Categoria="Armazenamento", Descricao="7200RPM 64MB SATA III"},

                new Componente {ID=9, Nome="Processador AMD Ryzen 5 2600 Hexa-Core 3.4GHz c/ Turbo 3.9GHz 19MB SktAM4", Categoria="Processador", Descricao="Inclui Cooler CPU Wraith Stealth cooler"},
                new Componente {ID=10, Nome="Gráfica Asus ROG Strix Radeon RX 560 OC 4GB", Categoria="Placa Gráfica", Descricao="Iluminação Aura RGB"},
                new Componente {ID=11, Nome="Motherboard ATX Asus ROG Strix X370-F Gaming", Categoria="Motherboard", Descricao="Suporta CPU AMD Série RYZEN, Iluminação Aura RGB"},
                new Componente {ID=12, Nome="Monitor Asus VP228HE TN 21.5 FHD 16:9 60Hz", Categoria="Monitor", Descricao="Tempo de Resposta de 1ms"},
                new Componente {ID=13, Nome="Rato Asus ROG Strix Impact Gaming Preto", Categoria="Rato", Descricao="Iluminação Aura RGB"},
                new Componente {ID=14, Nome="Teclado Asus Cerberus PT Gaming", Categoria="Teclado", Descricao="Teclado de membrana e teclas retroiluminadas em 2 cores"},
                new Componente {ID=15, Nome="Tapete Asus ROG Strix Edge", Categoria="Tapete", Descricao="Base de borracha antiderrapante"}
            };
            componentes.ForEach(aa => context.Componentes.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Computadores
            var computadores = new List<Computador> {
                new Computador {ID=1, Nome="Computador MSI Rising Star 5X", Preco=new Decimal(1049.00), //CompraFK=1,
                    ListaComponentes =new List<Componente>{ componentes[0], componentes[1],componentes[2], componentes[3],componentes[4], componentes[5], componentes[6], componentes[7] } },
                new Computador {ID=2, Nome="Computador MSI Rising Star 5X", Preco=new Decimal(1049.00), //CompraFK=2,
                    ListaComponentes =new List<Componente>{ componentes[0], componentes[1],componentes[2], componentes[3],componentes[4], componentes[5], componentes[6], componentes[7] } },
                new Computador {ID=3, Nome="Computador ASUS Legend TXF3 - All in One ", Preco=new Decimal(1299.00), //CompraFK=3,
                    ListaComponentes =new List<Componente>{ componentes[3],componentes[4], componentes[5], componentes[6], componentes[7], componentes[8], componentes[9], componentes[10], componentes[11], componentes[12], componentes[13], componentes[14] } },
                new Computador {ID=4, Nome="Computador ASUS Legend TXF3 - All in One ", Preco=new Decimal(1299.00), //CompraFK=4,
                    ListaComponentes =new List<Componente>{ componentes[3],componentes[4], componentes[5], componentes[6], componentes[7], componentes[8], componentes[9], componentes[10], componentes[11], componentes[12], componentes[13], componentes[14] } }
            };
            computadores.ForEach(aa => context.Computadores.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Compras
            var compras = new List<Compra> {
                new Compra {NumFatura=1, DataCompra=new DateTime(2017,05,02), ClienteFK=1, ComputadorFK=1 },
                new Compra {NumFatura=2, DataCompra=new DateTime(2016,04,29), ClienteFK=2, ComputadorFK=2 },
                new Compra {NumFatura=3, DataCompra=new DateTime(2018,07,13), ClienteFK=3, ComputadorFK=3 },
                new Compra {NumFatura=4, DataCompra=new DateTime(2018,07,13), ClienteFK=3, ComputadorFK=4 }
            };
            compras.ForEach(aa => context.Compras.AddOrUpdate(a => a.NumFatura, aa));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Imagens
            var imagens = new List<Imagem> {
                new Imagem {ID=1, Nome="Completa", Ordem=1, ComputadorFK=1},
                new Imagem {ID=2, Nome="Processador", Ordem=2, ComputadorFK=1},
                new Imagem {ID=3, Nome="Gráfica", Ordem=3, ComputadorFK=1},
                new Imagem {ID=4, Nome="Motherbord", Ordem=4, ComputadorFK=1},
                new Imagem {ID=5, Nome="Fonte", Ordem=5, ComputadorFK=1},
                new Imagem {ID=6, Nome="Memória", Ordem=6, ComputadorFK=1},
                new Imagem {ID=7, Nome="Caixa", Ordem=7, ComputadorFK=1},
                new Imagem {ID=8, Nome="SSD", Ordem=8, ComputadorFK=1},
                new Imagem {ID=9, Nome="HDD", Ordem=9, ComputadorFK=1},


                new Imagem {ID=10, Nome="Completa", Ordem=1, ComputadorFK=2},
                new Imagem {ID=11, Nome="Processador", Ordem=2, ComputadorFK=2},
                new Imagem {ID=12, Nome="Gráfica", Ordem=3, ComputadorFK=2},
                new Imagem {ID=13, Nome="Motherbord", Ordem=4, ComputadorFK=2},
                new Imagem {ID=14, Nome="Fonte", Ordem=5, ComputadorFK=2},
                new Imagem {ID=15, Nome="Memória", Ordem=6, ComputadorFK=2},
                new Imagem {ID=16, Nome="Caixa", Ordem=7, ComputadorFK=2},
                new Imagem {ID=17, Nome="SSD", Ordem=8, ComputadorFK=2},
                new Imagem {ID=18, Nome="HDD", Ordem=9, ComputadorFK=2},
                new Imagem {ID=19, Nome="Monitor", Ordem=10, ComputadorFK=2},
                new Imagem {ID=20, Nome="Rato", Ordem=11, ComputadorFK=2},
                new Imagem {ID=21, Nome="Teclado", Ordem=12, ComputadorFK=2},
                new Imagem {ID=22, Nome="Tapete", Ordem=13, ComputadorFK=2},
            };
            imagens.ForEach(aa => context.Imagens.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();



        }
    }
}

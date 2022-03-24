/*using System.Data;

using InfraComanda.Domain;
using Microsoft.EntityFrameworkCore;


namespace AppComanda
{
    class Program
    {

        static void Main(string[] args)
        {


            using var db = new InfraComanda.Data.ApplicationContext();

            var existe = db.Database.GetPendingMigrations().Any();

            if (existe)
            {
                Console.WriteLine("Migration Pendente");
            }
            Console.WriteLine("Bem vindo!");
            //InserirDados();
            //InserirDadosEmMassa();
            //ConsultarDados();
            //CadastrarPedido();

            Console.WriteLine("Escolha a opção:");
            Console.Write("1-CADASTRAR| 2-CONSULTAR CONEXÃO | 0-FINALIZAR ");
            int EntradaConsole = int.Parse(Console.ReadLine());
            while (EntradaConsole > 0)
            {

                switch (EntradaConsole)
                {
                    case 1:
                        CadastrarPedido();
                        break;
                    case 2:
                        HealthCheckBancoDeDados();
                        break;
                    case 3:
                        Console.WriteLine("Em Produção!");
                        break;
                    case 4:
                        Console.WriteLine("Em Produção!");
                        break;


                }
                Console.WriteLine("Deseja continuar? ");
                Console.Write("1-SIM | 2-NÃO ");
                int EntradaSaida = int.Parse(Console.ReadLine());
                if (EntradaSaida == 1)
                {
                    Console.Write("1-CADASTRAR| 2-CONSULTAR CONEXÃO | 0-FINALIZAR");
                    EntradaConsole = int.Parse(Console.ReadLine());

                }
                else
                {
                    EntradaConsole = 0;
                    System.Console.WriteLine("Obrigado e volte sempre!");
                }



            }




        }
        private static void CadastrarPedido()
        {
            using var db = new InfraComanda.Data.ApplicationContext();
            var cliente = db.Clientes.FirstOrDefault();
            var produto = db.Produtos.FirstOrDefault();
            int DescontoItem = 0;

            Console.WriteLine("Insira o código do cliente");
            int CodCliente = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o numero da mesa");
            int CodMesa = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o Código do produto");
            int CodProduto = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de itens");
            int QuantidadeItem = int.Parse(Console.ReadLine());

            Console.WriteLine("Item Possui Desconto? 1-SIM | 2-NÃO");
            int DescItem = int.Parse(Console.ReadLine());



            if (DescItem == 1)
            {
                DescontoItem = int.Parse(Console.ReadLine());

            }



            var pedido = new Pedido
            {
                ClienteId = CodCliente,
                MesaId = CodMesa,
                Observacao = "Pedido Teste",
                Status = StatusPedido.Producao,
                Itens = new List<PedidoItem>
                {
                    new PedidoItem
                    {
                        ProdutoId   = CodProduto,
                        Valor       = 10M,
                        Desconto    = DescontoItem,
                        Quantidade  = QuantidadeItem,



                    }

                },
                FinalizadoEm = DateTime.Now,
            };


            db.AddRange(pedido);
            var registros = db.SaveChanges();
            Console.WriteLine($"Total Registro(s):{registros}");

        }



        private static void SalvarDados()
        {

            using var db = new InfraComanda.Data.ApplicationContext();
            var registros = db.SaveChanges();
            Console.WriteLine($"Total Registro(s):{registros}");

        }
        private static void InserirDadosEmMassa()
        {
            var produto = new Produto
            {
                CodigoBarras = "1525695823",
                Descricao = "Refrigerante",
                Valor = 210m,
                TipoProduto = TipoProduto.MercadoriaParaRevenda,
                Ativo = true

            };

            var listaClienteS = new[]
            {
                new Cliente
                {
                Nome     = "yam 1",
                Telefone = "992450461",
                Cep      = "76828634",
                Cidade   = "Porto velho",
                Estado   = "Ro"

                },
                new Cliente
                {
               Nome     = "yam 2",
               Telefone = "992450461",
               Cep      = "76828634",
               Cidade   = "Porto velho",
               Estado   = "Ro"

                },

            };

            var mesa = new Mesa
            {
                Ativo = true,
                Status = StatusMesa.Disponivel

            };

            using var db = new InfraComanda.Data.ApplicationContext();
            db.Clientes.AddRange(listaClienteS);
            db.AddRange(produto);
            db.AddRange(mesa);

            var registros = db.SaveChanges();
            Console.WriteLine($"Total Registro(s):{registros}");
            SalvarDados();


            //db.Produtos.Add(produto);
            //db.Clientes.Add(Cliente);
            //db.Set<Produto>().Add(produto);
            //db.Entry(produto).State = EntityState.Added;
            //db.Add(produto);




        }
        private static void ConsultarDados()
        {
            using var db = new InfraComanda.Data.ApplicationContext();
            // var consultarPorSintaxe = (from c in db.Clientes.AsNoTracking() where c.Id>0 select c).ToList();
            var consultarPorMetodo = db.Clientes.Where(p => p.Id > 0).ToList();
            foreach (var cliente in consultarPorMetodo)
            {

                // db.Clientes.Find(cliente.Id); 
                Console.WriteLine($"Consultando Cliente{cliente.Id}");
                db.Clientes.FirstOrDefault(p => p.Id == cliente.Id);
            }


        }
        private static void InserirDados()
        {
            var produto = new Produto
            {
                CodigoBarras = "12345678911112",
                Descricao = "Produto Teste",
                Valor = 10m,
                TipoProduto = TipoProduto.MercadoriaParaRevenda,
                Ativo = true

            };
            using var db = new InfraComanda.Data.ApplicationContext();
            db.Produtos.Add(produto);
            //db.Set<Produto>().Add(produto);
            //db.Entry(produto).State = EntityState.Added;
            //db.Add(produto);

            var registros = db.SaveChanges();
            Console.WriteLine($"Total Registro(s):{registros}");







        }
        static void HealthCheckBancoDeDados()
        {
            using var db = new InfraComanda.Data.ApplicationContext();
            //OPÇÃO DE CONEXÃO NATIVA ENTITY
            var canConnect = db.Database.CanConnect();
            try
            {
                //1° OPÇÃO DE CONEXÃO 
                var connection = db.Database.GetDbConnection();
                connection.Open();
                Console.WriteLine("CONEXÃO ATIVA!");

            }
            catch (Exception)
            {
                Console.WriteLine("CONEXÃO INATIVA!");
            }
        }

    }
}
*/

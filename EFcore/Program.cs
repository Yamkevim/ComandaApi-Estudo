using System.IO.Enumeration;
using System.Data;
using System.Data.Common;
using System;
using System.Linq;
using EFcore.Domain;
using Microsoft.EntityFrameworkCore;
using EFcore.ValueObjects;
using System.Collections.Generic;

namespace EFcore
{
    class Program
    {
        static void Main(string[] args)
        {
            

            using var db = new Data.ApplicationContext();

            var existe = db.Database.GetPendingMigrations().Any();
            
            if(existe)
            {
               Console.WriteLine("Funcionando");
            }
            Console.WriteLine("Bem vindo!");
            //InserirDados();
           // InserirDadosEmMassa();
            //ConsultarDados();
            CadastrarPedido();

        }
        private static void CadastrarPedido()
        {
            using var db = new Data.ApplicationContext();
            var cliente = db.Clientes.FirstOrDefault();
            var produto = db.Produtos.FirstOrDefault();

            var pedido = new Pedido
            {
                ClienteId       = cliente.Id,
                IniciadoEm      = DateTime.Now,
                FinalizadoEm    = DateTime.Now,
                Observacao      = "Pedido Teste",
                Status          = StatusPedido.Aguardando,
                TipoFrete       = TipoFrete.SemFrete,
                Itens = new List<PedidoItem>
                {
                    new PedidoItem
                    {
                        ProdutoId   = produto.Id,
                        Desconto    = 0,
                        Quantidade  = 1,
                        Valor       = 10,


                    }
                }
            };
            db.Pedidos.Add(pedido);
            SalvarDados();
        }
        private static void SalvarDados()
        {
         using var db = new Data.ApplicationContext();
         var registros = db.SaveChanges();
         Console.WriteLine($"Total Registro(s):{registros}");

        }
        private static void InserirDadosEmMassa()
        {
            var produto =  new Produto
            {
                CodigoBarras = "152569582",
                Descricao    = "Refrigerante",
                Valor        = 210m,
                TipoProduto  = ValueObjects.TipoProduto.MercadoriaParaRevenda,
                Ativo        = true

            };

            var listaClienteS =  new []
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
            

            using var db = new Data.ApplicationContext();
            db.Clientes.AddRange(listaClienteS);
            db.AddRange(produto);
            //db.Produtos.Add(produto);
            //db.Clientes.Add(Cliente);
         //db.Set<Produto>().Add(produto);
         //db.Entry(produto).State = EntityState.Added;
         //db.Add(produto);

         


        }
        private static void ConsultarDados()
         {
            using var db = new Data.ApplicationContext();
            // var consultarPorSintaxe = (from c in db.Clientes.AsNoTracking() where c.Id>0 select c).ToList();
             var consultarPorMetodo = db.Clientes.Where(p=> p.Id>0).ToList();
             foreach(var cliente in consultarPorMetodo)
             {
                
              // db.Clientes.Find(cliente.Id); 
                Console.WriteLine($"Consultando Cliente{cliente.Id}"); 
                db.Clientes.FirstOrDefault(p=>p.Id==cliente.Id);
             }


         }
        private static void InserirDados()
        {
            var produto =  new Produto
            {
                CodigoBarras = "12345678911112",
                Descricao = "Produto Teste",
                Valor = 10m,
                TipoProduto = ValueObjects.TipoProduto.MercadoriaParaRevenda,
                Ativo = true

            };
         using var db = new Data.ApplicationContext();
         db.Produtos.Add(produto);
         //db.Set<Produto>().Add(produto);
         //db.Entry(produto).State = EntityState.Added;
         //db.Add(produto);

         var registros = db.SaveChanges();
         Console.WriteLine($"Total Registro(s):{registros}");

         





        }
    }
}

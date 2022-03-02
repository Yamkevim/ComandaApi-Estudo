using System;

namespace AppComanda.Domain{

public class PedidoItem{
       
    public int Id { get; set; }
    public int PedidoId { get; set; }
    public Pedido Pedido { get; set; }
    public int ProdutoId { get; set; }
    public Produto Produto { get; set; }
    public int Quantidade { get; set; }
    public decimal Valor { get; set; }
    public decimal  Desconto { get; set; }

    public decimal CadastrarDesconto(decimal Desconto)
    {
        return Valor += (Valor * Desconto) / 100;
    } 

    public  void ValidarEntrada()
    {
        if (Quantidade>20)
        {
            Console.WriteLine("Lancamento de entrada de quantidade superior a permitida"); 
        };                 
    }            
         

    }
}
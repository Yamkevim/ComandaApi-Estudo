using System;
using System.Globalization;


namespace InfraComanda.Domain{
    public enum TipoProduto{
        MercadoriaParaRevenda,
        Embalagem,
        Servico,
    }
    public class Produto : EntityBase
    {
        

        public string? CodigoBarras { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor  { get; set; }
        public TipoProduto TipoProduto { get; set; }
        public bool Ativo  { get; set; }

        
        
       
    }
    
}
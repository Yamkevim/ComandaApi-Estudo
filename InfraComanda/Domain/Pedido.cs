using System.CodeDom.Compiler;
using System;
using System.Collections.Generic;
using InfraComanda.Domain;

namespace InfraComanda.Domain{
    
    public enum StatusPedido{
        Solicitado,
        Aguardando,
        Producao,
        finalizado,
    }
    public class Pedido : EntityBase{
        

        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public int MesaId { get; set; }
        public Mesa? Mesa { get; set; }
        public DateTime? FinalizadoEm { get; set; }
        public StatusPedido Status { get; set; }
        public string? Observacao { get; set; }
        public ICollection<PedidoItem>? Itens { get; set; }
        

        
    }
}
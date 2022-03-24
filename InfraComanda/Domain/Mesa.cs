using System;
using System.Collections.Generic;


namespace InfraComanda.Domain
{
    public enum StatusMesa
    {
        Ocupado,
        Disponivel,
        Reservado,
        
    }
    public class Mesa:EntityBase
    {
       
        
        public bool Ativo { get; set; }
        public StatusMesa Status { get; set; }



    }
}
using System;
using System.Collections.Generic;
using AppComanda.ValueObjects;

namespace AppComanda.Domain
{
    public class Mesa
    {
       
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public StatusMesa Status { get; set; }



    }
}
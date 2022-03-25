using BusinessComanda.Interfaces;
using InfraComanda.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ApiComanda.Controllers
{
    [Route("ApiComanda/[controller]")]


    public class ClienteController : IBaseRespository
    {
         [HttpPost]
        public void Add(Cliente Id)
        {
            throw new NotImplementedException();
        }
         [HttpGet]
        public Cliente Get(int Id)
        {
            throw new NotImplementedException();
        }

         [HttpDelete]
        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }
         [HttpPut]
        public void Update(Cliente Id)
        {
            throw new NotImplementedException();
        }
    }
}   
       
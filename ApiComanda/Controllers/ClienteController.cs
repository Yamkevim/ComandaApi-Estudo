using BusinessComanda.Interfaces;
using InfraComanda.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ApiComanda.Controllers
{
    [Route("ApiComanda/[controller]")]


    public class ClienteController : IBaseRespository
    {
        [HttpPost]
        public void Add(EntityBase Id)
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        public EntityBase Get(int Id)
        {
            throw new NotImplementedException();
        }
        
        [HttpDelete]
        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }
        [HttpPut]
        public void Update(EntityBase Id)
        {
            throw new NotImplementedException();
        }
    }
}   
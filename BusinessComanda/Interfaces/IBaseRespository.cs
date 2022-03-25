using InfraComanda.Domain;
namespace BusinessComanda.Interfaces
{
    public interface IBaseRespository
    {
        
        Cliente Get(int Id);
        void Add(Cliente Id);
        void Remove(int Id);
        void Update(Cliente Id);

         
    }
}
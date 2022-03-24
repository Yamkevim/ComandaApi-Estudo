using InfraComanda.Domain;
namespace BusinessComanda.Interfaces
{
    public interface IBaseRespository
    {
        
        EntityBase Get(int Id);
        void Add(EntityBase Id);
        void Remove(int Id);
        void Update(EntityBase Id);

         
    }
}
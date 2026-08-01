using MarketDB.Core.Entities;

namespace MarketDB.Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        List<T> GetAll();
        List<T> GetAllActive();
        void Add (T entity);
        void Update (T entity);
        void Delete (int id);
    }
}

using MarketDB.Core.Entities;
using MarketDB.Core.Interfaces;

namespace MarketDB.Core.Abstract
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : BaseEntity
    {
        public abstract T GetById(int id);
        public abstract List<T> GetAll();
        public abstract List<T> GetAllActive();

        public abstract void Add(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(int id);
        
    }
}

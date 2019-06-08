using System.Collections.Generic;

namespace Repository
{
    public interface IRepository<TEntity, in TSearch>
    {
        IEnumerable<TEntity> Get(TSearch search);
        TEntity GetById(string id);
        TEntity Add(TEntity obj);
        void Remove(string id);
        TEntity Update(TEntity obj);
    }
}
using System.Collections.Generic;

namespace WebAPI.Services.Interfaces
{
    public interface IBaseService<TEntity, in TSearch>
    {
        List<TEntity> Get(TSearch search);

        TEntity GetById(string id);
    }
}

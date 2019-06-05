using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{

    public class Repository<TEntity, TSearch> : IRepository<TEntity, TSearch> where TEntity : class
    {
        protected readonly DbSet<TEntity> DatabaseSet;
        protected readonly eTeatarContext Context;

        public Repository(eTeatarContext context)
        {
            Context = context;
            DatabaseSet = context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(TSearch search)
        {
            return DatabaseSet.AsEnumerable();
        }

        public TEntity GetById(string id)
        {
            return DatabaseSet.Find(id);
        }

        public virtual void Add(TEntity obj)
        {
            DatabaseSet.Add(obj);
            Context.SaveChanges();
        }

        public virtual TEntity Update(TEntity obj)
        {
            Context.Set<TEntity>().Attach(obj);
            Context.Set<TEntity>().Update(obj);
            
            Context.SaveChanges();
            return obj;
        }

        public void Remove(string id)
        {
            TEntity entity = DatabaseSet.Find(id);
            DatabaseSet.Remove(entity);
            Context.SaveChanges();
        }
    }
}
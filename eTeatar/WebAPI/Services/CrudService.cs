using AutoMapper;
using Repository;
using System;
using Microsoft.CodeAnalysis;
using WebAPI.Services.Interfaces;

namespace WebAPI.Services
{
    public class CrudService<TTransferObject, TSearch, TEntity, TInsert, TUpdate> : 
        BaseService<TTransferObject, TSearch, TEntity>, 
        ICrudService<TTransferObject, TSearch, TInsert, TUpdate> 
        where TEntity : class where TTransferObject : class
    {
        public CrudService(IMapper mapper, IRepository<TEntity, TSearch> repository) : base(mapper, repository)
        {
        }

        public virtual TTransferObject Insert(TInsert request)
        {
            var entity = Mapper.Map<TEntity>(request);
            Repository.Add(entity);
            return Mapper.Map<TTransferObject>(entity);
        }

        public virtual TTransferObject Update(string id, TUpdate request)
        {
            var obj = Repository.GetById(id);
            Mapper.Map(request, obj);

            return Mapper.Map<TTransferObject>(Repository.Update(obj));
        }

        public void Delete(string id)
        {
            Repository.Remove(id);
        }
    }
}
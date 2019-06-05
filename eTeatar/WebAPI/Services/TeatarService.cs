using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataTransferObjects.Requests;
using Models;
using Repository;

namespace WebAPI.Services
{
    public class TeatarService : CrudService<DataTransferObjects.Teatar, TeatarSearchRequest, Models.Teatar, TeatarUpsertRequest, TeatarUpsertRequest>
    {
        public override List<DataTransferObjects.Teatar> Get(TeatarSearchRequest search)
        {
            IEnumerable<Teatar> list = Repository.Get(search);
            return Mapper.Map<List<DataTransferObjects.Teatar>>(list);
        }

        public TeatarService(IMapper mapper, IRepository<Models.Teatar, TeatarSearchRequest> repository) : base(mapper, repository)
        {
        }
    }
}

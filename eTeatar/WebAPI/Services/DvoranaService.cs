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
    public class DvoranaService : CrudService<DataTransferObjects.Dvorana, DvoranaSearchRequest, Models.Dvorana, DvoranaUpsertRequest, DvoranaUpsertRequest>
    {
        public override List<DataTransferObjects.Dvorana> Get(DvoranaSearchRequest search)
        {
            IEnumerable<Dvorana> list = Repository.Get(search);
            return Mapper.Map<List<DataTransferObjects.Dvorana>>(list);
        }
        public DvoranaService(IMapper mapper, IRepository<Dvorana, DvoranaSearchRequest> repository) : base(mapper, repository)
        {
        }
    }
}

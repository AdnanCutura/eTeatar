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
    public class GlumacService : CrudService<DataTransferObjects.Glumac,GlumacSearchRequest,Models.Glumac,GlumacUpsertRequest, GlumacUpsertRequest>
    {
        public GlumacService(IMapper mapper, IRepository<Glumac, GlumacSearchRequest> repository) : base(mapper, repository)
        {
        }

        public override List<DataTransferObjects.Glumac> Get(GlumacSearchRequest search)
        {
            IEnumerable<Glumac> list = Repository.Get(search);
            return Mapper.Map<List<DataTransferObjects.Glumac>>(list);
        }
    }
}

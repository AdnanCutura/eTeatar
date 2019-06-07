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
    public class ObavijestService : CrudService<DataTransferObjects.Obavijest,ObavijestSearchRequest, Models.Obavijest,ObavijestUpsertRequest, ObavijestUpsertRequest>
    {
        public ObavijestService(IMapper mapper, IRepository<Obavijest, ObavijestSearchRequest> repository) : base(mapper, repository)
        {
        }

        public override List<DataTransferObjects.Obavijest> Get(ObavijestSearchRequest search)
        {
            IEnumerable<Obavijest> list = Repository.Get(search);
            return Mapper.Map<List<DataTransferObjects.Obavijest>>(list);
        }
    }
}

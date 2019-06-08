using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Repository;

namespace WebAPI.Services
{
    public class NarudzbaService : CrudService<DataTransferObjects.Narudzba,object, Models.Narudzba, DataTransferObjects.Requests.NarudzbaInsertRequest, object>
    {
        public NarudzbaService(IMapper mapper, IRepository<Models.Narudzba, object> repository) : base(mapper, repository)
        {
        }

        public override DataTransferObjects.Narudzba Insert(DataTransferObjects.Requests.NarudzbaInsertRequest request)
        {
            var entity = Mapper.Map<Models.Narudzba>(request);
            entity.DatumKupovine = DateTime.Now;
            Repository.Add(entity);
            return Mapper.Map<DataTransferObjects.Narudzba>(entity);
        }
    }
}

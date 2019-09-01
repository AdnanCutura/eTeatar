using AutoMapper;
using DataTransferObjects;
using DataTransferObjects.Requests;
using Repository;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Services.Interfaces;

namespace WebAPI.Services
{
    public class PredstavaService : CrudService<DataTransferObjects.Predstava, DataTransferObjects.Requests.PredstavaSearchRequest, Models.Predstava, DataTransferObjects.Requests.PredstavaUpsertRequest, DataTransferObjects.Requests.PredstavaUpsertRequest>
    {
        private readonly IBaseService<DataTransferObjects.Zanr, DataTransferObjects.Requests.ZanrSearchRequest> _zanrService;
        private readonly ICrudService<DataTransferObjects.Ocjena, DataTransferObjects.Requests.OcjenaSearchRequest, DataTransferObjects.Requests.OcjenaInsertRequest, object> _ocjenaService;
        private readonly PredstavaRepository _repo;

        public PredstavaService(IMapper mapper, IRepository<Models.Predstava, DataTransferObjects.Requests.PredstavaSearchRequest> repository, IBaseService<DataTransferObjects.Zanr, DataTransferObjects.Requests.ZanrSearchRequest> zanrService, ICrudService<DataTransferObjects.Ocjena, DataTransferObjects.Requests.OcjenaSearchRequest, DataTransferObjects.Requests.OcjenaInsertRequest, object> ocjenaService, PredstavaRepository repo) : base(mapper, repository)
        {
            _zanrService = zanrService;
            _ocjenaService = ocjenaService;
            _repo = repo;
        }

        public override List<DataTransferObjects.Predstava> Get(DataTransferObjects.Requests.PredstavaSearchRequest search)
        {
            var queryresult = base.Get(search);

            //Dodavanje zanrova u model
            foreach (var result in queryresult)
            {
                result.Zanrovi = _zanrService.Get(new DataTransferObjects.Requests.ZanrSearchRequest { PredstavaId = result.Id });
                result.Ocjena = _ocjenaService.Get(new OcjenaSearchRequest { PredstavaId = result.Id })?.Average(a => a?.Vrijednost) ?? 0;
            }
            return queryresult;
        }

        public override Predstava GetById(string id)
        {
            var queryresult = base.GetById(id);

            queryresult.Zanrovi = _zanrService.Get(new DataTransferObjects.Requests.ZanrSearchRequest { PredstavaId = id });
            queryresult.Ocjena = _ocjenaService.Get(new OcjenaSearchRequest { PredstavaId = queryresult.Id })?.Average(a => a?.Vrijednost) ?? 0;
            return queryresult;
        }

        public override Predstava Update(string id, PredstavaUpsertRequest request)
        {
            var obj = Repository.GetById(id);
            Mapper.Map(request, obj);
            obj.Uloge = null;
            obj.Termini = null;
            return Mapper.Map<DataTransferObjects.Predstava>(Repository.Update(obj));
        }

        public List<Predstava> GetPreporucene(string predstavaId)
        {
            var preporucene = Mapper.Map<List<DataTransferObjects.Predstava>>(_repo.GetPreporucene(predstavaId));
            foreach (var item in preporucene)
                item.Ocjena = _ocjenaService.Get(new OcjenaSearchRequest { PredstavaId = item.Id })?.Average(a => a?.Vrijednost) ?? 0;

            return preporucene;
        }
    }
}

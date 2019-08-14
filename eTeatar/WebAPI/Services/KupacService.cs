using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataTransferObjects;
using DataTransferObjects.Requests;
using Models;
using Repository;
using WebAPI.Services.Interfaces;
using KorisnickaUloga = DataTransferObjects.KorisnickaUloga;
using TipKorisnika = DataTransferObjects.TipKorisnika;

namespace WebAPI.Services
{
    public class KupacService : CrudService<DataTransferObjects.Kupac, object, Models.Kupac, KupacKorisnickiNalogUpsertRequest, KupacKorisnickiNalogUpsertRequest>
    {
        private readonly IKorisnickiNalogService _korisnickiNalogService;
        private readonly IBaseService<DataTransferObjects.TipKorisnika, TipKorisnikaSearchRequest> _tipKorisnikaService;

        public KupacService(IMapper mapper, IRepository<Models.Kupac, object> repository, IKorisnickiNalogService korisnickiNalogService, IBaseService<TipKorisnika, TipKorisnikaSearchRequest> tipKorisnikaService) : base(mapper, repository)
        {
            _tipKorisnikaService = tipKorisnikaService;
            _korisnickiNalogService = korisnickiNalogService;
        }

        public override DataTransferObjects.Kupac Insert(KupacKorisnickiNalogUpsertRequest request)
        {
            var nalog = Mapper.Map<KorisnickiNalogUpsertRequest>(request);
            var nalogResponse = _korisnickiNalogService.Insert(nalog, DataTransferObjects.Enums.KorisnickeUloge.Kupac);

            var kupac = new KupacUpsertRequest
            {
                KorisnickiNalogId = nalogResponse.Id,
                TipKorisnikaId = _tipKorisnikaService.Get(new TipKorisnikaSearchRequest { IsOsnovni = true }).FirstOrDefault()?.Id,
            };

            DataTransferObjects.Kupac returnmodel = Mapper.Map<DataTransferObjects.Kupac>(Repository.Add(Mapper.Map<Models.Kupac>(kupac)));
            string id = returnmodel.Id;
            Mapper.Map(nalogResponse, returnmodel);
            returnmodel.Id = id;
            return returnmodel;
        }

        public override List<DataTransferObjects.Kupac> Get(object search)
        {
            var returnmodel = base.Get(search);
            foreach (var model in returnmodel)
            {
                var id = model.Id;
                Mapper.Map(_korisnickiNalogService.GetById(model.KorisnickiNalogId), model);
                model.Id = id;
            }
            return returnmodel;
        }

        public override DataTransferObjects.Kupac GetById(string id)
        {
            var returnmodel = base.GetById(id);
            Mapper.Map(_korisnickiNalogService.GetById(returnmodel.KorisnickiNalogId), returnmodel);
            returnmodel.Id = id;
            return returnmodel;
        }

        public override DataTransferObjects.Kupac Update(string id, KupacKorisnickiNalogUpsertRequest request)
        {
            var nalogRequest = Mapper.Map<KorisnickiNalogUpsertRequest>(request);
            var kupacRequest = Mapper.Map<KupacUpsertRequest>(request);

            var kupac = Repository.GetById(id);

            kupacRequest.KorisnickiNalogId = kupac.KorisnickiNalogId;
            Mapper.Map(kupacRequest, kupac);

            Repository.Update(kupac);
            var kupacResponse = Mapper.Map<DataTransferObjects.Kupac>(kupac);
            var tipKorisnika = _tipKorisnikaService.GetById(kupac.TipKorisnikaId);

            var nalogResponse = _korisnickiNalogService.Update(kupac.KorisnickiNalogId, nalogRequest);

            var kupacId = kupacResponse.Id;
            Mapper.Map(nalogResponse, kupacResponse);

            kupacResponse.Id = kupacId;
            kupacResponse.TipKorisnika = tipKorisnika;

            return kupacResponse;
        }
    }
}

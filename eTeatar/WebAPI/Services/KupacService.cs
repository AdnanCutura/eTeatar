using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
        private readonly IBaseService<DataTransferObjects.KorisnickaUloga, KorisnickaUlogaSearchRequest> _korisnickaUlogaService;

        public KupacService(IMapper mapper, IRepository<Kupac, object> repository, IKorisnickiNalogService korisnickiNalogService, IBaseService<TipKorisnika, TipKorisnikaSearchRequest> tipKorisnikaService, IBaseService<KorisnickaUloga, KorisnickaUlogaSearchRequest> korisnickaUlogaService) : base(mapper, repository)
        {
            _tipKorisnikaService = tipKorisnikaService;
            _korisnickaUlogaService = korisnickaUlogaService;
            _korisnickiNalogService = korisnickiNalogService;
        }

        public override DataTransferObjects.Kupac Insert(KupacKorisnickiNalogUpsertRequest request)
        {
            var nalog = Mapper.Map<KorisnickiNalogUpsertRequest>(request);
            nalog.KorisnickaUlogaId = _korisnickaUlogaService.Get(new KorisnickaUlogaSearchRequest { Naziv = DataTransferObjects.Enums.KorisnickeUloge.Kupac.ToString() }).FirstOrDefault()?.Id;

            var nalogResponse = _korisnickiNalogService.Insert(nalog);

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
    }
}

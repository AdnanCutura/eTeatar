using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataTransferObjects.Requests;
using Models;
using Repository;
using WebAPI.Services.Interfaces;

namespace WebAPI.Services
{
    public class KupacService : CrudService<DataTransferObjects.Kupac, object, Models.Kupac, KupacUpsertRequest, KupacUpsertRequest>
    {
        private readonly IKorisnickiNalogService _korisnickiNalogService;

        public KupacService(IMapper mapper, IRepository<Kupac, object> repository, IKorisnickiNalogService korisnickiNalogService) : base(mapper, repository)
        {
            _korisnickiNalogService = korisnickiNalogService;
        }

        public override DataTransferObjects.Kupac Insert(KupacUpsertRequest request)
        {
            var req2 = Mapper.Map<KorisnickiNalogUpsertRequest>(request);
            var response = _korisnickiNalogService.Insert(req2);
            request.KorisnickiNalogId = response.Id;
            //TODO: Korisnicka uloga
            //TODO: TipKorisnika
            var returnmodel = base.Insert(request);
            Mapper.Map(response,returnmodel);
            return returnmodel;
        }
    }
}

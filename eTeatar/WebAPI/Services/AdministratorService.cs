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
    public class AdministratorService : CrudService<DataTransferObjects.Administrator, object, Models.Administrator, AdministratorUpsertRequest, AdministratorUpsertRequest>
    {
        private readonly IKorisnickiNalogService _korisnickiNalogService;

        public AdministratorService(IMapper mapper, IRepository<Administrator, object> repository, IKorisnickiNalogService korisnickiNalogService) : base(mapper, repository)
        {
            _korisnickiNalogService = korisnickiNalogService;
        }

        public override DataTransferObjects.Administrator Insert(AdministratorUpsertRequest request)
        {
            var req2 = Mapper.Map<KorisnickiNalogUpsertRequest>(request);
            var response = _korisnickiNalogService.Insert(req2);
            request.KorisnickiNalogId = response.Id;
            //TODO: Korisnicka uloga
            var returnmodel = base.Insert(request);
            Mapper.Map(response,returnmodel);
            return returnmodel;
        }
    }
}

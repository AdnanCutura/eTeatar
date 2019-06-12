using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataTransferObjects;
using DataTransferObjects.Requests;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Models;
using Repository;
using WebAPI.Services.Interfaces;
using KorisnickaUloga = DataTransferObjects.KorisnickaUloga;

namespace WebAPI.Services
{
    public class AdministratorService : CrudService<DataTransferObjects.Administrator, object, Models.Administrator, AdministratorKorisnickiNalogUpsertRequest, AdministratorKorisnickiNalogUpsertRequest>
    {
        private readonly IKorisnickiNalogService _korisnickiNalogService;

        public AdministratorService(IMapper mapper, IRepository<Models.Administrator, object> repository, IKorisnickiNalogService korisnickiNalogService) : base(mapper, repository)
        {
            _korisnickiNalogService = korisnickiNalogService;
        }


        public override DataTransferObjects.Administrator Insert(AdministratorKorisnickiNalogUpsertRequest request)
        {
            var nalog = Mapper.Map<KorisnickiNalogUpsertRequest>(request);
            var nalogResponse = _korisnickiNalogService.Insert(nalog, DataTransferObjects.Enums.KorisnickeUloge.Administrator);

            var admin = new AdministratorUpsertRequest
            {
                KorisnickiNalogId = nalogResponse.Id,
            };

            DataTransferObjects.Administrator returnmodel = Mapper.Map<DataTransferObjects.Administrator>(Repository.Add(Mapper.Map<Models.Administrator>(admin)));
            string id = returnmodel.Id;
            Mapper.Map(nalogResponse, returnmodel);
            returnmodel.Id = id;
            return returnmodel;
        }


        public override DataTransferObjects.Administrator Update(string id, AdministratorKorisnickiNalogUpsertRequest request)
        {
            var nalogRequest = Mapper.Map<KorisnickiNalogUpsertRequest>(request);
            var adminRequest = Mapper.Map<AdministratorUpsertRequest>(request);


            var admin = Repository.GetById(id);
            adminRequest.KorisnickiNalogId = admin.KorisnickiNalogId;
            Mapper.Map(adminRequest, admin);
            var adminResponse = Mapper.Map<DataTransferObjects.Administrator>(admin);
            Repository.Update(admin);

            var nalogResponse = _korisnickiNalogService.Update(admin.KorisnickiNalogId, nalogRequest);

            var Id = adminResponse.Id;
            Mapper.Map(nalogResponse, adminResponse);
            adminResponse.Id = Id;
            return adminResponse;
        }

        public override List<DataTransferObjects.Administrator> Get(object search)
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

        public override DataTransferObjects.Administrator GetById(string id)
        {
            var returnmodel = base.GetById(id);
            Mapper.Map(_korisnickiNalogService.GetById(returnmodel.KorisnickiNalogId), returnmodel);
            returnmodel.Id = id;
            return returnmodel;
        }
    }
}

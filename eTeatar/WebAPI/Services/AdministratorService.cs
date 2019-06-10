﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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

        public AdministratorService(IMapper mapper, IRepository<Administrator, object> repository, IKorisnickiNalogService korisnickiNalogService) : base(mapper, repository)
        {
            _korisnickiNalogService = korisnickiNalogService;
        }


        public override DataTransferObjects.Administrator Insert(AdministratorKorisnickiNalogUpsertRequest request)
        {
            var nalog = Mapper.Map<KorisnickiNalogUpsertRequest>(request);
            var nalogResponse = _korisnickiNalogService.Insert(nalog, DataTransferObjects.Enums.KorisnickeUloge.Administrator);

            var kupac = new AdministratorUpsertRequest
            {
                KorisnickiNalogId = nalogResponse.Id,
            };

            DataTransferObjects.Administrator returnmodel = Mapper.Map<DataTransferObjects.Administrator>(Repository.Add(Mapper.Map<Models.Administrator>(kupac)));
            string id = returnmodel.Id;
            Mapper.Map(nalogResponse, returnmodel);
            returnmodel.Id = id;
            return returnmodel;
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

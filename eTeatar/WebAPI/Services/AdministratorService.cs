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
        private readonly IBaseService<DataTransferObjects.KorisnickaUloga, KorisnickaUlogaSearchRequest> _korisnickaUlogaService;

        public AdministratorService(IMapper mapper, IRepository<Administrator, object> repository, IBaseService<KorisnickaUloga, KorisnickaUlogaSearchRequest> korisnickaUlogaService, IKorisnickiNalogService korisnickiNalogService) : base(mapper, repository)
        {
            _korisnickaUlogaService = korisnickaUlogaService;
            _korisnickiNalogService = korisnickiNalogService;
        }


        public override DataTransferObjects.Administrator Insert(AdministratorKorisnickiNalogUpsertRequest request)
        {
            var nalog = Mapper.Map<KorisnickiNalogUpsertRequest>(request);
            var ulogaId = _korisnickaUlogaService.Get(new KorisnickaUlogaSearchRequest { Naziv = DataTransferObjects.Enums.KorisnickeUloge.Administrator.ToString() }).FirstOrDefault()?.Id;
            
            nalog.KorisnickaUlogaId = ulogaId;

            var nalogResponse = _korisnickiNalogService.Insert(nalog);

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

       
    }
}
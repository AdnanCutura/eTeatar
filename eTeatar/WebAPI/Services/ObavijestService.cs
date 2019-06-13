using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataTransferObjects.Requests;
using Microsoft.AspNetCore.Rewrite.Internal.UrlMatches;
using Models;
using Repository;
using WebAPI.Services.Interfaces;
using Administrator = DataTransferObjects.Administrator;

namespace WebAPI.Services
{
    public class ObavijestService : CrudService<DataTransferObjects.Obavijest, ObavijestSearchRequest, Models.Obavijest, ObavijestUpsertRequest, ObavijestUpsertRequest>
    {

        private readonly
            ICrudService<DataTransferObjects.Administrator, object, AdministratorKorisnickiNalogUpsertRequest,
                AdministratorKorisnickiNalogUpsertRequest> _adminService;

        public ObavijestService(IMapper mapper, IRepository<Obavijest, ObavijestSearchRequest> repository, ICrudService<Administrator, object, AdministratorKorisnickiNalogUpsertRequest, AdministratorKorisnickiNalogUpsertRequest> adminService) : base(mapper, repository)
        {
            _adminService = adminService;
        }

        public override List<DataTransferObjects.Obavijest> Get(ObavijestSearchRequest search)
        {
            List<DataTransferObjects.Obavijest> list = base.Get(search);

            foreach (var i in list)
                i.Administrator = _adminService.GetById(i.AdministratorId);

            return list;
        }

        public override DataTransferObjects.Obavijest GetById(string id)
        {
            var item = base.GetById(id);
            item.Administrator = _adminService.GetById(item.AdministratorId);
            return item;
        }
    }
}

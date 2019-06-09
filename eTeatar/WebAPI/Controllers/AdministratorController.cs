using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTransferObjects;
using DataTransferObjects.Requests;
using Microsoft.AspNetCore.Authorization;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdministratorController : CrudController<DataTransferObjects.Administrator, object, DataTransferObjects.Requests.AdministratorKorisnickiNalogUpsertRequest, DataTransferObjects.Requests.AdministratorKorisnickiNalogUpsertRequest>
    {
        public AdministratorController(ICrudService<Administrator, object, AdministratorKorisnickiNalogUpsertRequest, AdministratorKorisnickiNalogUpsertRequest> service) : base(service)
        {
        }
    }
}

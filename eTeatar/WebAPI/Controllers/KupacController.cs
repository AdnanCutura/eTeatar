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
    [Authorize(Roles = "Kupac")]
    public class KupacController : CrudController<DataTransferObjects.Kupac, object, DataTransferObjects.Requests.KupacKorisnickiNalogUpsertRequest, DataTransferObjects.Requests.KupacKorisnickiNalogUpsertRequest>
    {
        public KupacController(ICrudService<Kupac, object, KupacKorisnickiNalogUpsertRequest, KupacKorisnickiNalogUpsertRequest> service) : base(service)
        {
        }
    }
}

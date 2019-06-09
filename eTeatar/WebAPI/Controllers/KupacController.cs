using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTransferObjects;
using DataTransferObjects.Requests;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    public class KupacController : CrudController<DataTransferObjects.Kupac, object, DataTransferObjects.Requests.KupacUpsertRequest, DataTransferObjects.Requests.KupacUpsertRequest>
    {
        public KupacController(ICrudService<Kupac, object, KupacUpsertRequest, KupacUpsertRequest> service) : base(service)
        {
        }
    }
}

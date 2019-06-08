using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTransferObjects;
using DataTransferObjects.Requests;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    public class KorisnickiNalogController : CrudController<DataTransferObjects.KorisnickiNalog,DataTransferObjects.Requests.KorisnickiNalogSearchRequest, DataTransferObjects.Requests.KorisnickiNalogUpsertRequest, DataTransferObjects.Requests.KorisnickiNalogUpsertRequest>
    {
        public KorisnickiNalogController(IKorisnickiNalogService service) : base(service)
        {
        }
    }
}

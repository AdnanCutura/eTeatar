using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTransferObjects;
using DataTransferObjects.Requests;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    public class KorisnickiNalogController : BaseController<DataTransferObjects.KorisnickiNalog,DataTransferObjects.Requests.KorisnickiNalogSearchRequest>
    {
        public KorisnickiNalogController(IKorisnickiNalogService service) : base(service)
        {
        }
    }
}

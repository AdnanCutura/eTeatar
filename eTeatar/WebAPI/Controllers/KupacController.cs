using System.Collections.Generic;
using DataTransferObjects;
using DataTransferObjects.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    [Authorize(Roles = "Kupac")]
    public class KupacController : CrudController<DataTransferObjects.Kupac, object, DataTransferObjects.Requests.KupacKorisnickiNalogInsertRequest, DataTransferObjects.Requests.KupacKorisnickiNalogUpdateRequest>
    {
        public KupacController(ICrudService<Kupac, object, KupacKorisnickiNalogInsertRequest, KupacKorisnickiNalogUpdateRequest> service) : base(service)
        {
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public override ActionResult<DataTransferObjects.Kupac> GetById(string id)
        {
            var obj = _service.GetById(id);

            if (obj == null)
                return NotFound();

            return obj;
        }

        [AllowAnonymous]
        public override ActionResult<Kupac> Insert(KupacKorisnickiNalogInsertRequest request)
        {
            return base.Insert(request);
        }

    }
}
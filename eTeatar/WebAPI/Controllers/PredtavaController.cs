using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Services;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    public class PredstavaController : CrudController<DataTransferObjects.Predstava, DataTransferObjects.Requests.PredstavaSearchRequest, DataTransferObjects.Requests.PredstavaUpsertRequest, DataTransferObjects.Requests.PredstavaUpsertRequest>
    {
        private readonly PredstavaService _predstavaService;
        public PredstavaController(ICrudService<DataTransferObjects.Predstava, DataTransferObjects.Requests.PredstavaSearchRequest, DataTransferObjects.Requests.PredstavaUpsertRequest, DataTransferObjects.Requests.PredstavaUpsertRequest> service, PredstavaService predstavaService) : base(service)
        {
            _predstavaService = predstavaService;
        }

        [HttpGet("GetPreporucene/{predstavaId}")]
        public ActionResult<List<DataTransferObjects.Predstava>> GetPreporucene(string predstavaId)
        {
            return _predstavaService.GetPreporucene(predstavaId);
        }
    }
}
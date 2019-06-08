using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    public class PredstavaController : CrudController<DataTransferObjects.Predstava, DataTransferObjects.Requests.PredstavaSearchRequest, DataTransferObjects.Requests.PredstavaUpsertRequest, DataTransferObjects.Requests.PredstavaUpsertRequest>
    {
        public PredstavaController(ICrudService<DataTransferObjects.Predstava, DataTransferObjects.Requests.PredstavaSearchRequest, DataTransferObjects.Requests.PredstavaUpsertRequest, DataTransferObjects.Requests.PredstavaUpsertRequest> service) : base(service)
        {
        }
    }
}
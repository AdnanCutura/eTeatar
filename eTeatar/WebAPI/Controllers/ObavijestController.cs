using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTransferObjects;
using DataTransferObjects.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    public class ObavijestController : CrudController<DataTransferObjects.Obavijest, ObavijestSearchRequest, ObavijestUpsertRequest, ObavijestUpsertRequest>
    {
        public ObavijestController(ICrudService<Obavijest, ObavijestSearchRequest, ObavijestUpsertRequest, ObavijestUpsertRequest> service) : base(service)
        {
        }
    }
}
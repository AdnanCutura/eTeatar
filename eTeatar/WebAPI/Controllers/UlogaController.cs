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
    public class UlogaController : CrudController<DataTransferObjects.Uloga,object, UlogaUpsertRequest, UlogaUpsertRequest>
    {
        public UlogaController(ICrudService<Uloga, object, UlogaUpsertRequest, UlogaUpsertRequest> service) : base(service)
        {
        }
    }
}
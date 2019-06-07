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
    public class TerminController : CrudController<DataTransferObjects.Termin,object,TerminUpsertRequest, TerminUpsertRequest>
    {
        public TerminController(ICrudService<Termin, object, TerminUpsertRequest, TerminUpsertRequest> service) : base(service)
        {
        }
    }
}
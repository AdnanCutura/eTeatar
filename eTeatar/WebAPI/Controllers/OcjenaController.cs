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
    public class OcjenaController : CrudController<DataTransferObjects.Ocjena, OcjenaSearchRequest, OcjenaInsertRequest, object>
    {
        public OcjenaController(ICrudService<Ocjena, OcjenaSearchRequest, OcjenaInsertRequest, object> service) : base(service)
        {
        }
    }
}
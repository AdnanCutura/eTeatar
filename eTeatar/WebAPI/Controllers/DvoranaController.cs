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
    public class DvoranaController : CrudController<DataTransferObjects.Dvorana,DvoranaSearchRequest,DvoranaUpsertRequest, DvoranaUpsertRequest>
    {
        public DvoranaController(ICrudService<Dvorana, DvoranaSearchRequest, DvoranaUpsertRequest, DvoranaUpsertRequest> service) : base(service)
        {
        }
    }
}
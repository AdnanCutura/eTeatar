using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpolController : BaseController<DataTransferObjects.Spol, object>
    {
        public SpolController(IBaseService<Spol, object> service) : base(service)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TDataTransferObject, TSearch> : ControllerBase where TDataTransferObject : class
    {
        private readonly IBaseService<TDataTransferObject, TSearch> _service;

        public BaseController(IBaseService<TDataTransferObject, TSearch> service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<TDataTransferObject>> Get([FromQuery] TSearch search)
        {
            return _service.Get(search);
        }

        [HttpGet("{id}")]
        public ActionResult<TDataTransferObject> GetById(string id)
        {
            var obj = _service.GetById(id);

            if (obj == null)
                return NotFound();
            return obj;
        }
    }
}
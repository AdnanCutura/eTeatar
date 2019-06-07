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
    public class GradController : BaseController<DataTransferObjects.Grad,object>
    {
        public GradController(IBaseService<Grad, object> service) : base(service)
        {
        }
    }
}
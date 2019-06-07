using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using WebAPI.Services.Interfaces;
using Drzava = DataTransferObjects.Drzava;

namespace WebAPI.Controllers
{
    public class DrzavaController : BaseController<DataTransferObjects.Drzava,object>
    {
        public DrzavaController(IBaseService<Drzava, object> service) : base(service)
        {
        }
    }
}
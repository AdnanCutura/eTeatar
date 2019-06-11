using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTransferObjects.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using WebAPI.Services.Interfaces;
using Zanr = DataTransferObjects.Zanr;

namespace WebAPI.Controllers
{
    public class ZanrController : BaseController<DataTransferObjects.Zanr,ZanrSearchRequest>
    {
        public ZanrController(IBaseService<Zanr, ZanrSearchRequest> service) : base(service)
        {
        }
    }
}
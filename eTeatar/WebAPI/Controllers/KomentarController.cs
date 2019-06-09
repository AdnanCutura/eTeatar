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
    public class KomentarController : CrudController<DataTransferObjects.Komentar,object, KomentarInsertRequest, object>
    {
        public KomentarController(ICrudService<Komentar, object, KomentarInsertRequest, object> service) : base(service)
        {
        }
    }
}
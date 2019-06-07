using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTransferObjects.Requests;
using Microsoft.AspNetCore.Mvc;
using Models;
using WebAPI.Services.Interfaces;
using TipSjedista = DataTransferObjects.TipSjedista;

namespace WebAPI.Controllers
{
    public class TipSjedistaController : CrudController<DataTransferObjects.TipSjedista,object,TipSjedistaUpsertRequest, TipSjedistaUpsertRequest>
    {
        public TipSjedistaController(ICrudService<TipSjedista, object, TipSjedistaUpsertRequest, TipSjedistaUpsertRequest> service) : base(service)
        {
        }
    }
}

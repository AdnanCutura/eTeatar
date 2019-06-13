using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTransferObjects;
using DataTransferObjects.Requests;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    public class PredstavaZanrController : CrudController<DataTransferObjects.PredstavaZanr, PredstavaZanrSearchRequest, DataTransferObjects.Requests.PredstavaZanrUpsertRequest, DataTransferObjects.Requests.PredstavaZanrUpsertRequest>
    {
        public PredstavaZanrController(ICrudService<PredstavaZanr, PredstavaZanrSearchRequest, PredstavaZanrUpsertRequest, PredstavaZanrUpsertRequest> service) : base(service)
        {
        }
    }
}

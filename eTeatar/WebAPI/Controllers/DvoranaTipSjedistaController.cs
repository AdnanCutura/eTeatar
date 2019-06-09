using DataTransferObjects;
using DataTransferObjects.Requests;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    public class DvoranaTipSjedistaController : CrudController<DataTransferObjects.DvoranaTipSjedista,object,DvoranaTipSjedistaUpsertRequest, DvoranaTipSjedistaUpsertRequest>
    {
        public DvoranaTipSjedistaController(ICrudService<DvoranaTipSjedista, object, DvoranaTipSjedistaUpsertRequest, DvoranaTipSjedistaUpsertRequest> service) : base(service)
        {
        }
    }
}
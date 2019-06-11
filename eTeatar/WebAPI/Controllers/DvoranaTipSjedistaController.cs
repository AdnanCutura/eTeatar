using DataTransferObjects;
using DataTransferObjects.Requests;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    public class DvoranaTipSjedistaController : CrudController<DataTransferObjects.DvoranaTipSjedista, DvoranaTipSjedistaSearchRequest, DvoranaTipSjedistaUpsertRequest, DvoranaTipSjedistaUpsertRequest>
    {
        public DvoranaTipSjedistaController(ICrudService<DvoranaTipSjedista, DvoranaTipSjedistaSearchRequest, DvoranaTipSjedistaUpsertRequest, DvoranaTipSjedistaUpsertRequest> service) : base(service)
        {
        }
    }
}
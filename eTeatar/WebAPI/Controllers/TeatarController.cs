using DataTransferObjects.Requests;
using WebAPI.Services.Interfaces;
using Teatar = DataTransferObjects.Teatar;

namespace WebAPI.Controllers
{

    public class TeatarController : CrudController<DataTransferObjects.Teatar, TeatarSearchRequest, TeatarUpsertRequest, TeatarUpsertRequest>
    {
        public TeatarController(ICrudService<DataTransferObjects.Teatar, TeatarSearchRequest, TeatarUpsertRequest, TeatarUpsertRequest> service) : base(service)
        {
        }
    }
}
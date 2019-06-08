using DataTransferObjects;
using DataTransferObjects.Requests;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    public class TerminController : CrudController<DataTransferObjects.Termin, TerminSearchRequest, TerminUpsertRequest, TerminUpsertRequest>
    {
        public TerminController(ICrudService<Termin, TerminSearchRequest, TerminUpsertRequest, TerminUpsertRequest> service) : base(service)
        {
        }
    }
}
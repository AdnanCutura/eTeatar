using DataTransferObjects;
using DataTransferObjects.Requests;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{

    public class NarudzbaController : CrudController<DataTransferObjects.Narudzba, NarudzbaSearchRequest, DataTransferObjects.Requests.NarudzbaInsertRequest, NarudzbaUpdateRequest>
    {
        public NarudzbaController(ICrudService<Narudzba, NarudzbaSearchRequest, NarudzbaInsertRequest, NarudzbaUpdateRequest> service) : base(service)
        {
        }
    }
}
using DataTransferObjects;
using DataTransferObjects.Requests;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{

    public class NarudzbaController : CrudController<DataTransferObjects.Narudzba, NarudzbaSearchRequest, DataTransferObjects.Requests.NarudzbaInsertRequest, object>
    {
        public NarudzbaController(ICrudService<Narudzba, NarudzbaSearchRequest, NarudzbaInsertRequest, object> service) : base(service)
        {
        }
    }
}
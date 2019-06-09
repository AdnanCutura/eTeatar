using DataTransferObjects;
using DataTransferObjects.Requests;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{

    public class NarudzbaController : CrudController<DataTransferObjects.Narudzba, object, DataTransferObjects.Requests.NarudzbaInsertRequest, object>
    {
        public NarudzbaController(ICrudService<Narudzba, object, NarudzbaInsertRequest, object> service) : base(service)
        {
        }
    }
}
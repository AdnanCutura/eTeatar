using DataTransferObjects;
using DataTransferObjects.Requests;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    public class KomentarController : CrudController<DataTransferObjects.Komentar, KomentarSearchRequest, KomentarInsertRequest, object>
    {
        public KomentarController(ICrudService<Komentar, KomentarSearchRequest, KomentarInsertRequest, object> service) : base(service)
        {
        }
    }
}
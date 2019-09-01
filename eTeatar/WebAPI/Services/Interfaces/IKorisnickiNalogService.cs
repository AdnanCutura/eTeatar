using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Services.Interfaces
{
    public interface IKorisnickiNalogService : ICrudService<DataTransferObjects.KorisnickiNalog, DataTransferObjects.Requests.KorisnickiNalogSearchRequest, DataTransferObjects.Requests.KorisnickiNalogInsertRequest, DataTransferObjects.Requests.KorisnickiNalogUpdateRequest>
    {
        Models.KorisnickiNalog Autentificiraj(string username, string pass);
        DataTransferObjects.KorisnickiNalog Insert(DataTransferObjects.Requests.KorisnickiNalogInsertRequest request, DataTransferObjects.Enums.KorisnickeUloge Uloga);
    }
}

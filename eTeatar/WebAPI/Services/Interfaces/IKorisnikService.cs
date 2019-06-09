using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Services.Interfaces
{
    public interface IKorisnikService : ICrudService<DataTransferObjects.Korisnik, DataTransferObjects.Requests.KorisnickiNalogSearchRequest, DataTransferObjects.Requests.KorisnickiNalogUpsertRequest, DataTransferObjects.Requests.KorisnickiNalogUpsertRequest>
    {
        Models.KorisnickiNalog Autentificiraj(string username, string pass);
    }
}

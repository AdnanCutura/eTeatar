using DataTransferObjects.Requests;
using Models;

namespace Repository
{
    public interface IKorisnickiNalogRepository: IRepository<Models.KorisnickiNalog, KorisnickiNalogSearchRequest>
    {
        KorisnickiNalog Autentificiraj(string korisnickoIme);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Repository;
using WebAPI.Services.Interfaces;

namespace WebAPI.Services
{
    public class NarudzbaService : CrudService<DataTransferObjects.Narudzba, object, Models.Narudzba, DataTransferObjects.Requests.NarudzbaInsertRequest, object>
    {
        public readonly ICrudService<DataTransferObjects.Termin, DataTransferObjects.Requests.TerminSearchRequest, DataTransferObjects.Requests.TerminUpsertRequest, DataTransferObjects.Requests.TerminUpsertRequest> _terminServce;
        public readonly ICrudService<DataTransferObjects.Kupac, object, DataTransferObjects.Requests.KupacKorisnickiNalogUpsertRequest, DataTransferObjects.Requests.KupacKorisnickiNalogUpsertRequest> _kupacService;
        public readonly ICrudService<DataTransferObjects.TipSjedista, object, DataTransferObjects.Requests.TipSjedistaUpsertRequest, DataTransferObjects.Requests.TipSjedistaUpsertRequest> _tipSjedistaService;
        public NarudzbaService(IMapper mapper, IRepository<Models.Narudzba, object> repository, ICrudService<DataTransferObjects.TipSjedista, object, DataTransferObjects.Requests.TipSjedistaUpsertRequest, DataTransferObjects.Requests.TipSjedistaUpsertRequest> tipSjedistaService, ICrudService<DataTransferObjects.Termin, DataTransferObjects.Requests.TerminSearchRequest,DataTransferObjects.Requests.TerminUpsertRequest, DataTransferObjects.Requests.TerminUpsertRequest> terminService , ICrudService<DataTransferObjects.Kupac, object, DataTransferObjects.Requests.KupacKorisnickiNalogUpsertRequest, DataTransferObjects.Requests.KupacKorisnickiNalogUpsertRequest> kupacService) : base(mapper, repository)
        {
            _terminServce = terminService;
            _kupacService = kupacService;
            _tipSjedistaService = tipSjedistaService;
        }

        public override DataTransferObjects.Narudzba Insert(DataTransferObjects.Requests.NarudzbaInsertRequest request)
        {
            var entity = Mapper.Map<Models.Narudzba>(request);
            entity.DatumKupovine = DateTime.Now;
            entity.CijenaKarte = _terminServce.GetById(request.TerminId).BaznaCijenaKarte * (1-_kupacService.GetById(request.KupacId).TipKorisnika.CijenaKartePopust) * _tipSjedistaService.GetById(request.TipSjedistaId).CijenaKarteMultiplier * request.Kolicina;
            Repository.Add(entity);
            return Mapper.Map<DataTransferObjects.Narudzba>(entity);
        }
    }
}

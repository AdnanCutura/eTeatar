using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataTransferObjects;
using DataTransferObjects.Requests;
using Repository;
using WebAPI.Services.Interfaces;

namespace WebAPI.Services
{
    public class NarudzbaService : CrudService<DataTransferObjects.Narudzba, DataTransferObjects.Requests.NarudzbaSearchRequest, Models.Narudzba, DataTransferObjects.Requests.NarudzbaInsertRequest, object>
    {
        public readonly ICrudService<DataTransferObjects.Termin, DataTransferObjects.Requests.TerminSearchRequest, DataTransferObjects.Requests.TerminUpsertRequest, DataTransferObjects.Requests.TerminUpsertRequest> _terminServce;
        public readonly ICrudService<DataTransferObjects.Kupac, object, DataTransferObjects.Requests.KupacKorisnickiNalogInsertRequest, DataTransferObjects.Requests.KupacKorisnickiNalogUpdateRequest> _kupacService;
        public readonly ICrudService<DataTransferObjects.TipSjedista, object, DataTransferObjects.Requests.TipSjedistaUpsertRequest, DataTransferObjects.Requests.TipSjedistaUpsertRequest> _tipSjedistaService;
        public NarudzbaService(IMapper mapper, IRepository<Models.Narudzba, DataTransferObjects.Requests.NarudzbaSearchRequest> repository, ICrudService<DataTransferObjects.TipSjedista, object, DataTransferObjects.Requests.TipSjedistaUpsertRequest, DataTransferObjects.Requests.TipSjedistaUpsertRequest> tipSjedistaService, ICrudService<DataTransferObjects.Termin, DataTransferObjects.Requests.TerminSearchRequest,DataTransferObjects.Requests.TerminUpsertRequest, DataTransferObjects.Requests.TerminUpsertRequest> terminService , ICrudService<DataTransferObjects.Kupac, object, DataTransferObjects.Requests.KupacKorisnickiNalogInsertRequest, DataTransferObjects.Requests.KupacKorisnickiNalogUpdateRequest> kupacService) : base(mapper, repository)
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

        public override List<Narudzba> Get(NarudzbaSearchRequest search)
        {
            var list = base.Get(search);

            foreach (var item in list)
            {
                item.Kupac = _kupacService.GetById(item.KupacId);
                item.Kupac.Narudzbe = null;
                item.Termin.Dvorana.Termini = null;
                item.Termin.Dvorana.Teatar.Dvorane = null;
            }

            return list;
        }

        public override Narudzba GetById(string id)
        {
            var item =  base.GetById(id);

            item.Kupac = _kupacService.GetById(item.KupacId);

            item.Kupac = _kupacService.GetById(item.KupacId);
            item.Kupac.Narudzbe = null;
            item.Termin.Dvorana.Termini = null;
            item.Termin.Dvorana.Teatar.Dvorane = null;

            return item;
        }
    }
}

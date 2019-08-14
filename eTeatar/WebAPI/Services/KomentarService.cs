using AutoMapper;
using DataTransferObjects.Requests;
using Models;
using Repository;
using System;
using System.Collections.Generic;
using WebAPI.Services.Interfaces;
using Kupac = DataTransferObjects.Kupac;

namespace WebAPI.Services
{
    public class KomentarService : CrudService<DataTransferObjects.Komentar, KomentarSearchRequest, Komentar, KomentarInsertRequest, object>
    {
        private readonly
            ICrudService<Kupac, object, KupacKorisnickiNalogUpsertRequest,
                KupacKorisnickiNalogUpsertRequest> _kupacService;
        public KomentarService(IMapper mapper, IRepository<Komentar, KomentarSearchRequest> repository, ICrudService<Kupac, object, KupacKorisnickiNalogUpsertRequest, KupacKorisnickiNalogUpsertRequest> kupacService) : base(mapper, repository)
        {
            _kupacService = kupacService;
        }
        
        public override DataTransferObjects.Komentar Insert(KomentarInsertRequest request)
        {
            request.DatumVrijeme = DateTime.Now;
            return base.Insert(request);
        }

        public override List<DataTransferObjects.Komentar> Get(KomentarSearchRequest search)
        {
            var list = base.Get(search);
            foreach (var item in list)
                item.Kupac = _kupacService.GetById(item.KupacId);

            return list;
        }

        public override DataTransferObjects.Komentar GetById(string id)
        {
            var item = base.GetById(id);
            item.Kupac = _kupacService.GetById(item.KupacId);

            return item;
        }
    }
}

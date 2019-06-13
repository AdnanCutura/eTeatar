using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataTransferObjects;
using DataTransferObjects.Requests;
using Models;
using Repository;
using WebAPI.Services.Interfaces;
using DvoranaTipSjedista = DataTransferObjects.DvoranaTipSjedista;
using Termin = DataTransferObjects.Termin;

namespace WebAPI.Services
{
    public class DvoranaService : CrudService<DataTransferObjects.Dvorana, DvoranaSearchRequest, Models.Dvorana, DvoranaUpsertRequest, DvoranaUpsertRequest>
    {
        private readonly ICrudService<Termin, TerminSearchRequest, TerminUpsertRequest, TerminUpsertRequest> _terminiService;
        private readonly ICrudService<DvoranaTipSjedista, DvoranaTipSjedistaSearchRequest, DvoranaTipSjedistaUpsertRequest, DvoranaTipSjedistaUpsertRequest> _dvoranaTipSjedistaService;

        public DvoranaService(IMapper mapper, IRepository<Models.Dvorana, DvoranaSearchRequest> repository, ICrudService<Termin, TerminSearchRequest, TerminUpsertRequest, TerminUpsertRequest> terminiService, ICrudService<DvoranaTipSjedista, DvoranaTipSjedistaSearchRequest, DvoranaTipSjedistaUpsertRequest, DvoranaTipSjedistaUpsertRequest> dvoranaTipSjedistaService) : base(mapper, repository)
        {
            _terminiService = terminiService;
            _dvoranaTipSjedistaService = dvoranaTipSjedistaService;
        }

        public override List<DataTransferObjects.Dvorana> Get(DvoranaSearchRequest search)
        {
            var dvorane = base.Get(search);

            foreach (var dvorana in dvorane)
            {
                dvorana.Termini = _terminiService.Get(new TerminSearchRequest
                {
                    DvoranaId = dvorana.Id
                });
                dvorana.TipoviSjedista = _dvoranaTipSjedistaService.Get(new DvoranaTipSjedistaSearchRequest
                {
                    DvoranaId = dvorana.Id
                });
            }
            return dvorane;
        }

        public override DataTransferObjects.Dvorana GetById(string id)
        {
            var dvorana = base.GetById(id);
            dvorana.Termini = _terminiService.Get(new TerminSearchRequest
            {
                DvoranaId = dvorana.Id
            });
            dvorana.TipoviSjedista = _dvoranaTipSjedistaService.Get(new DvoranaTipSjedistaSearchRequest
            {
                DvoranaId = dvorana.Id
            });

            return dvorana;
        }

        public override DataTransferObjects.Dvorana Update(string id, DvoranaUpsertRequest request)
        {
            base.Update(id, request);
            return GetById(id);
        }
    }
}
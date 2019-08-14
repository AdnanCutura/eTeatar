using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObjects.Requests;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository
{
    public class TerminRepository : Repository<Models.Termin, TerminSearchRequest>
    {
        public TerminRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<Termin> Get(TerminSearchRequest search)
        {
            IQueryable<Termin> query = Context.Set<Termin>().AsQueryable();

            query = query.Where(x => x.DatumVrijeme >= (search.DatumOd ?? DateTime.MinValue));
            query = query.Where(x => x.DatumVrijeme <= (search.DatumDo ?? DateTime.MaxValue));


            if (!string.IsNullOrWhiteSpace(search?.PredstavaId))
            {
                query = query.Where(x => x.PredstavaId == search.PredstavaId);
            }

            if (!string.IsNullOrWhiteSpace(search?.NazivPredstave))
            {
                query = query.Where(x => x.Predstava.Naziv.ToUpper().Contains(search.NazivPredstave.ToUpper()));
            }

            if (!string.IsNullOrWhiteSpace(search?.DvoranaId))
            {
                query = query.Where(x => x.DvoranaId == search.DvoranaId);
            }

            query = query.OrderBy(x => x.DatumVrijeme);
            IEnumerable<Termin> list = query
                .Include(t => t.Dvorana).ThenInclude(d => d.Teatar).ThenInclude(t => t.Grad)
                .Include(t=>t.Dvorana.TipoviSjedista)
                .Include(t => t.Narudzbe)
                .Include(t => t.Predstava)
                .ToList();

            foreach (var item in list)
            {
                item.Predstava.Termini = null;
                item.Dvorana.Termini = null;
                item.Dvorana.Teatar.Dvorane = null;
                item.Dvorana.Teatar.Grad.Teatri = null;
                foreach (var TipSjedista in item.Dvorana.TipoviSjedista)
                {
                    TipSjedista.Dvorana = null;
                    TipSjedista.TipSjedista = Context.TipSjedista.Find(TipSjedista.TipSjedistaId);
                }
            }
            return list;
        }

        public override Termin GetById(string id)
        {
            var query = Context.Set<Termin>().AsQueryable();
            query = query.Where(w => w.Id == id);

            query = query
                .Include(i => i.Dvorana)
                .Include(i => i.Predstava)
                .Include(i => i.Narudzbe);

            return query.FirstOrDefault();
        }
    }
}

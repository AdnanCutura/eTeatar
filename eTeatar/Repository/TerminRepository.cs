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


            if (!string.IsNullOrWhiteSpace(search.PredstavaId))
            {
                query = query.Where(x => x.PredstavaId == search.PredstavaId);
            }

            if (!string.IsNullOrWhiteSpace(search.DvoranaId))
            {
                query = query.Where(x => x.DvoranaId == search.DvoranaId);
            }

            query = query.OrderBy(x => x.DatumVrijeme);
            IEnumerable<Termin> list = query
                .Include(t => t.Dvorana)
                .Include(t => t.Predstava)
                .Include(t => t.Narudzbe)
                .ToList();

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

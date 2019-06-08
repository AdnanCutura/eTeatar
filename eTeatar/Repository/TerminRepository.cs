using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObjects.Requests;
using Models;

namespace Repository
{
    public class TerminRepository: Repository<Models.Termin, TerminSearchRequest>
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
            IEnumerable<Termin> list = query.ToList();

            return list;
        }
    }
}

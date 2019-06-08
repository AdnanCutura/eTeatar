using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObjects.Requests;
using Models;

//TODO: Dodati ulogovanog admina

namespace Repository
{
    public class ObavijestRepository : Repository<Models.Obavijest, ObavijestSearchRequest>
    {
        public ObavijestRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<Obavijest> Get(ObavijestSearchRequest search)
        {
            IQueryable<Obavijest> query = Context.Set<Obavijest>().AsQueryable();

            query = query.Where(x => x.DatumVrijeme >= (search.DatumOd ?? DateTime.MinValue));
            query = query.Where(x => x.DatumVrijeme <= (search.DatumDo ?? DateTime.MaxValue));
            
            query = query.OrderBy(x => x.Naslov);
            IEnumerable<Obavijest> list = query.ToList();

            return list;
        }
    }
}

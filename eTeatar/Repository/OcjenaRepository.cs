using DataTransferObjects.Requests;
using Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class  OcjenaRepository : Repository<Ocjena, OcjenaSearchRequest>
    {
        public OcjenaRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<Ocjena> Get(OcjenaSearchRequest search)
        {
            IQueryable<Ocjena> query = Context.Set<Ocjena>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.PredstavaId))
                query = query.Where(x => x.Narudzba.Termin.PredstavaId == search.PredstavaId);

            if (!string.IsNullOrWhiteSpace(search?.NarudzbaId))
                query = query.Where(x => x.NarudzbaId == search.NarudzbaId);
            
            return query.ToList();
        }
    }
}

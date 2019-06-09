using System;
using DataTransferObjects.Requests;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class GlumacRepository : Repository<Glumac, GlumacSearchRequest>
    {
        public GlumacRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<Glumac> Get(GlumacSearchRequest search)
        {
            IQueryable<Glumac> query = Context.Set<Glumac>().AsQueryable();
            
            if (!string.IsNullOrWhiteSpace(search.Ime))
                query = query.Where(x => x.Ime.ToUpper().Contains(search.Ime.ToUpper()));
            
            if (!string.IsNullOrWhiteSpace(search.Prezime))
                query = query.Where(x => x.Prezime.ToUpper().Contains(search.Prezime.ToUpper()));

            query = query.OrderBy(x => x.Ime).ThenBy(x=> x.Prezime);
            IEnumerable<Glumac> list = query.ToList();

            return list;
        }
    }
}
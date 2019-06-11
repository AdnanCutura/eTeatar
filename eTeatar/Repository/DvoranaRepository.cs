using DataTransferObjects.Requests;
using Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class DvoranaRepository : Repository<Dvorana, DvoranaSearchRequest>
    {
        public DvoranaRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<Dvorana> Get(DvoranaSearchRequest search)
        {
            IQueryable<Dvorana> query = Context.Set<Dvorana>().AsQueryable();
            
            if (!string.IsNullOrWhiteSpace(search.TeatarId))
            {
                query = query.Where(x => x.TeatarId == search.TeatarId);
            }

            query = query.OrderBy(x => x.Naziv);
            IEnumerable<Dvorana> list = query
                .Include(d=>d.Teatar)
                .ThenInclude(t => t.Grad)
                .ThenInclude(g => g.Drzava)
                .ToList();

            return list;
        }
    }
}

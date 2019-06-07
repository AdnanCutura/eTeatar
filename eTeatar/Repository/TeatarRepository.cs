using DataTransferObjects.Requests;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class TeatarRepository : Repository<Teatar, TeatarSearchRequest>
    {
        public TeatarRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<Teatar> Get(TeatarSearchRequest search)
        {
            IQueryable<Teatar> query = Context.Set<Teatar>().AsQueryable();
            
            if (!string.IsNullOrWhiteSpace(search.GradId))
            {
                query = query.Where(x => x.GradId == search.GradId);
            }

            query = query.OrderBy(x => x.Naziv);
            IEnumerable<Teatar> list = query.ToList();

            return list;
        }
    }
}

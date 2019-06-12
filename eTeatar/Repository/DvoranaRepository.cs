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
            
            if (!string.IsNullOrWhiteSpace(search?.TeatarId))
            {
                query = query.Where(x => x.TeatarId == search.TeatarId);
            }

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.Contains(search.Naziv));
            }



            query = query.OrderBy(x => x.Naziv);
            IEnumerable<Dvorana> list = query
                .Include(d=>d.Teatar)
                .ThenInclude(t => t.Grad)
                .ThenInclude(g => g.Drzava)
                .Include(d=>d.TipoviSjedista)
                .ToList();

            foreach (var item in list) { 
                item.Teatar.Dvorane = null;
                foreach (var tipsjedista in item.TipoviSjedista)
                    tipsjedista.Dvorana = null;
            }
            return list;
        }

        public override Dvorana GetById(string id)
        {
            return Context.Dvorana.Include(d => d.Teatar).FirstOrDefault(w => w.Id == id);
        }
    }
}

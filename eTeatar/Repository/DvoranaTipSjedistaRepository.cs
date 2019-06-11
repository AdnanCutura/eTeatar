using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObjects.Requests;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository
{
    public class DvoranaTipSjedistaRepository : Repository<Models.DvoranaTipSjedista, DvoranaTipSjedistaSearchRequest>
    {
        public DvoranaTipSjedistaRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<DvoranaTipSjedista> Get(DvoranaTipSjedistaSearchRequest search)
        {
            var query = Context.Set<DvoranaTipSjedista>().AsQueryable();
            if (!string.IsNullOrEmpty(search.DvoranaId))
                query = query.Where(dts => dts.DvoranaId == search.DvoranaId);

            var list = query
                .Include(dtp => dtp.TipSjedista)
                .ToList();
            return list;
        }
    }
}

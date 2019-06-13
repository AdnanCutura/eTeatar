using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObjects.Requests;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository
{
    public class UlogaRepository : Repository<Models.Uloga, DataTransferObjects.Requests.UlogaSearchRequest>
    {
        public UlogaRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<Uloga> Get(UlogaSearchRequest search)
        {
            var query = Context.Uloga.AsQueryable();

            //Glumac
            if (!string.IsNullOrEmpty(search?.GlumacId))
                query = query.Where(w => w.GlumacId == search.GlumacId);

            //Predstava
            if (!string.IsNullOrEmpty(search?.PredstavaId))
                query = query.Where(w => w.PredstavaId == search.PredstavaId);

            query = query.Include(i => i.Predstava).Include(i => i.Glumac);

            foreach (var item in query)
            {
                item.Predstava.Uloge = null;
                item.Glumac.Uloge = null;
            }

            return query.ToList();
        }
    }
}

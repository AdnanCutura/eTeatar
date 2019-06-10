using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObjects.Requests;
using Models;

namespace Repository
{
    public  class ZanrRepository : Repository<Models.Zanr, DataTransferObjects.Requests.ZanrSearchRequest>
    {
        public ZanrRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<Zanr> Get(ZanrSearchRequest search)
        {
            var query = Context.Set<Zanr>().AsQueryable();

            if (!string.IsNullOrEmpty(search?.PredstavaId))
                query = query.Where(w => Context.PredstavaZanr.Where(q => q.PredstavaId == search.PredstavaId && q.ZanrId == w.Id).Any());

            return query.ToList();
        }
    }
}

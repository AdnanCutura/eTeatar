using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObjects.Requests;
using Models;

namespace Repository
{
    public class PredstavaZanrRepository : Repository<Models.PredstavaZanr, DataTransferObjects.Requests.PredstavaZanrSearchRequest>
    {
        public PredstavaZanrRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<PredstavaZanr> Get(PredstavaZanrSearchRequest search)
        {
            var query = Context.PredstavaZanr.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.PredstavaId))
                query = query.Where(w => w.PredstavaId == search.PredstavaId);

            if (!string.IsNullOrWhiteSpace(search?.ZanrId))
                query = query.Where(w => w.ZanrId == search.ZanrId);

            return query.ToList();
        }
    }
}

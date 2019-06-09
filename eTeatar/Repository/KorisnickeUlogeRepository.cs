using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObjects.Requests;
using Models;

namespace Repository
{
    public class KorisnickeUlogeRepository : Repository<Models.KorisnickaUloga, KorisnickaUlogaSearchRequest>
    {
        public KorisnickeUlogeRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<KorisnickaUloga> Get(KorisnickaUlogaSearchRequest search)
        {
            var query = Context.KorisnickaUloga.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Naziv))
            {
                query = query.Where(ku => ku.Naziv == search.Naziv);
            }

            var list = query.ToList();
            return list;
        }
    }
}

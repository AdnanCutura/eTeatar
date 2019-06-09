using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObjects.Requests;
using Models;

namespace Repository
{
    public class TipKorisnikaRepository : Repository<Models.TipKorisnika, TipKorisnikaSearchRequest>
    {
        public TipKorisnikaRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<TipKorisnika> Get(TipKorisnikaSearchRequest search)
        {
            var query = Context.TipKorisnika.AsQueryable();

            if (search.IsOsnovni)
            {
                query = query.Where(tk => tk.IsOsnovni);
            }

            var list = query.ToList();
            return list;
        }
    }
}

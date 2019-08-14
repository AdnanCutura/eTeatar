using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository
{
    public class KupacRepository : Repository<Models.Kupac, object>
    {
        public KupacRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<Kupac> Get(object search)
        {
            var query = Context.Kupac.AsQueryable();
            query = query.Include(i => i.TipKorisnika);
            return query.ToList();
        }

        public override Kupac GetById(string id)
        {
            var query = Context.Kupac.AsQueryable();
            query = query.Include(i => i.TipKorisnika);
            return query.FirstOrDefault(w => w.Id == id);
        }
    }
}

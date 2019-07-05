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

            IEnumerable<Kupac> list = query
                .Include(i => i.TipKorisnika)
                .ToList();

            return list;
        }

        public override Kupac GetById(string id)
        {
            var query = Context.Kupac.Where(w => w.Id == id).AsQueryable();
            var item = query
                .Include(i => i.TipKorisnika)
                .Single();

            return item;
        }
    }
}

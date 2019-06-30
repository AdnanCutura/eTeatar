using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObjects.Requests;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository
{
    public class KomentarRepository : Repository<Models.Komentar, object>
    {
        public KomentarRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<Komentar> Get(object search)
        {
            var query = Context.Komentar.AsQueryable();

            IEnumerable<Komentar> list = query
                .Include(i => i.Kupac)
                .ThenInclude(kp => kp.KorisnickiNalog)
                .ToList();

            return list;
        }

        public override Komentar GetById(string id)
        {
            var query = Context.Komentar.Where(w => w.Id == id).AsQueryable();
            var item = query
                .Include(i => i.Kupac)
                .ThenInclude(kp => kp.KorisnickiNalog)
                .Single();

            return item;
        }
    }
}

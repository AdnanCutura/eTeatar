using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObjects.Requests;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository
{
    public class KomentarRepository : Repository<Models.Komentar, KomentarSearchRequest>
    {
        public KomentarRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<Komentar> Get(KomentarSearchRequest search)
        {
            var query = Context.Komentar.AsQueryable();

            if (!string.IsNullOrEmpty(search.ObavijestId))
                query = query.Where(k => k.ObavijestId == search.ObavijestId);

            IEnumerable<Komentar> list = query
                .OrderByDescending(k => k.DatumVrijeme)
                .ToList();

            return list;
        }

        public override Komentar GetById(string id)
        {
            var query = Context.Komentar.Where(w => w.Id == id).AsQueryable();
            var item = query
                .Single();

            return item;
        }
    }
}

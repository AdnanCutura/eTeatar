using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObjects.Requests;
using Microsoft.EntityFrameworkCore;
using Models;


namespace Repository
{
    public class ObavijestRepository : Repository<Models.Obavijest, ObavijestSearchRequest>
    {
        public ObavijestRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<Obavijest> Get(ObavijestSearchRequest search)
        {
            IQueryable<Obavijest> query = Context.Set<Obavijest>().AsQueryable();

            if (search?.DatumOd != null)
                query = query.Where(x => x.DatumVrijeme >= (search.DatumOd ?? DateTime.MinValue));

            if (search?.DatumDo != null)
                query = query.Where(x => x.DatumVrijeme <= (search.DatumDo ?? DateTime.MaxValue));

            query = query.OrderBy(x => x.DatumVrijeme);
            IEnumerable<Obavijest> list = query
                .Include(o => o.Administrator)
                .Include(o => o.Komentari)
                .ToList();

            foreach (var item in list)
                item.Administrator.Obavijesti = null;

            return list;
        }

        public override Obavijest GetById(string id)
        {
            var query = Context.Set<Obavijest>().AsQueryable();
            query = query.Where(o => o.Id == id);

            IEnumerable<Obavijest> list = query
                .Include(i => i.Administrator)
                .Include(i => i.Komentari);

            foreach (var item in list)
                item.Administrator.Obavijesti = null;

            return list.Single();
        }
    }
}

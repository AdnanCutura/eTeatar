
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class PredstavaRepository : Repository<Models.Predstava, DataTransferObjects.Requests.PredstavaSearchRequest>
    {
        public PredstavaRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<Models.Predstava> Get(DataTransferObjects.Requests.PredstavaSearchRequest search)
        {
            IQueryable<Models.Predstava> query = Context.Set<Models.Predstava>().AsQueryable();

            //Samo predstave koje igraju u buducnosti
            query = query.Where(w => w.Termini.Where(q => q.DatumVrijeme > DateTime.Now).Any());

            //Filter po nazivu
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
                query = query.Where(w => w.Naziv.Contains(search.Naziv));

            //Filter po datumu
            query = query.Where(w => Context.Termin.Where(q => q.PredstavaId == w.Id && q.DatumVrijeme >= (search.DatumOd ?? DateTime.MinValue)).Any());
            query = query.Where(w => Context.Termin.Where(q => q.PredstavaId == w.Id && q.DatumVrijeme <= (search.DatumDo ?? DateTime.MaxValue)).Any());

            //Filter po ocjeni
            query = query.Where(w=> (Context.Narudzba.Where(q=>q.Termin.PredstavaId == w.Id).Average(a=> (double?) a.Ocjena.Vrijednost) ?? 0) >= (search.Ocjena ?? 0));

            //Sortiranje
            switch (search?.OrderBy)
            {
                case DataTransferObjects.Enums.PredstavaOrderBy.Datum:
                    if (search?.Order == DataTransferObjects.Enums.OrderBy.Ascending)
                        query = query.OrderBy(o => Context.Termin.Where(w=>w.PredstavaId == o.Id).OrderBy(o2 => o2.DatumVrijeme).FirstOrDefault().DatumVrijeme);
                    else
                        query = query.OrderByDescending(o => Context.Termin.Where(w => w.PredstavaId == o.Id).FirstOrDefault().DatumVrijeme);
                    break;

                case DataTransferObjects.Enums.PredstavaOrderBy.Ocjena:
                    if (search?.Order == DataTransferObjects.Enums.OrderBy.Ascending)
                        query = query.OrderBy(o => (Context.Narudzba.Where(q => q.Termin.PredstavaId == o.Id).Average(a => (double?)a.Ocjena.Vrijednost)) ?? 0);
                    else
                        query = query.OrderByDescending(o => (Context.Narudzba.Where(q => q.Termin.PredstavaId == o.Id).Average(a => (double?)a.Ocjena.Vrijednost)) ?? 0);
                    break;

                default:
                    break;
            }

            IEnumerable<Models.Predstava> list = query.ToList();

            return list;
        }

        public override Predstava GetById(string id)
        {
            var query = Context.Set<Predstava>().AsQueryable();
            query = query.Where(w => w.Id == id);
            query = query.Include(i => i.Uloge);
            query = query.Include(i => i.Termini);

            return query.FirstOrDefault();
        }
    }
}

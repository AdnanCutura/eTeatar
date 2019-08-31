using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;

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
            //if (search.AreAktualnePredstave)
            //    query = query.Where(w => w.Termini.Any(q => q.DatumVrijeme > DateTime.Now));

            //Filter po nazivu
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
                query = query.Where(w => w.Naziv.ToUpper().Contains(search.Naziv.ToUpper()));

            //Filter po datumu
            if (search?.DatumOd != null)
                query = query.Where(w => Context.Termin.Any(q => q.PredstavaId == w.Id && q.DatumVrijeme >= (search.DatumOd ?? DateTime.MinValue)));
            if (search?.DatumDo != null)
                query = query.Where(w => Context.Termin.Any(q => q.PredstavaId == w.Id && q.DatumVrijeme <= (search.DatumDo ?? DateTime.MaxValue)));

            //Filter po ocjeni
            query = query.Where(w => (Context.Narudzba.Where(q => q.Termin.PredstavaId == w.Id).Average(a => (double?)a.Ocjena.Vrijednost) ?? 0) >= (search.Ocjena ?? 0));

            //Filter po zanru
            if (search.Zanrovi?.Any() ?? false)
                query = query.Where(w => Context.PredstavaZanr.Where(q => q.PredstavaId == w.Id).Select(s => s.ZanrId).Intersect(search.Zanrovi).Any());

            //Filter po teatru
            if (!string.IsNullOrEmpty(search.TeatarId))
                query = query.Where(w => Context.Termin.Any(q => q.PredstavaId == w.Id && q.Dvorana.TeatarId == search.TeatarId));


            //Sortiranje
            switch (search?.OrderBy)
            {
                case DataTransferObjects.Enums.PredstavaOrderBy.Datum:
                    if (search?.Order == DataTransferObjects.Enums.OrderBy.Ascending)
                        query = query.OrderBy(o => Context.Termin.Where(w => w.PredstavaId == o.Id).OrderBy(o2 => o2.DatumVrijeme).FirstOrDefault().DatumVrijeme);
                    else
                        query = query.OrderByDescending(o => Context.Termin.FirstOrDefault(w => w.PredstavaId == o.Id).DatumVrijeme);
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

            query = query.Include(p => p.Uloge);

            foreach (var item in query)
                foreach (var uloga in item.Uloge)
                    uloga.Glumac = Context.Uloga.Where(w => w.Id == uloga.Id).Select(s => s.Glumac).FirstOrDefault();

            IEnumerable<Models.Predstava> list = query.ToList();

            return list;
        }

        public override Predstava GetById(string id)
        {
            var query = Context.Set<Predstava>().AsQueryable();
            query = query.Where(w => w.Id == id);

            query = query.Include(i => i.Uloge);
            query = query
                .Include(i => i.Termini)
                .ThenInclude(t => t.Dvorana)
                .ThenInclude(d => d.Teatar)
                .ThenInclude(t => t.Grad)
                .Include(i => i.Termini)
                .ThenInclude(t => t.Predstava);

            foreach (var item in query)
                foreach (var uloga in item.Uloge)
                    uloga.Glumac = Context.Uloga.Where(w => w.Id == uloga.Id).Select(s => s.Glumac).FirstOrDefault();

            return query.FirstOrDefault();
        }

     
        private readonly Dictionary<string, List<Ocjena>> predstave = new Dictionary<string, List<Ocjena>>();

        public List<Predstava> GetPreporucene(string currentPredstavaId)
        {
            GetProductsData(currentPredstavaId);

            List<Ocjena> currentProductRatings = Context.Ocjena
                .Include(i => i.Narudzba)
                .ThenInclude(n => n.Termin)
                .Where(x => x.Narudzba.Termin.PredstavaId == currentPredstavaId)
                .OrderBy(x => x.Narudzba.KupacId)
                .ToList();

            List<Ocjena> commonRatings1 = new List<Ocjena>();
            List<Ocjena> commonRatings2 = new List<Ocjena>();


            List<Predstava> similarProducts = new List<Predstava>();

            foreach (var p in predstave)
            {
                foreach (var r in currentProductRatings)
                {
                    if (p.Value.Count(x => x.Narudzba.KupacId == r.Narudzba.KupacId) > 0)
                    {
                        commonRatings1.Add(r);
                        commonRatings2.Add(p.Value.First(x => x.Narudzba.KupacId == r.Narudzba.KupacId));
                    }
                }

                double sim = CalculateSimilarity(commonRatings1, commonRatings2);

                if (sim > 0.6)
                {
                    similarProducts.Add(base.GetById(p.Key));
                }

                commonRatings1.Clear();
                commonRatings2.Clear();
            }

            return similarProducts;
        }

        private double CalculateSimilarity(List<Ocjena> commonRatings1, List<Ocjena> commonRatings2)
        {
            if (commonRatings1.Count != commonRatings2.Count)
                return 0;

            double numerator = 0, int1 = 0, int2 = 0;

            for (int i = 0; i < commonRatings1.Count; i++)
            {
                numerator += commonRatings1[i].Vrijednost * commonRatings2[i].Vrijednost;
                int1 += Math.Pow(commonRatings1[i].Vrijednost, 2);
                int2 += Math.Pow(commonRatings2[i].Vrijednost, 2);

            }

            int1 = Math.Sqrt(int1);
            int2 = Math.Sqrt(int2);

            if (int1 * int2 != 0)
                return numerator / (int1 * int2);

            return 0;

        }

        private void GetProductsData(string currentProductId)
        {
            //List<Predstava> activeProducts = Context.Predstava.Where(x => x.Id != currentProductId && x.Termini.Any(t => t.DatumVrijeme > DateTime.Now)).ToList();
            List<Predstava> trenutnePredstave = Context.Predstava.Where(x => x.Id != currentProductId).ToList();

            foreach (var item in trenutnePredstave)
            {
                List<Ocjena> ratings = Context.Ocjena.Include(i => i.Narudzba)
                    .ThenInclude(n => n.Termin)
                    .Where(x => x.Narudzba.Termin.PredstavaId == item.Id).OrderBy(x => x.Narudzba.KupacId).ToList();

                if (ratings.Count > 0)
                    predstave.Add(item.Id, ratings);

            }
        }
    }
}

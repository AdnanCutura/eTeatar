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
        
        /// <summary>
        /// Metoda za dobavljanje sličnih/preporučenih
        /// </summary>
        /// <param name="predstavaId">Trenutna predstava</param>
        /// <returns>Predstave koje imaju sličnost veći od 0.6</returns>
        public List<Predstava> GetPreporucene(string predstavaId)
        {
            Dictionary<string, List<Ocjena>> _predstave = GetPredstave(predstavaId);

            List<Ocjena> predstavaOcjene = Context.Ocjena
                .Include(i => i.Narudzba)
                .ThenInclude(n => n.Termin)
                .Where(x => x.Narudzba.Termin.PredstavaId == predstavaId)
                .OrderBy(x => x.Narudzba.KupacId)
                .ToList();

            List<Ocjena> zajednickeOcjene1 = new List<Ocjena>();
            List<Ocjena> zajednickeOcjene2 = new List<Ocjena>();


            List<Predstava> zajednickiProizvodi = new List<Predstava>();

            foreach (var p in _predstave)
            {
                foreach (var r in predstavaOcjene)
                {
                    if (p.Value.All(x => x.Narudzba.KupacId != r.Narudzba.KupacId)) continue;

                    zajednickeOcjene1.Add(r);
                    zajednickeOcjene2.Add(p.Value.First(x => x.Narudzba.KupacId == r.Narudzba.KupacId));
                }

                double slicnost = IzracunavanjeSlicnosti(zajednickeOcjene1, zajednickeOcjene2);

                if (slicnost > 0.6)
                    zajednickiProizvodi.Add(base.GetById(p.Key));

                zajednickeOcjene1.Clear();
                zajednickeOcjene2.Clear();
            }

            return zajednickiProizvodi;
        }


        /// <summary>
        /// Izračunavanje sličnosti pomoću formule vektorske udaljenosti
        /// </summary>
        /// <param name="zajednickeOcjene1">Ocjene korisnika1</param>
        /// <param name="zajednickeOcjene2">Ocjene korisnika2</param>
        /// <returns>Slicnost izmedju predstava</returns>
        private static double IzracunavanjeSlicnosti(IReadOnlyList<Ocjena> zajednickeOcjene1, IReadOnlyList<Ocjena> zajednickeOcjene2)
        {
            if (zajednickeOcjene1.Count != zajednickeOcjene2.Count)
                return 0;

            double numerator = 0, int1 = 0, int2 = 0;

            for (int i = 0; i < zajednickeOcjene1.Count; i++)
            {
                numerator += zajednickeOcjene1[i].Vrijednost * zajednickeOcjene2[i].Vrijednost;
                int1 += Math.Pow(zajednickeOcjene1[i].Vrijednost, 2);
                int2 += Math.Pow(zajednickeOcjene2[i].Vrijednost, 2);

            }

            int1 = Math.Sqrt(int1);
            int2 = Math.Sqrt(int2);

            if (int1 * int2 != 0)
                return numerator / (int1 * int2);

            return 0;

        }


        /// <summary>
        /// Sve predstave koje nisu trenutna, a imaju ocjenu, se dodaju u dictionarz (id i lista ocjena)
        /// </summary>
        /// <param name="predstavaId">Id trentne predstave</param>
        /// /// <returns>Dictionary id predstava i njihovih ocjena</returns>
        private Dictionary<string, List<Ocjena>> GetPredstave(string predstavaId)
        {
            var predstaveDictionary = new Dictionary<string, List<Ocjena>>();
            List<Predstava> predstave = Context.Predstava.Where(x => x.Id != predstavaId).ToList();

            foreach (var item in predstave)
            {
                List<Ocjena> ocjene = Context.Ocjena.Include(i => i.Narudzba)
                    .ThenInclude(n => n.Termin)
                    .Where(x => x.Narudzba.Termin.PredstavaId == item.Id)
                    .OrderBy(x => x.Narudzba.KupacId)
                    .ToList();

                if (ocjene.Any())
                    predstaveDictionary.Add(item.Id, ocjene);

            }

            return predstaveDictionary;
        }
    }
}

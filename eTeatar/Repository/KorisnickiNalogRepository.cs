using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObjects.Requests;
using Models;

namespace Repository
{
    public class KorisnikRepository : Repository<Models.KorisnickiNalog, KorisnickiNalogSearchRequest>
    {
        public KorisnikRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<KorisnickiNalog> Get(KorisnickiNalogSearchRequest search)
        {
            IQueryable<KorisnickiNalog> query = Context.KorisnickiNalog.AsQueryable();

            if (!string.IsNullOrEmpty(search.Ime))
                query = Context.KorisnickiNalog.Where(k => k.Ime.ToUpper().Contains(search.Ime.ToUpper()));

            if (!string.IsNullOrEmpty(search.Prezime))
                query = Context.KorisnickiNalog.Where(k => k.Prezime.ToUpper().Contains(search.Prezime.ToUpper()));

            if (!string.IsNullOrEmpty(search.KorisnickoIme))
                query = Context.KorisnickiNalog.Where(k => k.KorisnickoIme.ToUpper().Contains(search.KorisnickoIme.ToUpper()));

            IEnumerable<KorisnickiNalog> list = query.ToList();

            return list;
        }
   


    }
}

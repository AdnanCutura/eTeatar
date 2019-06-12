using DataTransferObjects.Requests;
using Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace Repository
{
    public class KorisnickiNalogRepository : Repository<Models.KorisnickiNalog, KorisnickiNalogSearchRequest>, IKorisnickiNalogRepository
    {
        public KorisnickiNalogRepository(eTeatarContext context) : base(context)
        {
        }

        public override KorisnickiNalog Add(KorisnickiNalog obj)
        {
            obj.DatumKreiranja = DateTime.Now;
            return base.Add(obj);
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

            query = query.Include(i => i.KorisnickaUloga);

            IEnumerable<KorisnickiNalog> list = query.ToList();

            return list;
        }

        public KorisnickiNalog Autentificiraj(string korisnickoIme)
        {
            return Context.KorisnickiNalog.Where(k => k.KorisnickoIme == korisnickoIme).Include(k=>k.KorisnickaUloga).FirstOrDefault();
        }

        public override KorisnickiNalog GetById(string id)
        {
            return Context.KorisnickiNalog.Where(w => w.Id == id).Include(i => i.KorisnickaUloga).FirstOrDefault();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObjects.Requests;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository
{
    public class GradRepository:Repository<Models.Grad, DataTransferObjects.Requests.GradSearchRequest>
    {
        public GradRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<Grad> Get(GradSearchRequest search)
        {
            var query = Context.Grad.AsQueryable();

            if (!string.IsNullOrEmpty(search.DrzavaId))
                query = query.Where(g => g.DrzavaId == search.DrzavaId);

            var list = query
                .Include(g => g.Drzava)
                .ToList();
            return list;
        }

        public override Grad GetById(string Id)
        {
            var query = Context.Grad.AsQueryable();

            query = query.Where(g => g.Id == Id);

            var item = query
                .Include(g => g.Drzava)
                .ToList();
            return item.FirstOrDefault();
        }
    }
}
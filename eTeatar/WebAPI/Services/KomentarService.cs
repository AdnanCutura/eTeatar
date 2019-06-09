using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataTransferObjects.Requests;
using Models;
using Repository;

namespace WebAPI.Services
{
    public class KomentarService : CrudService<DataTransferObjects.Komentar, object, Models.Komentar,KomentarInsertRequest, object>
    {
        public KomentarService(IMapper mapper, IRepository<Komentar, object> repository) : base(mapper, repository)
        {
        }

        public override DataTransferObjects.Komentar Insert(KomentarInsertRequest request)
        {
            request.DatumVrijeme = DateTime.Now;
            return base.Insert(request);
        }
    }
}

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
    public class TerminService : CrudService<DataTransferObjects.Termin, TerminSearchRequest, Models.Termin, TerminUpsertRequest, TerminUpsertRequest>
    {
        public TerminService(IMapper mapper, IRepository<Termin, TerminSearchRequest> repository) : base(mapper, repository)
        {
        }
    }
}

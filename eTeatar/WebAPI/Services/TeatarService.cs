using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataTransferObjects.Requests;
using Models;
using Repository;
using WebAPI.Services.Interfaces;
using Dvorana = DataTransferObjects.Dvorana;

namespace WebAPI.Services
{
    public class TeatarService : CrudService<DataTransferObjects.Teatar, TeatarSearchRequest, Models.Teatar, TeatarUpsertRequest, TeatarUpsertRequest>
    {
        public TeatarService(IMapper mapper, IRepository<Models.Teatar, TeatarSearchRequest> repository) : base(mapper, repository)
        {
        }
    }
}

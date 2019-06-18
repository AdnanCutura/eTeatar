using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataTransferObjects;
using DataTransferObjects.Requests;
using Models;
using Repository;
using WebAPI.Services.Interfaces;
using DvoranaTipSjedista = DataTransferObjects.DvoranaTipSjedista;
using Termin = DataTransferObjects.Termin;

namespace WebAPI.Services
{
    public class OcjenaService : CrudService<DataTransferObjects.Ocjena, OcjenaSearchRequest, Models.Ocjena, OcjenaInsertRequest, object>
    {

        public OcjenaService(IMapper mapper, IRepository<Models.Ocjena, OcjenaSearchRequest> repository) : base(mapper, repository)
        {
        }

    }
}
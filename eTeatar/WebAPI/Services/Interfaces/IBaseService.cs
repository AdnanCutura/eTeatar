using System.Collections.Generic;

namespace WebAPI.Services.Interfaces
{
    public interface IBaseService<TDataTransferObject, in TSearch>
    {
        List<TDataTransferObject> Get(TSearch search);

        TDataTransferObject GetById(string id);
    }
}

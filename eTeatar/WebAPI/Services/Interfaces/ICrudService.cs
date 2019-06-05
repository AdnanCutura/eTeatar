namespace WebAPI.Services.Interfaces
{
    public interface ICrudService<TTransferObject, in TSearch, in TInsert, in TUpdate> : IBaseService<TTransferObject, TSearch>
    {
        TTransferObject Insert(TInsert request);
        TTransferObject Update(string id, TUpdate request);
        void Delete(string id);
    }
}
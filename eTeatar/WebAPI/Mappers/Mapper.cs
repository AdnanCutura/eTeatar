using AutoMapper;
namespace WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Models.Teatar,DataTransferObjects.Teatar>();
            CreateMap<Models.Teatar,DataTransferObjects.Requests.TeatarUpsertRequest>().ReverseMap();
        }
    }
}

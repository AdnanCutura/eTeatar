using AutoMapper;
namespace WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            // Teatar
            CreateMap<Models.Teatar, DataTransferObjects.Teatar>();
            CreateMap<Models.Teatar, DataTransferObjects.Requests.TeatarUpsertRequest>().ReverseMap();

            //Dvorana
            CreateMap<Models.Dvorana, DataTransferObjects.Dvorana>();
            CreateMap<Models.Dvorana, DataTransferObjects.Requests.DvoranaUpsertRequest>().ReverseMap();

            //Obavijest
            CreateMap<Models.Obavijest, DataTransferObjects.Obavijest>();
            CreateMap<Models.Obavijest, DataTransferObjects.Requests.ObavijestUpsertRequest>().ReverseMap();

            //Uloga
            CreateMap<Models.Uloga, DataTransferObjects.Uloga>();
            CreateMap<Models.Uloga, DataTransferObjects.Requests.UlogaUpsertRequest>().ReverseMap();

            //Žanr
            CreateMap<Models.Zanr, DataTransferObjects.Zanr>();

            //Drzava
            CreateMap<Models.Drzava, DataTransferObjects.Drzava>();

            //Grad
            CreateMap<Models.Grad, DataTransferObjects.Grad>();

            //Tip sjedišta
            CreateMap<Models.TipSjedista, DataTransferObjects.TipSjedista>();
            CreateMap<Models.TipSjedista, DataTransferObjects.Requests.TipSjedistaUpsertRequest>().ReverseMap();

            //Dvorana Tip sjedišta
            CreateMap<Models.DvoranaTipSjedista, DataTransferObjects.DvoranaTipSjedista>();
            CreateMap<Models.DvoranaTipSjedista, DataTransferObjects.Requests.DvoranaTipSjedistaUpsertRequest>().ReverseMap();

            //Termin
            CreateMap<Models.Termin, DataTransferObjects.Termin>();
            CreateMap<Models.Termin, DataTransferObjects.Requests.TerminUpsertRequest>().ReverseMap();

            //Glumac
            CreateMap<Models.Glumac, DataTransferObjects.Glumac>();
            CreateMap<Models.Glumac, DataTransferObjects.Requests.GlumacUpsertRequest>().ReverseMap();
            
            //Komentar
            CreateMap<Models.Komentar, DataTransferObjects.Komentar>();
            CreateMap<Models.Komentar, DataTransferObjects.Requests.KomentarInsertRequest>().ReverseMap();

        }
    }
}

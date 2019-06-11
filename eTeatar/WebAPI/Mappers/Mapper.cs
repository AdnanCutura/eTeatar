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
            CreateMap<Models.Grad, DataTransferObjects.Requests.GradSearchRequest>();

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

            //Narudzba
            CreateMap<Models.Narudzba, DataTransferObjects.Narudzba>();
            CreateMap<Models.Narudzba, DataTransferObjects.Requests.NarudzbaInsertRequest>().ReverseMap();

            //Predstava
            CreateMap<Models.Predstava, DataTransferObjects.Predstava>();
            CreateMap<Models.Predstava, DataTransferObjects.Requests.PredstavaUpsertRequest>().ReverseMap();
            //Predstava
            CreateMap<Models.PredstavaZanr, DataTransferObjects.PredstavaZanr>();
            CreateMap<Models.PredstavaZanr, DataTransferObjects.Requests.PredstavaZanrUpsertRequest>().ReverseMap();

            //Narudzba
            CreateMap<Models.KorisnickiNalog, DataTransferObjects.KorisnickiNalog>();
            CreateMap<Models.KorisnickiNalog, DataTransferObjects.Requests.KorisnickiNalogUpsertRequest>().ReverseMap();         
            
            //Kupac
            CreateMap<Models.Kupac, DataTransferObjects.Kupac>();
            CreateMap<DataTransferObjects.Requests.KupacUpsertRequest, Models.Kupac>();
            CreateMap<DataTransferObjects.Kupac, DataTransferObjects.KorisnickiNalog>().ReverseMap();
            CreateMap<Models.Kupac, DataTransferObjects.Requests.KupacKorisnickiNalogUpsertRequest>().ReverseMap();
            CreateMap<DataTransferObjects.Requests.KupacKorisnickiNalogUpsertRequest, DataTransferObjects.Requests.KorisnickiNalogUpsertRequest>().ReverseMap();

            //Administrator
            CreateMap<Models.Administrator, DataTransferObjects.Administrator>();
            CreateMap<DataTransferObjects.Requests.AdministratorUpsertRequest, Models.Administrator>();
            CreateMap<DataTransferObjects.Administrator, DataTransferObjects.KorisnickiNalog>().ReverseMap();
            CreateMap<Models.Administrator, DataTransferObjects.Requests.AdministratorKorisnickiNalogUpsertRequest>().ReverseMap();
            CreateMap<DataTransferObjects.Requests.AdministratorKorisnickiNalogUpsertRequest, DataTransferObjects.Requests.KorisnickiNalogUpsertRequest>().ReverseMap();

            //Korisnicka uloga
            CreateMap<Models.KorisnickaUloga, DataTransferObjects.KorisnickaUloga>();

            //Tip korisnika
            CreateMap<Models.TipKorisnika, DataTransferObjects.TipKorisnika>();

        }
    }
}

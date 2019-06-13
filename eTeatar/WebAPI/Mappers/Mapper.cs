using AutoMapper;
namespace WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            // Teatar
            CreateMap<Models.Teatar, DataTransferObjects.Teatar>();
            CreateMap<Models.Teatar, DataTransferObjects.Requests.TeatarUpsertRequest>().ReverseMap().ForAllMembers(opt => opt.Condition((src, dest, sourceMember) => sourceMember != null));

            //Dvorana
            CreateMap<Models.Dvorana, DataTransferObjects.Dvorana>();
            CreateMap<Models.Dvorana, DataTransferObjects.Requests.DvoranaUpsertRequest>().ReverseMap().ForAllMembers(opt => opt.Condition((src, dest, sourceMember) => sourceMember != null));

            //Obavijest
            CreateMap<Models.Obavijest, DataTransferObjects.Obavijest>();
            CreateMap<Models.Obavijest, DataTransferObjects.Requests.ObavijestUpsertRequest>().ReverseMap().ForAllMembers(opt => opt.Condition((src, dest, sourceMember) => sourceMember != null));

            //Uloga
            CreateMap<Models.Uloga, DataTransferObjects.Uloga>();
            CreateMap<Models.Uloga, DataTransferObjects.Requests.UlogaUpsertRequest>().ReverseMap().ForAllMembers(opt => opt.Condition((src, dest, sourceMember) => sourceMember != null));

            //Žanr
            CreateMap<Models.Zanr, DataTransferObjects.Zanr>();

            //Drzava
            CreateMap<Models.Drzava, DataTransferObjects.Drzava>();

            //Grad
            CreateMap<Models.Grad, DataTransferObjects.Grad>();
            CreateMap<Models.Grad, DataTransferObjects.Requests.GradSearchRequest>();

            //Tip sjedišta
            CreateMap<Models.TipSjedista, DataTransferObjects.TipSjedista>();
            CreateMap<Models.TipSjedista, DataTransferObjects.Requests.TipSjedistaUpsertRequest>().ReverseMap().ForAllMembers(opt => opt.Condition((src, dest, sourceMember) => sourceMember != null));

            //Dvorana Tip sjedišta
            CreateMap<Models.DvoranaTipSjedista, DataTransferObjects.DvoranaTipSjedista>();
            CreateMap<Models.DvoranaTipSjedista, DataTransferObjects.Requests.DvoranaTipSjedistaUpsertRequest>().ReverseMap().ForAllMembers(opt => opt.Condition((src, dest, sourceMember) => sourceMember != null));

            //Termin
            CreateMap<Models.Termin, DataTransferObjects.Termin>();
            CreateMap<Models.Termin, DataTransferObjects.Requests.TerminUpsertRequest>().ReverseMap().ForAllMembers(opt => opt.Condition((src, dest, sourceMember) => sourceMember != null));

            //Glumac
            CreateMap<Models.Glumac, DataTransferObjects.Glumac>();
            CreateMap<Models.Glumac, DataTransferObjects.Requests.GlumacUpsertRequest>().ReverseMap().ForAllMembers(opt => opt.Condition((src, dest, sourceMember) => sourceMember != null));

            //Komentar
            CreateMap<Models.Komentar, DataTransferObjects.Komentar>();
            CreateMap<Models.Komentar, DataTransferObjects.Requests.KomentarInsertRequest>().ReverseMap().ForAllMembers(opt => opt.Condition((src, dest, sourceMember) => sourceMember != null));

            //Narudzba
            CreateMap<Models.Narudzba, DataTransferObjects.Narudzba>();
            CreateMap<Models.Narudzba, DataTransferObjects.Requests.NarudzbaInsertRequest>().ReverseMap().ForAllMembers(opt => opt.Condition((src, dest, sourceMember) => sourceMember != null));

            //Predstava
            CreateMap<Models.Predstava, DataTransferObjects.Predstava>();
            CreateMap<Models.Predstava, DataTransferObjects.Requests.PredstavaUpsertRequest>().ReverseMap().ForAllMembers(opt => opt.Condition((src, dest, sourceMember) => sourceMember != null));
            //Predstava
            CreateMap<Models.PredstavaZanr, DataTransferObjects.PredstavaZanr>();
            CreateMap<Models.PredstavaZanr, DataTransferObjects.Requests.PredstavaZanrUpsertRequest>().ReverseMap().ForAllMembers(opt => opt.Condition((src, dest, sourceMember) => sourceMember != null));

            //KorisnickiNalog
            CreateMap<Models.KorisnickiNalog, DataTransferObjects.KorisnickiNalog>();
            CreateMap<Models.KorisnickiNalog, DataTransferObjects.Requests.KorisnickiNalogUpsertRequest>().ReverseMap().ForAllMembers(opt => opt.Condition((src, dest, sourceMember) => sourceMember != null));

            //Spol
            CreateMap<Models.Spol, DataTransferObjects.Spol>();

            //Kupac
            CreateMap<Models.Kupac, DataTransferObjects.Kupac>();
            CreateMap<DataTransferObjects.Requests.KupacUpsertRequest, Models.Kupac>().ForAllMembers(opt => opt.Condition((src, dest, sourceMember) => sourceMember != null));
            CreateMap<DataTransferObjects.Kupac, DataTransferObjects.KorisnickiNalog>().ReverseMap();
            CreateMap<Models.Kupac, DataTransferObjects.Requests.KupacKorisnickiNalogUpsertRequest>().ReverseMap().ForAllMembers(opt => opt.Condition((src, dest, sourceMember) => sourceMember != null));
            CreateMap<DataTransferObjects.Requests.KupacKorisnickiNalogUpsertRequest, DataTransferObjects.Requests.KorisnickiNalogUpsertRequest>().ReverseMap().ForAllMembers(opt => opt.Condition((src, dest, sourceMember) => sourceMember != null));
            CreateMap<DataTransferObjects.Requests.KupacKorisnickiNalogUpsertRequest, DataTransferObjects.Requests.KupacUpsertRequest>().ReverseMap();

            //Administrator
            CreateMap<Models.Administrator, DataTransferObjects.Administrator>();
            CreateMap<DataTransferObjects.Requests.AdministratorUpsertRequest, Models.Administrator>().ForAllMembers(opt => opt.Condition((src, dest, sourceMember) => sourceMember != null));
            CreateMap<DataTransferObjects.Administrator, DataTransferObjects.KorisnickiNalog>().ReverseMap();
            CreateMap<Models.Administrator, DataTransferObjects.Requests.AdministratorKorisnickiNalogUpsertRequest>().ReverseMap().ForAllMembers(opt => opt.Condition((src, dest, sourceMember) => sourceMember != null));
            CreateMap<DataTransferObjects.Requests.AdministratorKorisnickiNalogUpsertRequest, DataTransferObjects.Requests.KorisnickiNalogUpsertRequest>().ReverseMap().ForAllMembers(opt => opt.Condition((src, dest, sourceMember) => sourceMember != null));
            CreateMap<DataTransferObjects.Requests.AdministratorKorisnickiNalogUpsertRequest, DataTransferObjects.Requests.AdministratorUpsertRequest>().ReverseMap().ForAllMembers(opt => opt.Condition((src, dest, sourceMember) => sourceMember != null));

            //Korisnicka uloga
            CreateMap<Models.KorisnickaUloga, DataTransferObjects.KorisnickaUloga>();

            //Tip korisnika
            CreateMap<Models.TipKorisnika, DataTransferObjects.TipKorisnika>();

            // Ocjena
            CreateMap<Models.Ocjena, DataTransferObjects.Ocjena>();

        }
    }
}

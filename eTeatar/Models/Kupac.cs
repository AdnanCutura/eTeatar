using System.Collections.Generic;

namespace Models
{
    public sealed class Kupac
    {
        public Kupac()
        {
            Komentari = new HashSet<Komentar>();
            Narudzbe = new HashSet<Narudzba>();
        }
        public string Id { get; set; }

        //Nalog
        public string KorisnickiNalogId { get; set; }
        public KorisnickiNalog KorisnickiNalog { get; set; }

        //Tip korisnika (npr. Basic, Platinum, Silver...)
        public string TipKorisnikaId { get; set; }
        public TipKorisnika TipKorisnika { get; set; }

        //Svi komentari koje je korisnik ostavio
        public ICollection<Komentar> Komentari { get; set; }
        //Sve narudzbe koje je korisnik ostvario
        public ICollection<Narudzba> Narudzbe { get; set; }
    }
}
using System.Collections.Generic;

namespace Database
{
    public class Kupac
    {
        public Kupac()
        {
            Komentari = new HashSet<Komentar>();
            Narudzbe = new HashSet<Narudzba>();
        }
        public string Id { get; set; }

        //Nalog
        public string KorisnikId { get; set; }
        public virtual Korisnik Korisnik { get; set; }

        //Tip korisnika (npr. Basic, Platstringum, Silver...)
        public string TipKorisnikaId { get; set; }
        public virtual TipKorisnika TipKorisnika { get; set; }

        //Svi komentari koje je korisnik ostavio
        public virtual ICollection<Komentar> Komentari { get; set; }
        //Sve narudzbe koje je korisnik ostvario
        public virtual ICollection<Narudzba> Narudzbe { get; set; }
    }
}

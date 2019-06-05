using System.Collections.Generic;

namespace Models
{
    public class Grad : IIsDeleted
    {
        public Grad()
        {
            Korisnici = new HashSet<Korisnik>();
            Teatri = new HashSet<Teatar>();
        }

        public string Id { get; set; }
        public string Naziv { get; set; }

        public string DrzavaId { get; set; }
        public virtual Drzava Drzava { get; set; }

        //Svi teatri koji se nalaze u gradu
        public virtual ICollection<Teatar> Teatri { get; set; }
        //Svi korisnici koji dolaze iz grada
        public virtual ICollection<Korisnik> Korisnici { get; set; }
        public bool IsDeleted { get; set; }
    }
}

using System.Collections.Generic;

namespace Database
{
    public class Predstava : IIsDeleted
    {

        public Predstava()
        {
            Uloge = new HashSet<Uloga>();
            Zanrovi = new HashSet<PredstavaZanr>();
            Termini = new HashSet<Termin>();
        }

        public string Id { get; set; }
        public string Naziv { get; set; }
        public string SlikaLink { get; set; }

        public string Trajanje { get; set; }
        public string Opis { get; set; }

        public string ReziserImePrezime { get; set; }
        public string NazivIzvornogDjela { get; set; }


        //Sve uloge u predstavi
        public virtual ICollection<Uloga> Uloge { get; set; }
        //Svi zanrovi u koje predstava spada
        public virtual ICollection<PredstavaZanr> Zanrovi { get; set; }
        //Termini igranja perdstave
        public virtual ICollection<Termin> Termini { get; set; }

        public bool IsDeleted { get; set; }
    }
}

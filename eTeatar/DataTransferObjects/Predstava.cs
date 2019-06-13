
using System.Collections.Generic;

namespace DataTransferObjects
{
    public class Predstava
    {
        public string Id { get; set; }
        public string Naziv { get; set; }
        public byte[] Slika { get; set; }

        public string Trajanje { get; set; }
        public string Opis { get; set; }

        public string ReziserImePrezime { get; set; }
        public string NazivIzvornogDjela { get; set; }
        public string PisacIzvornogDjela { get; set; }


        public virtual List<Uloga> Uloge { get; set; }

        public virtual List<Zanr> Zanrovi { get; set; }

        public virtual List<Termin> Termini { get; set; }
    }
}

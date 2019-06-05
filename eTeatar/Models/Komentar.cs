using System;

namespace Models
{
    public class Komentar : IIsDeleted
    {
        public string Id { get; set; }

        //Datum i vrijeme kada je korisnik ostavio komentar
        public DateTime DatumVrijeme { get; set;}

        public string Sadrzaj { get; set; }

        //Korisnik koji je ostavio komentar
        public string KupacId { get; set; }
        public virtual Kupac Kupac { get; set; }

        //Obavijest na kojoj se komentar nalazi
        public string ObavijestId { get; set; }
        public virtual Obavijest Obavijest { get; set; }

        public bool IsDeleted { get; set; }
    }
}

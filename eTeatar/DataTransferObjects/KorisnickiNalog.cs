using System;

namespace DataTransferObjects
{
    public class KorisnickiNalog
    {
        public string Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string Adresa { get; set; }

        public byte[] Slika { get; set; }
        public string GradId { get; set; }
        public string KorisnickaUlogaId { get; set; }

        public string KorisnickoIme { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public DateTime DatumKreiranja { get; set; }
    }
}

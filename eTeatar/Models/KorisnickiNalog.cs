using Microsoft.AspNetCore.Identity;
using System;

namespace Models
{
    public class KorisnickiNalog : IIsDeleted
    {
        public string Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public byte[] Slika { get; set; }

        public string KorisnickaUlogaId { get; set; }
        public virtual KorisnickaUloga KorisnickaUloga { get; set; }

        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public bool IsDeleted { get; set; }
    }
}

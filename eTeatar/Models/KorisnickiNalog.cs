using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Models
{
    public class KorisnickiNalog : IIsDeleted
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno")]
        public string Ime { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno")]
        public string Prezime { get; set; }
        public byte[] Slika { get; set; }

        public string KorisnickaUlogaId { get; set; }
        public virtual KorisnickaUloga KorisnickaUloga { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno")]
        public string Email { get; set; }
        public string Telefon { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno")]
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public bool IsDeleted { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class KorisnickiNalogUpsertRequest
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        public byte[] Slika { get; set; }
        
        [Required]
        public string Email { get; set; }
        public string Telefon { get; set; }
        [Required]
        public string KorisnickoIme { get; set; }

        [Required]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Passwordi se ne slazu")]
        public string PasswordPotvrda { get; set; }
    }
}

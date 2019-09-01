using System.ComponentModel.DataAnnotations;

namespace DataTransferObjects.Requests
{
    public class KorisnickiNalogUpdateRequest
    {
        [MaxLength(30)]
        public string Ime { get; set; }
        [MaxLength(30)]
        public string Prezime { get; set; }
        public byte[] Slika { get; set; }

        public string Email { get; set; }
        public string Telefon { get; set; }

        [MinLength(3)]
        [MaxLength(15)]
        public string KorisnickoIme { get; set; }

        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Passwordi se ne slazu")]
        public string PasswordPotvrda { get; set; }
    }
}

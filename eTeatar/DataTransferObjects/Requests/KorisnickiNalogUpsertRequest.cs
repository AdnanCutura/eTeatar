using System.ComponentModel.DataAnnotations;

namespace DataTransferObjects.Requests
{
    public class KorisnickiNalogUpsertRequest
    {
        [MaxLength(30)]
        //[Required(ErrorMessage = "Ovo polje je obavezno")]
        public string Ime { get; set; }
        [MaxLength(30)]
        //[Required(ErrorMessage = "Ovo polje je obavezno")]
        public string Prezime { get; set; }
        public byte[] Slika { get; set; }

        //[Required(ErrorMessage = "Ovo polje je obavezno")]
        public string Email { get; set; }
        public string Telefon { get; set; }

        [MinLength(3)]
        [MaxLength(15)]
        //[Required(ErrorMessage = "Ovo polje je obavezno")]
        public string KorisnickoIme { get; set; }

        //[Required(ErrorMessage = "Ovo polje je obavezno")]
        public string Password { get; set; }
        //[Required(ErrorMessage = "Ovo polje je obavezno")]
        [Compare("Password", ErrorMessage = "Passwordi se ne slazu")]
        public string PasswordPotvrda { get; set; }
    }
}

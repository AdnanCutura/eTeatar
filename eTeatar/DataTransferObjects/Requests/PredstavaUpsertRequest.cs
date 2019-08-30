using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataTransferObjects.Requests
{
    public class PredstavaUpsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        public byte[] Slika { get; set; }

        [Required]
        public string Trajanje { get; set; }
        public string Opis { get; set; }

        public string ReziserImePrezime { get; set; }
        public string NazivIzvornogDjela { get; set; }
        public string PisacIzvornogDjela { get; set; }

    }
}

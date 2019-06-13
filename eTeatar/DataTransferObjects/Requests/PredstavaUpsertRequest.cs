using System.Collections.Generic;

namespace DataTransferObjects.Requests
{
    public class PredstavaUpsertRequest
    {
        public string Naziv { get; set; }
        public byte[] Slika { get; set; }

        public string Trajanje { get; set; }
        public string Opis { get; set; }

        public string ReziserImePrezime { get; set; }
        public string NazivIzvornogDjela { get; set; }
        public string PisacIzvornogDjela { get; set; }

    }
}

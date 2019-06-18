using System;
using System.Collections.Generic;

namespace DataTransferObjects
{
    public class Teatar
    {
        public string Id { get; set; }
        public string Naziv { get; set; }

        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public DateTime VrijemeOtvaranja { get; set; }
        public DateTime VrijemeZatvaranja { get; set; }

        public List<Dvorana> Dvorane { get; set; }
        public Grad Grad { get; set; }

        public override string ToString()
        {
            return $"{Naziv} ({Grad.Naziv})";
        }
    }
}
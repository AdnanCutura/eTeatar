using System;
using System.Collections.Generic;

namespace DataTransferObjects
{
    public class Kupac : KorisnickiNalog
    {
        public string KorisnickiNalogId { get; set; }
        public TipKorisnika TipKorisnika { get; set; }
        public List<Narudzba> Narudzbe { get; set; }
    }
}

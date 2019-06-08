using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects
{
    public class Narudzba
    {
        public string Id { get; set; }

        public string KupacId { get; set; }

        public string TerminId { get; set; }

        public string TipSjedistaId { get; set; }

        public double CijenaKarte { get; set; }

        public string Kolicina { get; set; }

        public DateTime DatumKupovine { get; set; }

        public string OcjenaId { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects
{
    public class Narudzba
    {
        public string Id { get; set; }

        [JsonIgnore]
        public string KupacId { get; set; }
        public Kupac Kupac { get; set; }

        public Termin Termin { get; set; }

        public TipSjedista TipSjedista { get; set; }

        public double CijenaKarte { get; set; }

        public int Kolicina { get; set; }

        public DateTime DatumKupovine { get; set; }

        public bool IsSkenirana { get; set; }

        public Ocjena Ocjena { get; set; }
    }
}

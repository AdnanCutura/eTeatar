using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects
{
    public class Termin
    {
        public DateTime DatumVrijeme { get; set; }
        public string PredstavaId { get; set; }
        public string DvoranaId { get; set; }
        public string BaznaCijenaKarte { get; set; }
    }
}

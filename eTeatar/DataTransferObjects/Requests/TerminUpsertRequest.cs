using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class TerminUpsertRequest
    {
        public DateTime DatumVrijeme { get; set; }
        public string PredstavaId { get; set; }
        public string DvoranaId { get; set; }
        public double BaznaCijenaKarte { get; set; }
    }
}

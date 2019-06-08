using System;
using System.Collections.Generic;

namespace DataTransferObjects.Requests
{
    public class PredstavaSearchRequest
    {
        public string Naziv { get; set; }

        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }

        public double? Ocjena { get; set; }

        public Enums.OrderBy Order { get; set; }
        public Enums.PredstavaOrderBy OrderBy { get; set; }

        public virtual List<string> Zanrovi { get; set; }
    }
}

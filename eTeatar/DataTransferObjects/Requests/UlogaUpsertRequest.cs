using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class UlogaUpsertRequest
    {
        public string Naziv { get; set; }

        public bool IsGlavnaUloga { get; set; }

        public string PredstavaId { get; set; }
        public string GlumacId { get; set; }
    }
}

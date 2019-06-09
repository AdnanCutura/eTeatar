using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class TerminSearchRequest
    {
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public string PredstavaId { get; set; }
        public string DvoranaId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class ObavijestSearchRequest
    {
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
    }
}

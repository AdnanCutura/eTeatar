using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class KomentarInsertRequest
    {
        public DateTime DatumVrijeme { get; set; }
        public string Sadrzaj { get; set; }

        public string KupacId { get; set; }
        public string ObavijestId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects
{
    public class Komentar
    {
        public string Id { get; set; }

        public DateTime DatumVrijeme { get; set; }
        public string Sadrzaj { get; set; }

        public string KupacId { get; set; }
        public string ObavijestId { get; set; }
    }
}

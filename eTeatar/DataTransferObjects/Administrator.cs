using System;
using System.Collections.Generic;

namespace DataTransferObjects
{
    public class Administrator : KorisnickiNalog
    {
        public string KorisnickiNalogId { get; set; }
        public List<Obavijest> Obavijesti { get; set; }
    }
}

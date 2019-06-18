using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class OcjenaInsertRequest
    {
        public int Vrijednost { get; set; }
        public string NarudzbaId { get; set; }
        public string Review { get; set; }
    }
}

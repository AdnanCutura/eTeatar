using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class KupacUpsertRequest : KorisnickiNalogUpsertRequest
    {
         public string KorisnickiNalogId { get; set; }
    }
}

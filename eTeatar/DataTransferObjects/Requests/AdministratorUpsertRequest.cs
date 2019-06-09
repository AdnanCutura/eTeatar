using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class AdministratorUpsertRequest : KorisnickiNalogUpsertRequest
    {
         public string KorisnickiNalogId { get; set; }
    }
}

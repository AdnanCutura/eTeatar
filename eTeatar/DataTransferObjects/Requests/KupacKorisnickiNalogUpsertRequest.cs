using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class KupacKorisnickiNalogUpsertRequest : KorisnickiNalogUpsertRequest
    {
        public string TipKorisnikaId { get; set; }
    }

}

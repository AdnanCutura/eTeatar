using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class KupacKorisnickiNalogInsertRequest : KorisnickiNalogInsertRequest
    {
        public string TipKorisnikaId { get; set; }
    }

}

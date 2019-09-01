using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class KupacKorisnickiNalogUpdateRequest : KorisnickiNalogUpdateRequest
    {
        public string TipKorisnikaId { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class TipSjedistaUpsertRequest
    {
        public string Naziv { get; set; }
        public double CijenaKarteMultiplier { get; set; }
    }
}

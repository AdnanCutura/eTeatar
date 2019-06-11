using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects
{
    public class TipKorisnika
    {
        public string Id { get; set; }

        public string Naziv { get; set; }

        public double Cijena { get; set; }

        public double CijenaKartePopust { get; set; }
        public string IduciTipKorisnikaId { get; set; }

        public bool IsOsnovni { get; set; }
    }
}
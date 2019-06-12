using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects
{
    public class Obavijest
    {
        public string Id { get; set; }
        public string Naslov { get; set; }
        public DateTime DatumVrijeme { get; set; }

        public string Sadrzaj { get; set; }
        public string SlikaLink { get; set; }

        public string AdministratorId { get; set; }

        //public Administrator Administrator { get; set; }

        //public DateTime MinDate { get; set; };
        //public DateTime MaxDate { get; set; };
    }
}

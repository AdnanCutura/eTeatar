using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class ObavijestUpsertRequest
    {
        public string Naslov { get; set; }
        public DateTime DatumVrijeme { get; set; }

        public string Sadrzaj { get; set; }
        public string SlikaLink { get; set; }

        public string AdministratorId { get; set; }
    }
}

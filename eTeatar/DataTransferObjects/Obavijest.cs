using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DataTransferObjects
{
    public class Obavijest
    {
        public string Id { get; set; }
        public string Naslov { get; set; }
        public DateTime DatumVrijeme { get; set; }

        public string Sadrzaj { get; set; }
        public byte[] Slika { get; set; }

        public Administrator Administrator { get; set; }

        [JsonIgnore]
        public string AdministratorId { get; set; }
    }
}

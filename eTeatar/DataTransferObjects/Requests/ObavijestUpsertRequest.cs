using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class ObavijestUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Naslov { get; set; }
        public DateTime DatumVrijeme { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Sadrzaj { get; set; }
        public byte[] Slika { get; set; }

        public string AdministratorId { get; set; }
    }
}

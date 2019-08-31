using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class KomentarInsertRequest
    {
        [DataType(DataType.DateTime)]
        public DateTime DatumVrijeme { get; set; }
        [Required]
        public string Sadrzaj { get; set; }

        [Required]
        public string KupacId { get; set; }
        [Required]
        public string ObavijestId { get; set; }
    }
}

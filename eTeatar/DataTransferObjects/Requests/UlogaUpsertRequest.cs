using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class UlogaUpsertRequest
    {
        [Required]
        public string Naziv { get; set; }

        public bool IsGlavnaUloga { get; set; }

        [Required]
        public string PredstavaId { get; set; }
        [Required]
        public string GlumacId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class TipSjedistaUpsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        [Required]
        [Range(0,1)]
        public double CijenaKarteMultiplier { get; set; }
    }
}

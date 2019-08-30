using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class TerminUpsertRequest
    {
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DatumVrijeme { get; set; }
        [Required]
        public string PredstavaId { get; set; }
        [Required]
        public string DvoranaId { get; set; }
        [Required]
        [Range(0,int.MaxValue)]
        public double BaznaCijenaKarte { get; set; }
    }
}

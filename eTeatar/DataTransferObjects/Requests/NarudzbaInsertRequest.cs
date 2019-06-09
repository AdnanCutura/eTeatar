using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class NarudzbaInsertRequest
    {
        [Required]
        public string KupacId { get; set; }

        [Required]
        public string TerminId { get; set; }

        [Required]
        public string TipSjedistaId { get; set; }

        [Required]
        public double CijenaKarte { get; set; }

        [Required]
        public string Kolicina { get; set; }
    }
}

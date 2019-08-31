using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class DvoranaTipSjedistaUpsertRequest
    {
        [Required]
        public string DvoranaId { get; set; }
        [Required]
        public string TipSjedistaId { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Samo brojevi")]
        public int BrojSjedista { get; set; }
    }
}

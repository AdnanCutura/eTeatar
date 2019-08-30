using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class OcjenaInsertRequest
    {
        [Required]
        public int Vrijednost { get; set; }
        [Required]
        public string NarudzbaId { get; set; }
    }
}

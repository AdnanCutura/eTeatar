using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class DvoranaUpsertRequest
    {
        [Required]
        public string Naziv { get; set; }

        [Required]
        public string TeatarId { get; set; }
    }
}

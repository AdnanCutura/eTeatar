using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class PredstavaZanrUpsertRequest
    {
        [Required]
        public string PredstavaId { get; set; }
        [Required]
        public string ZanrId { get; set; }
    }
}

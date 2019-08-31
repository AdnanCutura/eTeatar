using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class GlumacUpsertRequest
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        public byte[] Slika{ get; set; }
        public string Biografija { get; set; }
        public string SpolId { get; set; }
    }
}

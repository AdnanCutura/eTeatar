using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class GlumacUpsertRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public byte[] Slika{ get; set; }
        public string Biografija { get; set; }
        public string SpolId { get; set; }
    }
}

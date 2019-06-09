using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class GlumacUpsertRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string SlikaLink { get; set; }
        public string Biografija { get; set; }
    }
}

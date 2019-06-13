using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects
{
    public class Uloga
    {
        public string Id { get; set; }
        public string Naziv { get; set; }

        public bool IsGlavnaUloga { get; set; }

        public Glumac Glumac { get; set; }
        public Predstava Predstava { get; set; }
    }
}

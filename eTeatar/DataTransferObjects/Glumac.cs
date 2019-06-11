using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects
{
    public class Glumac
    {
        public string Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public byte[] Slika { get; set; }
        public string Biografija { get; set; }
        public Spol Spol { get; set; }
    }
}

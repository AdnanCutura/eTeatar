using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects
{
    public class DvoranaTipSjedista
    {
        public string Id { get; set; }
        public Dvorana Dvorana { get; set; }
        public string DvoranaId { get; set; }
        public TipSjedista TipSjedista { get; set; }
        public string TipSjedistaId { get; set; }
        public int BrojSjedista { get; set; }
    }
}

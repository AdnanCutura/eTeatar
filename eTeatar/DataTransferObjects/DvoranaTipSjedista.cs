using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects
{
    public class DvoranaTipSjedista
    {
        public string Id { get; set; }
        public string DvoranaId { get; set; }
        public string TipSjedistaId { get; set; }
        public int BrojSjedista { get; set; }
    }
}

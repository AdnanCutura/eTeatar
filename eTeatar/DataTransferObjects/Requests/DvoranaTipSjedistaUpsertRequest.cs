using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class DvoranaTipSjedistaUpsertRequest
    {
        public string DvoranaId { get; set; }
        public string TipSjedistaId { get; set; }
        public int BrojSjedista { get; set; }
    }
}

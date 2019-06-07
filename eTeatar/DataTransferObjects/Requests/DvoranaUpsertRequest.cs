using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class DvoranaUpsertRequest
    {
        public string Naziv { get; set; }

        public string TeatarId { get; set; }
    }
}

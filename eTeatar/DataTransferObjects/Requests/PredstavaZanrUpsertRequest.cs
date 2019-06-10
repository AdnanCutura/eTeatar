using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class PredstavaZanrUpsertRequest
    {
        public string PredstavaId { get; set; }
        public string ZanrId { get; set; }
    }
}

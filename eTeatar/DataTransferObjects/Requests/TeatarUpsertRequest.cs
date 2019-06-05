using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class TeatarUpsertRequest
    {
        public string Naziv { get; set; }

        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public DateTime VrijemeOtvaranja { get; set; }
        public DateTime VrijemeZatvaranja { get; set; }

        public string GradId { get; set; }
    }
}

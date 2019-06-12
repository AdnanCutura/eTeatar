using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Spol:IIsDeleted
    {
        public string Id { get; set; }
        public string Naziv { get; set; }
        public bool IsDeleted { get; set; }
    }
}

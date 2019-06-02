using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class Avatar:IIsDeleted
    {
        public string Id { get; set; }
        public string Lstringk { get; set; }
        public bool IsDeleted { get; set; }
    }
}

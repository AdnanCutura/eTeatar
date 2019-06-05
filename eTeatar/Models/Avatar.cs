using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Avatar:IIsDeleted
    {
        public string Id { get; set; }
        public string Link { get; set; }
        public bool IsDeleted { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Database
{
    public class Teatar : IIsDeleted
    {

        public Teatar()
        {
            Dvorane = new HashSet<Dvorana>();
        }

        public string Id { get; set; }
        public string Naziv { get; set; }

        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public DateTime VrijemeOtvaranja { get; set; }
        public DateTime VrijemeZatvaranja { get; set; }

        //Grad u kojem se nalazi teatar
        public string GradId { get; set; }
        public virtual Grad Grad { get; set; }

        //Dvorane koje se nalaze u teatru
        public virtual ICollection<Dvorana> Dvorane { get; set; }
        public bool IsDeleted { get; set; }
    }
}
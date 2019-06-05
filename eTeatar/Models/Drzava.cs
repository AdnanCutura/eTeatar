using System.Collections.Generic;

namespace Models
{
    public class Drzava : IIsDeleted
    {
        public Drzava()
        {
            Gradovi = new HashSet<Grad>();
        }

        public string Id { get; set; }
        public string Naziv { get; set; }

        //Gradovi u drzavi
        public virtual ICollection<Grad> Gradovi { get; set; }
        public bool IsDeleted { get; set; }
    }
}

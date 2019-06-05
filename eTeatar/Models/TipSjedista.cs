using System.Collections.Generic;

namespace Models
{
    public class TipSjedista : IIsDeleted
    {
        
        public TipSjedista()
        {
            Dvorane = new HashSet<DvoranaTipSjedista>();
        }

        public string Id { get; set; }

        public string Naziv { get; set; }

        public double CijenaKarteMultiplier { get; set; }

        //Sve dvorane sa tipom sjedista
        public virtual ICollection<DvoranaTipSjedista> Dvorane { get; set; }

        public bool IsDeleted { get; set; }
    }
}

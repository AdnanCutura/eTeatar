using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database
{
    public class Dvorana : IIsDeleted
    {
        public Dvorana()
        {
            TipoviSjedista = new HashSet<DvoranaTipSjedista>();
            Termini = new HashSet<Termin>();
        }

        public string Id { get; set; }

        public string Naziv { get; set; }

        //Teatar u kojem se nalazi dvorana
        public string TeatarId { get; set; }
        public virtual Teatar Teatar { get; set; }

        //Sjedista u dvorani
        public virtual ICollection<DvoranaTipSjedista> TipoviSjedista { get; set; }

        //Svi Termini u dvorani
        public virtual ICollection<Termin> Termini { get; set; }
        public bool IsDeleted { get; set; }
    }
}

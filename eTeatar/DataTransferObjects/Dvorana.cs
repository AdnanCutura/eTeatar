using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects
{
    public class Dvorana
    {
        public string Id { get; set; }

        public string Naziv { get; set; }

        public Teatar Teatar { get; set; }

        //Sjedista u dvorani
        public virtual ICollection<DvoranaTipSjedista> TipoviSjedista { get; set; }

        //Svi Termini u dvorani
        public virtual ICollection<Termin> Termini { get; set; }
    }
}

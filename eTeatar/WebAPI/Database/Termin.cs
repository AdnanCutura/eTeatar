using System;
using System.ComponentModel.DataAnnotations;

namespace Database
{
    public class Termin : IIsDeleted
    {
        public string Id { get; set; }

        public DateTime DatumVrijeme { get; set; }

        //Predstava koja ce se odrzati
        public string PredstavaId { get; set; }
        public virtual Predstava Predstava { get; set; }

        //Dvorana u kojoj ce se odrzati predstava
        public string DvoranaId { get; set; }
        public virtual Dvorana Dvorana { get; set; }

        //Cijena koja se mnozi sa TipSjedista.CijenaKarteMultiplier i TipKorstringika.CijenaKartePopust
        public string BaznaCijenaKarte { get; set; }

        public bool IsDeleted { get; set; }
    }
}

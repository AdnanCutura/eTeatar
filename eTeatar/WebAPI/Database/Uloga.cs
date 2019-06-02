using System.ComponentModel.DataAnnotations;

namespace Database
{
    public class Uloga : IIsDeleted
    {
        public string Id { get; set; }

        public string Naziv { get; set; }

        //True ukoliko je uloga glavna
        public bool IsGlavnaUloga { get; set; }

        //Predstava u kojoj
        public string PredstavaId { get; set; }
        public virtual Predstava Predstava { get; set; }

        //Glumac ima ulogu
        public string GlumacId { get; set; }
        public  Glumac Glumac { get; set; }

        public bool IsDeleted { get; set; }
    }
}

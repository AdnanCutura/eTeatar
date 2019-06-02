using System.Collections.Generic;

namespace Database
{
    public class Administrator
    {

        public  Administrator()
        {
            Obavijesti = new HashSet<Obavijest>();
        }

        public string Id { get; set; }

        //Nalog
        public string KorisnikId { get; set; }
        public virtual Korisnik Korisnik { get; set; }

        //Sve obavijesti koje je Admstringistrator objavio
        public virtual ICollection<Obavijest> Obavijesti { get; set; }
    }
}   

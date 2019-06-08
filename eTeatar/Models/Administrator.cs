using System.Collections.Generic;

namespace Models
{
    public class Administrator
    {

        public  Administrator()
        {
            Obavijesti = new HashSet<Obavijest>();
        }

        public string Id { get; set; }

        //Nalog
        public string KorisnickiNalogId { get; set; }
        public virtual KorisnickiNalog KorisnickiNalog { get; set; }

        //Sve obavijesti koje je Admstringistrator objavio
        public virtual ICollection<Obavijest> Obavijesti { get; set; }
    }
}   

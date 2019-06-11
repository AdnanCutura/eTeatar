using System.Collections.Generic;

namespace Models
{
    public class Glumac : IIsDeleted
    {
        public Glumac()
        {
            Uloge = new HashSet<Uloga>();
        }

        public string Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public byte[] Slika { get; set; }
        public string Biografija { get; set; }


        public string SpolId { get; set; }
        public Spol Spol { get; set; }
        //Sve uloge koje ima glumac
        public virtual ICollection<Uloga> Uloge { get; set; }
        public bool IsDeleted { get; set; }
    }
}

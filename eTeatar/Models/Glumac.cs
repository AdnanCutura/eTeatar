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
        public string SlikaLstringk { get; set; }
        public string Biografija { get; set; }

        //Sve uloge koje ima glumac
        public virtual ICollection<Uloga> Uloge { get; set; }
        public bool IsDeleted { get; set; }
    }
}

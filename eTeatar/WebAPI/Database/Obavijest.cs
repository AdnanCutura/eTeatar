using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database
{
    public class Obavijest : IIsDeleted
    {

        public Obavijest()
        {
            Komentari = new HashSet<Komentar>();
        }
        public string Id { get; set; }
        public string Naslov { get; set; }
        public DateTime DatumVrijeme { get; set; }

        public string Sadrzaj { get; set; }
        public string SlikaLink { get; set; }


        //Administrator koji je kreirao obavijest
        public string AdministratorId { get; set; }
        public virtual Administrator Administrator { get; set; }

        //Svi komentari na obavijesti
        public virtual ICollection<Komentar> Komentari { get; set; }

        public bool IsDeleted { get; set; }
    }
}

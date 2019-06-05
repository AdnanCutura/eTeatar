using System.Collections.Generic;

namespace Models
{
    public class Zanr : IIsDeleted
    {

        public Zanr()
        {
            Predstave = new HashSet<PredstavaZanr>();
        }
        public string Id { get; set; }

        public string Naziv { get; set; }

        //Sve predstave koje pripadaju zanru
        public virtual ICollection<PredstavaZanr> Predstave { get; set; }

        public bool IsDeleted { get; set; }
    }
}

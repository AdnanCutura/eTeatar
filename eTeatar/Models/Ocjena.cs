namespace Models
{
    public class Ocjena : IIsDeleted
    {
        public string Id { get; set; }

        public int Vrijednost { get; set; }
        public string Review { get; set; }

        public string NarudzbaId { get; set; }
        public virtual Narudzba Narudzba { get; set; }

        public bool IsDeleted { get; set; }
    }
}

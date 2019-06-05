namespace Models
{
    public class Ocjena : IIsDeleted
    {
        public string Id { get; set; }

        public int Vrijednost { get; set; }
        public string Review { get; set; }

        public bool IsDeleted { get; set; }
    }
}

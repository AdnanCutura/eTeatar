namespace Models
{
    public class DvoranaTipSjedista : IIsDeleted
    {
        public string Id { get; set; }
        public virtual Dvorana Dvorana { get; set; }

        public string TipSjedistaId { get; set; }
        public virtual TipSjedista TipSjedista { get; set; }

        public int BrojSjedista { get; set; }

        public bool IsDeleted { get; set; }
    }
}

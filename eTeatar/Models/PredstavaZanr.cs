namespace Models
{
    public class PredstavaZanr : IIsDeleted
    {
        public string Id { get; set; }

        public string PredstavaId { get; set; }
        public virtual Predstava Predstava { get; set; }

        public string ZanrId { get; set; }
        public virtual Zanr Zanr { get; set; }
        public bool IsDeleted { get; set; }
    }
}

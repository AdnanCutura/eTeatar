namespace Models
{
    public class TipKorisnika : IIsDeleted
    {
        public string Id { get; set; }

        public string Naziv { get; set; }

        public int Cijena { get; set; }

        //Od 0 do 100
        public double CijenaKartePopust { get; set; }
        public string IduciTipKorisnikaId { get; set; }
        public virtual TipKorisnika IduciTipKorisnika { get; set; }

        public bool IsOsnovni { get; set; }

        public bool IsDeleted { get; set; }
    }
}

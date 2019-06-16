using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms.Models
{
    public enum MenuItemType
    {
        Pocetna,
        Predstave,
        Termini,
        Obavijesti,
        MojePredstave,
        MojProfil
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}

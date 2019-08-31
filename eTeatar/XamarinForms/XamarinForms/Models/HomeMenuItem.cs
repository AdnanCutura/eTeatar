using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms.Models
{
    public enum MenuItemType
    {
        HomePage,
        Predstave,
        Termini,
        Obavijesti,
        MojePredstave,
        MojProfil,
        Ocjene,
        Registracija,
        Prijava
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}

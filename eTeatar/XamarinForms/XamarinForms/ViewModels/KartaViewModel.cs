using DataTransferObjects;

namespace XamarinForms.ViewModels
{
    public class KartaViewModel : BaseViewModel
    {
        private readonly APIService _serviceNarudzba;
        public Narudzba Narudzba { get; set; }

        public KartaViewModel()
        {
            _serviceNarudzba = new APIService("Narudzba");
        }

    }
}

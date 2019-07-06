using DataTransferObjects;
using DataTransferObjects.Requests;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms.ViewModels
{
    public class MojProfilViewModel
    {
        private readonly APIService _serviceKupacKorisnickiNalog;
        public Kupac Kupac { get; set; }
        public string NovaLozinka { get; set; }
        public string PotvrdaLozinke { get; set; }

        public MojProfilViewModel()
        {
            Kupac = Helpers.KupacData.Get();
            _serviceKupacKorisnickiNalog = new APIService("Kupac");
            UpdatePasswordCommand = new Command(async () => await UpdatePassword());
            UpgradeAccountCommand = new Command(async () => await UpgradeAccount());
        }

        public ICommand UpdateProfilCommand { get; set; }
        public ICommand UpdatePasswordCommand { get; set; }
        public ICommand UpgradeAccountCommand { get; set; }

        public async Task UpdateProfil(byte[] slika = null)
        {
            KupacKorisnickiNalogUpsertRequest request = new KupacKorisnickiNalogUpsertRequest
            {
                Ime = Kupac.Ime,
                Prezime = Kupac.Prezime,
                Email = Kupac.Email,
                Telefon = Kupac.Telefon,
                Slika = slika
            };

            try
            {
                var response = await _serviceKupacKorisnickiNalog.Update<Kupac>(Kupac.Id, request);
                await Application.Current.MainPage.DisplayAlert("Informacija", "Uspješno ste spremili podatke", "OK");
            }
            catch
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Provjerite podatke i pokušajte ponovo", "OK");
            }
        }

        private async Task UpdatePassword()
        {
            KupacKorisnickiNalogUpsertRequest request = new KupacKorisnickiNalogUpsertRequest
            {
                Password = NovaLozinka,
                PasswordPotvrda = PotvrdaLozinke
            };

            try
            {
                var response = await _serviceKupacKorisnickiNalog.Update<Kupac>(Kupac.Id, request);
                await Application.Current.MainPage.DisplayAlert("Informacija", "Lozinka je uspješno promjenjena", "OK");
            }
            catch
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Provjerite podatke i pokušajte ponovo", "OK");
            }
        }

        private async Task UpgradeAccount()
        {
            var sljedeciTipId = Kupac.TipKorisnika.IduciTipKorisnikaId;
            KupacUpsertRequest request = new KupacUpsertRequest
            {
                TipKorisnikaId = sljedeciTipId,
                KorisnickiNalogId = Kupac.KorisnickiNalogId
            };

            try
            {
                var response = await _serviceKupacKorisnickiNalog.Update<Kupac>(Kupac.Id, request);
                await Application.Current.MainPage.DisplayAlert("Informacija", "Lozinka je uspješno promjenjena", "OK");
            }
            catch
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Desila se greška, molimo vas da pokušate ponovo", "OK");
            }
        }
    }
}

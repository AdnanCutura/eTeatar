using System.ComponentModel;
using System.Runtime.CompilerServices;
using DataTransferObjects;
using DataTransferObjects.Requests;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinForms.Annotations;

namespace XamarinForms.ViewModels
{
    public class MojProfilViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private readonly APIService _serviceKupacKorisnickiNalog;

        private Kupac _kupac;
        public Kupac Kupac {
            get => _kupac;
            set {
                _kupac = value;
                OnPropertyChanged();
            }
        }
        private string _tipKupca;
        public string TipKupca {
            get => _tipKupca;
            set {
                _tipKupca = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Kupac));
            }
        }

        public string NovaLozinka { get; set; }
        public string PotvrdaLozinke { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MojProfilViewModel()
        {
            _kupac = Helpers.KupacData.Get();
            _tipKupca = Kupac.TipKorisnika.Naziv;
            _serviceKupacKorisnickiNalog = new APIService("Kupac");
            InitCommand = new Command(async () => await Init());
            InitCommand.Execute(null);
            UpdatePasswordCommand = new Command(async () => await UpdatePassword());
            UpgradeAccountCommand = new Command(async () => await UpgradeAccount());
        }

        public ICommand InitCommand { get; set; }
        public ICommand UpdateProfilCommand { get; set; }
        public ICommand UpdatePasswordCommand { get; set; }
        public ICommand UpgradeAccountCommand { get; set; }

        private async Task Init()
        {
            var kupac = await _serviceKupacKorisnickiNalog.GetById<Kupac>(Kupac.Id);
            var sljedeciTipId = kupac.TipKorisnika.IduciTipKorisnikaId;
        }

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
            var kupac = await _serviceKupacKorisnickiNalog.GetById<Kupac>(_kupac.Id);
            var sljedeciTipId = kupac.TipKorisnika.IduciTipKorisnikaId;

            if (sljedeciTipId != null)
            {
                KupacUpsertRequest request = new KupacUpsertRequest
                {
                    TipKorisnikaId = sljedeciTipId
                };

                try
                {
                    var response = await _serviceKupacKorisnickiNalog.Update<Kupac>(_kupac.Id, request);

                    _tipKupca = response.TipKorisnika.Naziv;
                   
                    OnPropertyChanged(nameof(TipKupca));
                    await Application.Current.MainPage.DisplayAlert("Informacija", "Akaunt uspješno nadograđen",
                        "OK");
                }
                catch
                {
                    await Application.Current.MainPage.DisplayAlert("Greška",
                        "Desila se greška, molimo vas da pokušate ponovo", "OK");
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Informacija",
                    "Trenutno ne postoji veći nivo korisničkog računa od trenutnog", "OK");
            }
        }




    }
}
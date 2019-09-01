using DataTransferObjects;
using DataTransferObjects.Requests;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinForms.Helpers;

namespace XamarinForms.ViewModels
{
    public class MojProfilViewModel : BaseViewModel
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
            }
        }

        public byte[] Picture {
            get => _picture;
            set => SetProperty(ref _picture, value);
        }
        private byte[] _picture;

        private string _novaLozinka;
        public string NovaLozinka {
            get => _novaLozinka;
            set => SetProperty(ref _novaLozinka, value);
        }

        private string _potvrdaLozinke;
        public string PotvrdaLozinke {
            get => _potvrdaLozinke;
            set => SetProperty(ref _potvrdaLozinke, value);
        }

        public MojProfilViewModel()
        {
            _kupac = Helpers.KupacData.Get();
            _tipKupca = Kupac.TipKorisnika.Naziv;
            _serviceKupacKorisnickiNalog = new APIService("Kupac");
            Picture = Kupac.Slika;

            InitCommand = new Command(async () => await Init());
            InitCommand.Execute(null);

            UpdatePasswordCommand = new Command(async () => await UpdatePassword());
            UpgradeAccountCommand = new Command(async () => await UpgradeAccount());
            UploadPictureCommand = new Command(async () =>  Picture = await UploadPicture.UploadingPicture(Picture));
            UpdateProfilCommand = new Command(async () => await UpdateProfil());
        }

        public ICommand InitCommand { get; set; }
        public ICommand UpdateProfilCommand { get; set; }
        public ICommand UpdatePasswordCommand { get; set; }
        public ICommand UpgradeAccountCommand { get; set; }
        public ICommand UploadPictureCommand { get; set; }

        /// <summary>
        /// Metoda za dobavljanje kupca
        /// </summary>
        private async Task Init()
        {
            var kupac = await _serviceKupacKorisnickiNalog.GetById<Kupac>(Kupac.Id);
            var sljedeciTipId = kupac.TipKorisnika.IduciTipKorisnikaId;
            IsVisible = sljedeciTipId != null;
        }

        /// <summary>
        /// Metoda za uređivanje profila
        /// </summary>
        public async Task UpdateProfil()
        {
            var request = new KupacKorisnickiNalogUpsertRequest
            {
                Ime = Kupac.Ime,
                Prezime = Kupac.Prezime,
                Email = Kupac.Email,
                Telefon = Kupac.Telefon,
                Slika = Picture
            };

            try
            {
                await _serviceKupacKorisnickiNalog.Update<Kupac>(Kupac.Id, request);
                await Application.Current.MainPage.DisplayAlert("Informacija", "Uspješno ste spremili podatke", "OK");
            }
            catch
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Provjerite podatke i pokušajte ponovo", "OK");
            }
        }

        /// <summary>
        /// Metoda za promjenu lozinke
        /// </summary>
        private async Task UpdatePassword()
        {
            var request = new KupacKorisnickiNalogUpsertRequest
            {
                Password = NovaLozinka,
                PasswordPotvrda = PotvrdaLozinke
            };

            try
            {
                var response = await _serviceKupacKorisnickiNalog.Update<Kupac>(Kupac.Id, request);
                NovaLozinka = string.Empty;
                PotvrdaLozinke = string.Empty;
                await Application.Current.MainPage.DisplayAlert("Informacija", "Lozinka je uspješno promjenjena", "OK");
            }
            catch
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Provjerite podatke i pokušajte ponovo", "OK");
            }
        }

        /// <summary>
        /// Metoda za nadograđivanje akaunta
        /// </summary>
        private async Task UpgradeAccount()
        {
            var kupac = await _serviceKupacKorisnickiNalog.GetById<Kupac>(_kupac.Id);
            var sljedeciTipId = kupac.TipKorisnika.IduciTipKorisnikaId;

            if (sljedeciTipId != null)
            {
                KupacKorisnickiNalogUpsertRequest request = new KupacKorisnickiNalogUpsertRequest
                {
                    TipKorisnikaId = sljedeciTipId
                };

                try
                {
                    var response = await _serviceKupacKorisnickiNalog.Update<Kupac>(_kupac.Id, request);

                    _tipKupca = response.TipKorisnika.Naziv;
                    if (_tipKupca == "Gold")
                        IsVisible = false;

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
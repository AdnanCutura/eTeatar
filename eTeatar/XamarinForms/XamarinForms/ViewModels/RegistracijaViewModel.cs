using DataTransferObjects;
using DataTransferObjects.Requests;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinForms.Helpers;
using XamarinForms.Views;

namespace XamarinForms.ViewModels
{
    public class RegistracijaViewModel : BaseViewModel
    {
        private readonly APIService _serviceKupacKorisnickiNalog;
        private readonly APIService _kupacService;

        public Kupac Kupac { get; set; }
        public string NovaLozinka { get; set; }
        public string PotvrdaLozinke { get; set; }

        private byte[] _picture;
        public byte[] Picture {
            get => _picture;
            set => SetProperty(ref _picture, value);
        }

        public RegistracijaViewModel()
        {
            Kupac = new Kupac();
            Picture = File.ReadAllBytes("defaultAvatar.png");
            _kupacService = new APIService("Kupac");
            _serviceKupacKorisnickiNalog = new APIService("Kupac");

            InsertKupacCommand = new Command(async () => await InsertKupac(), () => !IsBusy);
            UploadPictureCommand = new Command(async () => Picture = await UploadPicture.UploadingPicture(Picture));
        }

        public Command InsertKupacCommand { get; set; }
        public ICommand UploadPictureCommand { get; set; }

        /// <summary>
        /// Metoda za kreiranje kupca
        /// </summary>
        public async Task InsertKupac()
        {
            IsBusy = true;
            InsertKupacCommand.ChangeCanExecute();

            KupacKorisnickiNalogInsertRequest request = new KupacKorisnickiNalogInsertRequest
            {
                Ime = Kupac.Ime,
                Prezime = Kupac.Prezime,
                Email = Kupac.Email,
                Telefon = Kupac.Telefon,
                KorisnickoIme = Kupac.KorisnickoIme,
                Slika = Picture,
                Password = NovaLozinka,
                PasswordPotvrda = PotvrdaLozinke
            };

            try
            {
                var response = await _serviceKupacKorisnickiNalog.Insert<Kupac>(request);

                APIService.Username = request.KorisnickoIme;
                APIService.Password = request.Password;

                var list = await _kupacService.Get<List<DataTransferObjects.Kupac>>(null);
                KupacData.Set(list.FirstOrDefault(w => w.KorisnickoIme == Kupac.KorisnickoIme));
                Application.Current.MainPage = new MainPage();

                await Application.Current.MainPage.DisplayAlert("Informacija", "Uspješno ste se registrovali", "OK");

                IsBusy = false;
                InsertKupacCommand.ChangeCanExecute();
            }
            catch
            {
                IsBusy = false;
                InsertKupacCommand.ChangeCanExecute();
               // await Application.Current.MainPage.DisplayAlert("Greška", "Provjerite podatke i pokušajte ponovo", "OK");
            }
        }

    }
}

using System;
using DataTransferObjects;
using DataTransferObjects.Requests;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;
using XamarinForms.Convertor;
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

            InsertKupacCommand = new Command(async () => await InsertKupac());
            UploadPictureCommand = new Command(async () => await UploadPicture());
        }

        public ICommand InsertKupacCommand { get; set; }
        public ICommand UploadPictureCommand { get; set; }

        /// <summary>
        /// Metoda za kreiranje kupca
        /// </summary>
        public async Task InsertKupac()
        {
            var request = new KupacKorisnickiNalogUpsertRequest
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

                if (response != null)
                    try
                    {
                        var list = await _kupacService.Get<List<DataTransferObjects.Kupac>>(null);
                        KupacData.Set(list.FirstOrDefault(w => w.KorisnickoIme == Kupac.KorisnickoIme));
                        Application.Current.MainPage = new MainPage();
                        await Application.Current.MainPage.DisplayAlert("Informacija", "Uspješno ste se registrovali", "OK");
                    }
                    catch
                    {
                        // ignored
                    }

            }
            catch
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Provjerite podatke i pokušajte ponovo", "OK");
            }
        }

        /// <summary>
        /// Metoda za dodavanje slike iz datoteke
        /// </summary>
        public async Task UploadPicture()
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsPickPhotoSupported)
                await Application.Current.MainPage.DisplayAlert("Nije podržano", "Ova funkcionalnost nije podržana na vašem uređaju", "Ok");

            var mediaOptions = new PickMediaOptions()
            {
                PhotoSize = PhotoSize.Medium
            };

            var selectedImageFile = await CrossMedia.Current.PickPhotoAsync(mediaOptions);

            if (selectedImageFile == null)
                await Application.Current.MainPage.DisplayAlert("Greška", "Slika nije učitana, pokušajte ponovo", "Ok");
            else
                Picture = new ImageConverter().StreamToBytes(selectedImageFile.GetStream());

        }
    }
}

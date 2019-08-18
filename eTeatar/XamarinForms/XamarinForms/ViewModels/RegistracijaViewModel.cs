using System;
using System.Collections;
using DataTransferObjects;
using DataTransferObjects.Requests;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Android;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
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

        public RegistracijaViewModel()
        {
            Kupac = new Kupac { Slika = File.ReadAllBytes("defaultAvatar.png") };
            _kupacService = new APIService("Kupac");
            _serviceKupacKorisnickiNalog = new APIService("Kupac");
        }

        public ICommand InsertKupacCommand { get; set; }

        public async Task InsertKupac(byte[] slika = null)
        {

            KupacKorisnickiNalogUpsertRequest request = new KupacKorisnickiNalogUpsertRequest
            {
                Ime = Kupac.Ime,
                Prezime = Kupac.Prezime,
                Email = Kupac.Email,
                Telefon = Kupac.Telefon,
                KorisnickoIme = Kupac.KorisnickoIme,
                Slika = slika,
                Password = NovaLozinka,
                PasswordPotvrda = PotvrdaLozinke
            };

            try
            {
                var response = await _serviceKupacKorisnickiNalog.Insert<Kupac>(request);
                await Application.Current.MainPage.DisplayAlert("Informacija", "Uspješno ste se registrovali", "OK");

                try
                {
                    var list = await _kupacService.Get<List<DataTransferObjects.Kupac>>(null);
                    KupacData.Set(list.FirstOrDefault(w => w.KorisnickoIme == Kupac.KorisnickoIme));
                    Application.Current.MainPage = new MainPage();
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

    }
}

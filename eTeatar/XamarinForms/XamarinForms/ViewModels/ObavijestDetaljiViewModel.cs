using DataTransferObjects;
using DataTransferObjects.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms.ViewModels
{
    public class ObavijestDetaljiViewModel : BaseViewModel
    {
        private readonly APIService _serviceKomentar;
        private readonly APIService _serviceObavijest;

        private Obavijest _obavijest;
        public Obavijest Obavijest {
            get => _obavijest;
            set => SetProperty(ref _obavijest, value);
        }

        public Kupac Kupac { get; set; }

        private readonly string _obavijestId;

        private string _komentar;
        public string Komentar {
            get => _komentar;
            set => SetProperty(ref _komentar, value);
        }

        private int _brojKomentara;

        public int BrojKomentara {
            get => _brojKomentara;
            set {
                SetProperty(ref _brojKomentara, value);
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Komentar> Komentari { get; set; }

        public ObavijestDetaljiViewModel(string id)
        {
            _obavijestId = id;
            Kupac = Helpers.KupacData.Get();
            Komentar = string.Empty;
            Komentari = new ObservableCollection<Komentar>();
            _serviceKomentar = new APIService("Komentar");
            _serviceObavijest = new APIService("Obavijest");

            InitCommand = new Command(async () => await Init());
            NoviKomentarCommand = new Command(async () => await NoviKomentar());

            InitCommand.Execute(null);
        }

        public ICommand NoviKomentarCommand { get; set; }
        public ICommand InitCommand { get; set; }

        /// <summary>
        /// Metoda za inicijalno učitavanje komentara
        /// </summary>
        private async Task Init()
        {
            Obavijest = await _serviceObavijest.GetById<Obavijest>(_obavijestId);

            if (!Komentari.Any())
                await LoadKomentare();

            else
            {
                Komentari.Clear();
                await LoadKomentare();
            }
        }

        /// <summary>
        /// Metoda za dodavanje komentara
        /// </summary>
        private async Task NoviKomentar()
        {
            if (!string.IsNullOrEmpty(_komentar))
            {
                var noviKomentar = new KomentarInsertRequest
                {
                    DatumVrijeme = DateTime.Now,
                    KupacId = Kupac.Id,
                    Sadrzaj = _komentar,
                    ObavijestId = Obavijest.Id
                };

                try
                {
                    await _serviceKomentar.Insert<Komentar>(noviKomentar);
                    InitCommand.Execute(null);
                    BrojKomentara++;
                    Komentar = string.Empty;
                    await Application.Current.MainPage.DisplayAlert("Informacija", "Uspješno ste se ostavili komentar", "OK");

                }
                catch
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Provjerite podatke i pokušajte ponovo", "OK");
                }
            }
            else
                await Application.Current.MainPage.DisplayAlert("Greška", "Komentar ne može biti prazan!", "OK");

        }

        /// <summary>
        /// Metoda za učitavanje komentara
        /// </summary>
        private async Task LoadKomentare()
        {
            try
            {
                var list = await _serviceKomentar.Get<List<Komentar>>(new KomentarSearchRequest
                {
                    ObavijestId = Obavijest.Id
                });
                BrojKomentara = list.Count;
                foreach (var item in list)
                    Komentari.Add(item);
            }
            catch
            {
                // ignored
            }
        }
    }
}
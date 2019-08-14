using DataTransferObjects;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms.ViewModels
{
    public class NarudzbaViewModel : BaseViewModel
    {
        private readonly APIService _dvoranaTipSjedistaService = new APIService("DvoranaTipSjedista");
        private readonly APIService _narudzbaService = new APIService("Narudzba");
        public Termin Termin { get; set; }

        public ObservableCollection<DvoranaTipSjedista> TipoviSjedista { get; set; } = new ObservableCollection<DvoranaTipSjedista>();

        private DvoranaTipSjedista _selectedTipSjedista = null;
        public DvoranaTipSjedista SelectedTipSjedista
        {
            get => _selectedTipSjedista;
            set
            {
                SetProperty(ref _selectedTipSjedista, value);
                UpdateCijena();
            }
        }

        private int _kolicina = 1;
        public int Kolicina
        {
            get => _kolicina;
            set
            {
                SetProperty(ref _kolicina, value);
                UpdateCijena();
            }
        }

        private double _cijena;
        public double Cijena { get => _cijena; set => SetProperty(ref _cijena, value); }

        public ICommand InitCommand { get; private set; }
        public ICommand AddCommand { get; private set; }
        public ICommand SubCommand { get; private set; }
        public ICommand KupiCommand { get; private set; }
        public ICommand CloseCommand { get; private set; }

        public NarudzbaViewModel()
        {
            InitCommand = new Command(async () => await Initialize());
            AddCommand = new Command(() => Kolicina++);
            SubCommand = new Command(() => { if (Kolicina > 1) Kolicina--; } );
            KupiCommand = new Command(async () => await Kupi());
            CloseCommand = new Command(async () => await Application.Current.MainPage.Navigation.PopModalAsync());
        }

        public async Task Kupi()
        {
            try
            {
                var narudzba = await _narudzbaService.Insert<DataTransferObjects.Narudzba>(new DataTransferObjects.Requests.NarudzbaInsertRequest
                {
                    Kolicina = Kolicina,
                    KupacId = Helpers.KupacData.Get().Id,
                    TerminId = Termin.Id,
                    TipSjedistaId = SelectedTipSjedista.TipSjedista.Id
                });
                if (!string.IsNullOrEmpty(narudzba.Id))
                {
                    var stringBuilder = new StringBuilder();
                    await Application.Current.MainPage.DisplayAlert("Uspjesno kupljeno", stringBuilder.ToString(), "OK");
                }
            }
            catch { }

            await Application.Current.MainPage.Navigation.PopModalAsync();
        }

        public async Task Initialize()
        {
            try
            {
                var list = await _dvoranaTipSjedistaService.Get<List<DataTransferObjects.DvoranaTipSjedista>>(new DataTransferObjects.Requests.DvoranaTipSjedistaSearchRequest { DvoranaId = Termin.Dvorana.Id });
                foreach (var item in list)
                {
                    TipoviSjedista.Add(item);
                }
            }
            catch { }

            SelectedTipSjedista = TipoviSjedista[0];
        }

        private void UpdateCijena()
        {
            var bazna = Termin.BaznaCijenaKarte;
            var kolicina = _kolicina <= 0 ? 0 : _kolicina;
            var mult = SelectedTipSjedista?.TipSjedista?.CijenaKarteMultiplier ?? 0;
            var popust = Helpers.KupacData.Get().TipKorisnika.CijenaKartePopust;
            Cijena = bazna * kolicina * mult * popust;
        }
    }
}

using DataTransferObjects;
using DataTransferObjects.Requests;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms.ViewModels
{
    public class PredstavaDetaljiViewModel : BaseViewModel
    {
        private readonly APIService _serviceUloga;
        private readonly APIService _serviceNarudzba;
        private readonly APIService _servicePredstava;
        private readonly APIService _servicePreporucenePredstave;

        private string _zanrovi;
        public string Zanrovi {
            get => _zanrovi;
            set => SetProperty(ref _zanrovi, value);
        }

        private int _brojOcjena;
        public int BrojOcjena {
            get => _brojOcjena;
            set {
                SetProperty(ref _brojOcjena, value);
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Uloga> Uloge { get; set; }
        public ObservableCollection<Predstava> PreporucenePredstave { get; set; }
        private Predstava _predstava;
        public Predstava Predstava { get { return _predstava; } set { SetProperty(ref _predstava, value); } }

        private string _predstavaId;

        public PredstavaDetaljiViewModel(string id)
        {
            _predstavaId = id;
            Uloge = new ObservableCollection<Uloga>();
            PreporucenePredstave = new ObservableCollection<Predstava>();

            _serviceUloga = new APIService("Uloga");
            _serviceNarudzba = new APIService("Narudzba");
            _servicePreporucenePredstave = new APIService("Predstava/GetPreporucene");
            _servicePredstava = new APIService("Predstava");


            InitCommand = new Command(async () => await Init());
            InitCommand.Execute(null);
            IsVisible = false;
        }

        public ICommand InitCommand { get; set; }
        
        /// <summary>
        /// Inicijalno učitavanje predstava
        /// </summary>
        private async Task Init()
        {
            Predstava = await _servicePredstava.GetById<Predstava>(_predstavaId);

            Zanrovi = string.Join(", ", Predstava.Zanrovi.Select(z => z.Naziv).ToList());
            try
            {
                // Uloge
                var uloge = await _serviceUloga.Get<List<Uloga>>(new UlogaSearchRequest { PredstavaId = Predstava.Id });

                foreach (var item in uloge)
                    Uloge.Add(item);

                // Broj ocjena
                var narudzbe = await _serviceNarudzba
                    .Get<List<Narudzba>>(new NarudzbaSearchRequest { NazivPredstave = Predstava.Naziv });

                BrojOcjena = narudzbe.Where(n => n.Ocjena != null && n.Termin.Predstava.Id == Predstava.Id)
                    .Select(n => n.Ocjena)
                    .Count();

                //Preporucene predstave
                var preporucene = await _servicePreporucenePredstave.GetById<List<Predstava>>(Predstava.Id);

                foreach (var item in preporucene)
                    PreporucenePredstave.Add(item);

            }
            catch
            {
                // ignored
            }
        }
    }
}

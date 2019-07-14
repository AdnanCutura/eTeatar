using System.Collections.Generic;
using System.Collections.ObjectModel;
using DataTransferObjects;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using DataTransferObjects.Requests;
using Xamarin.Forms;

namespace XamarinForms.ViewModels
{
    public class PredstavaDetaljiViewModel : BaseViewModel
    {
        private readonly APIService _serviceUloga = new APIService("Uloga");
        private readonly APIService _serviceNarudzba = new APIService("Narudzba");

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
        public Predstava Predstava { get; set; }

        public PredstavaDetaljiViewModel()
        {
            Uloge = new ObservableCollection<Uloga>();
            InitCommand = new Command(async () => await Init());
            IsVisible = false;
        }

        public ICommand InitCommand { get; set; }

   
        private async Task Init()
        {
           
            Zanrovi = string.Join(", ", Predstava.Zanrovi.Select(z => z.Naziv).ToList());
            try
            {
                var list = await _serviceUloga.Get<List<Uloga>>(new UlogaSearchRequest
                {
                    PredstavaId = Predstava.Id
                });

                foreach (var item in list)
                    Uloge.Add(item);

                //Broj ocjena
                var narudzbe = await _serviceNarudzba.Get<List<Narudzba>>(new NarudzbaSearchRequest
                {
                    NazivPredstave = Predstava.Naziv
                });
                BrojOcjena = narudzbe.Select(n => n.Ocjena != null).Count();
            }
            catch
            {
                // ignored
            }
        }
    }
}

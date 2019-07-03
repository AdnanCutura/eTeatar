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
        private readonly APIService _serviceUloga = new APIService("uloga");
        private string _zanrovi;
        public string Zanrovi {
            get => _zanrovi;
            set => SetProperty(ref _zanrovi, value);
        }

        public ObservableCollection<Uloga> Uloge { get; set; }

        public Predstava Predstava { get; set; }

        public PredstavaDetaljiViewModel()
        {
            Uloge = new ObservableCollection<Uloga>();
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }

        private async Task Init()
        {
            Zanrovi = string.Join(", ", Predstava.Zanrovi.Select(z => z.Naziv).ToList());
            try
            {
                var list = await _serviceUloga.Get<List<DataTransferObjects.Uloga>>(new UlogaSearchRequest
                {
                    PredstavaId = Predstava.Id
                });

                foreach (var item in list)
                    Uloge.Add(item);

            }
            catch
            {
                // ignored
            }
        }
    }
}

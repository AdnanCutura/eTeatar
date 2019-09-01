using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinForms.Views;

namespace XamarinForms.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        public ObservableCollection<DataTransferObjects.Termin> IgrajuUskoro { get; set; } = new ObservableCollection<DataTransferObjects.Termin>();
        public ObservableCollection<DataTransferObjects.Obavijest> Obavijesti { get; set; } = new ObservableCollection<DataTransferObjects.Obavijest>();

        private readonly APIService _terminService = new APIService("Termin");
        private readonly APIService _obavijestiService = new APIService("Obavijest");

        private INavigation _navigation;

        public HomePageViewModel(INavigation navigation)
        {
            _navigation = navigation;
            InitCommand = new Command(async () => await Initalize());
            InitCommand.Execute(null);
            SelectedPredstavaCommand = new Command(async (o) => await SelectedPredstava(o as string));
            SelectedObavijestCommand = new Command(async (o) => await SelectedObavijest(o as string));
        }

        private ICommand InitCommand { get; set; }

        public ICommand SelectedPredstavaCommand { get; set; }
        public async Task SelectedPredstava(string Id)
        {
            await _navigation.PushAsync(new PredstavaDetaljiPage(Id));
        }

        public ICommand SelectedObavijestCommand { get; set; }
        public async Task SelectedObavijest(string Id)
        {
            await _navigation.PushAsync(new ObavijestDetaljiPage(Id));
        }

        public async Task Initalize()
        {
            try
            {
                List<DataTransferObjects.Termin> termini = await _terminService.Get<List<DataTransferObjects.Termin>>(null);

                var term = termini.OrderBy(o => o.DatumVrijeme).ThenBy(o => o.DatumVrijeme.TimeOfDay).ToList();

                foreach (var termin in term)
                    if(!IgrajuUskoro.Select(s=>s.Predstava.Id).ToList().Contains(termin.Predstava.Id))
                        IgrajuUskoro.Add(termin);
            }
            catch { }

            try
            {
                List<DataTransferObjects.Obavijest> obavijesti = await _obavijestiService.Get<List<DataTransferObjects.Obavijest>>(null);

                foreach (var obavijest in obavijesti)
                    Obavijesti.Add(obavijest);
            }
            catch { }
        }
    }
}

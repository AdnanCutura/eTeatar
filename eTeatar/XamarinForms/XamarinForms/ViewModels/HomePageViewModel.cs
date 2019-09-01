using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinForms.Views;

namespace XamarinForms.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        public ObservableCollection<DataTransferObjects.Predstava> IgrajuUskoro { get; set; } = new ObservableCollection<DataTransferObjects.Predstava>();
        public ObservableCollection<DataTransferObjects.Obavijest> Obavijesti { get; set; } = new ObservableCollection<DataTransferObjects.Obavijest>();

        private readonly APIService _predstavaService = new APIService("Predstava");
        private readonly APIService _obavijestiService = new APIService("Obavijest");

        private readonly INavigation _navigation;

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
                // Predstave
                List<DataTransferObjects.Predstava> predstave =
                    await _predstavaService.Get<List<DataTransferObjects.Predstava>>(null);

                foreach (var predatava in predstave)
                    IgrajuUskoro.Add(predatava);

                // Obavijesti
                List<DataTransferObjects.Obavijest> obavijesti =
                    await _obavijestiService.Get<List<DataTransferObjects.Obavijest>>(null);

                foreach (var obavijest in obavijesti)
                    Obavijesti.Add(obavijest);
            }
            catch
            {
                // ignored
            }
        }
    }
}

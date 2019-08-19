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
    public class OcjeneViewModel : BaseViewModel
    {
        private readonly APIService _narudzbaService = new APIService("Narudzba");

        public ObservableCollection<DataTransferObjects.Narudzba> NaruzbaList { get; set; } = new ObservableCollection<DataTransferObjects.Narudzba>();
        public ObservableCollection<DataTransferObjects.Narudzba> NaruzbaHistoryList { get; set; } = new ObservableCollection<DataTransferObjects.Narudzba>();

        public ICommand Init { get; private set; }
        public INavigation _navigation { get; set; }

        public OcjeneViewModel(INavigation Navigation)
        {
            Init = new Command(async () => await Initalize());
            _navigation = Navigation;
            OstaviOcjenuCommand = new Command<object>(async (o) => await OstaviOcjenu(o));
            Init.Execute(null);
        }

        private async Task Initalize()
        {
            try
            {
                var list = await _narudzbaService.Get<List<DataTransferObjects.Narudzba>>(new DataTransferObjects.Requests.NarudzbaSearchRequest { KupacId = Helpers.KupacData.Get().Id });

                NaruzbaList.Clear();
                NaruzbaHistoryList.Clear();
                foreach (var item in list)
                    if (item?.Ocjena == null)
                        NaruzbaList.Add(item);
                    else
                        NaruzbaHistoryList.Add(item);
            }
            catch { }
        }

        public ICommand OstaviOcjenuCommand { get; private set; }

        private async Task OstaviOcjenu(object Id)
        {
            var id = Id as string;
            await _navigation.PushModalAsync(new OstaviOcjenuPage(id));
        }
    }
}

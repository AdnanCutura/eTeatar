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
    public class ObavijestViewModel:BaseViewModel
    {
        private readonly APIService _obavijestService = new APIService("Obavijest");
        private readonly INavigation _navigation;
        private ObservableCollection<DataTransferObjects.Obavijest> _obavijestList;
        public ObservableCollection<DataTransferObjects.Obavijest> ObavijestList { get { return _obavijestList; } set {SetProperty(ref _obavijestList, value); } }
        public ICommand Init { get; private set; }
        public ICommand SelectedCommand { get; private set; }
        public ICommand WorkAround { get; set; }

        public ObavijestViewModel(INavigation Navigation)
        {
            ObavijestList = new ObservableCollection<DataTransferObjects.Obavijest>();
            Init = new Command(async () => await Initialize());
            SelectedCommand = new Command<object>(async (o) => await Selected(o));
            Init.Execute(null);
            WorkAround = new Command(async () => await Workaround());
            WorkAround.Execute(null);
            _navigation = Navigation;
        }

        public async Task Selected(object o)
        {
            string Id = o as string;
            await _navigation.PushAsync(new ObavijestDetaljiPage(Id));
        }

        public async Task Initialize()
        {
            try
            {
                var list = await _obavijestService.Get<List<DataTransferObjects.Obavijest>>(null);

                list.OrderBy(o => o.DatumVrijeme);

                foreach (var item in list)
                    ObavijestList.Add(item);
            }
            catch {}

            await Task.Delay(1000);
            await _navigation.PushAsync(new Workaround());
            await _navigation.PopAsync();
        }

        public async Task Workaround()
        {
            await Task.Delay(1000);
            await _navigation.PushAsync(new Workaround());
            await _navigation.PopAsync();
        }


    }
}

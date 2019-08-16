using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<DataTransferObjects.Obavijest> ObavijestList { get; set; } = new ObservableCollection<DataTransferObjects.Obavijest>();
        public ICommand Init { get; private set; }
        public ICommand SelectedCommand { get; private set; }

        public ObavijestViewModel(INavigation Navigation)
        {
            Init = new Command(async () => await Initialize());
            SelectedCommand = new Command<object>(async (o) => await Selected(o));
            Init.Execute(null);
            _navigation = Navigation;
        }

        public async Task Selected(object o)
        {
            string Id = o as string;
            //ObavijestDetailsPage
            await _navigation.PushAsync(new ObavijestDetaljiPage(Id));
        }

        public async Task Initialize()
        {
            try
            {
                var list = await _obavijestService.Get<List<DataTransferObjects.Obavijest>>(null);

                foreach (var item in list)
                    ObavijestList.Add(item);
            }
            catch {}
        }


    }
}

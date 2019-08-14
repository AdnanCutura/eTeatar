using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms.ViewModels
{
    public class ObavijestViewModel:BaseViewModel
    {
        private readonly APIService _obavijestService = new APIService("Obavijest");
        public ObservableCollection<DataTransferObjects.Obavijest> ObavijestList { get; set; } = new ObservableCollection<DataTransferObjects.Obavijest>();
        public ICommand Init { get; private set; }
        public ICommand SelectedCommand { get; private set; }

        public ObavijestViewModel()
        {
            Init = new Command(async () => await Initialize());
            SelectedCommand = new Command<object>(async (o) => await Selected(o));
            Init.Execute(null);
        }

        public async Task Selected(object o)
        {
            string Id = o as string;
            //ObavijestDetailsPage
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

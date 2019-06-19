using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms.ViewModels
{
    public class MojePredstaveViewModel: BaseViewModel
    {

        private readonly APIService _narudzbaService = new APIService("Narudzba");

        public ObservableCollection<DataTransferObjects.Narudzba> NarudzbaList { get; set; } = new ObservableCollection<DataTransferObjects.Narudzba>();
        public MojePredstaveViewModel()
        {
            Init = new Command(async () => await Initialize());

            Init.Execute(null);
        }

        public ICommand Init { get; private set; }

        public async Task Initialize()
        {
            var list = await _narudzbaService.Get<List<DataTransferObjects.Narudzba>>(new DataTransferObjects.Requests.NarudzbaSearchRequest { KorisnickoIme = Helpers.KupacData.Get().KorisnickoIme });

            foreach (var item in list)
                NarudzbaList.Add(item);
        }
    }
}

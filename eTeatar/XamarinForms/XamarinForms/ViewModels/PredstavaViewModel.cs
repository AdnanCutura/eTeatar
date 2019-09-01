using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DataTransferObjects;
using DataTransferObjects.Requests;
using Xamarin.Forms;
using XamarinForms.Helpers;
using XamarinForms.Views;

namespace XamarinForms.ViewModels
{
    public class PredstavaViewModel : BaseViewModel
    {
        private readonly APIService _predstaveService;
        private readonly INavigation _navigation;
        public PredstavaSearchRequest _search;

        private ObservableCollection<Predstava> _predstavaList;
        public ObservableCollection<Predstava> PredstavaList { get { return _predstavaList; } set { SetProperty(ref _predstavaList, value); } }

        public PredstavaViewModel(PredstavaSearchRequest search, INavigation Navigation)
        {
            _search = search;
            _navigation = Navigation;
            _predstaveService = new APIService("Predstava");

            PredstavaList = new ObservableCollection<Predstava>();

            InitCommand = new Command(async () => await Init());
            SelectedCommand = new Command(async (o) => await Selected(o as string));
        }

        public ICommand InitCommand { get; set; }
        public ICommand SelectedCommand { get; set; }

        public async Task Selected(string Id) => await _navigation.PushAsync(new PredstavaDetaljiPage(Id));

        public async Task Init()
        {
            try
            {
                var list = await _predstaveService.Get<List<Predstava>>(_search);
                foreach (var item in list)
                {
                    PredstavaList.Add(item);
                }
            }
            catch { }

            await Task.Delay(1000);
            await _navigation.PushAsync(new Workaround());
            await _navigation.PopAsync();
        }

    }
}
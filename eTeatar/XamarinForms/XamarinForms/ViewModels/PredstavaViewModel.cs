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


        public ObservableCollection<Predstava> PredstavaList { get; set; }

        public PredstavaSearchRequest _search;

        private string _naziv;
        public string Naziv { get => _naziv; set => _naziv = value; }


        public PredstavaViewModel(PredstavaSearchRequest search, INavigation Navigation)
        {
            _search = search;
            _navigation = Navigation;
            PredstavaList = new ObservableCollection<Predstava>();
            _predstaveService = new APIService("Predstava");
            InitCommand = new Command(async () => await Init());
            SelectedCommand = new Command<object>(async (o) => await Selected(o));
            InitCommand.Execute(null);
        }

        public ICommand InitCommand { get; set; }
        public ICommand SelectedCommand { get; set; }

        public async Task Selected(object o)
        {
            string PredstavaId = o as string;
            //PredstavaDetails Page
            await _navigation.PushAsync(new PredstavaDetaljiPage(PredstavaId));
        }

        public async Task Init()
        {

            try
            {
                var list = await _predstaveService.Get<List<Predstava>>(_search);
                foreach (var item in list)
                    PredstavaList.Add(item);
            }
            catch { }
        }

    }
}
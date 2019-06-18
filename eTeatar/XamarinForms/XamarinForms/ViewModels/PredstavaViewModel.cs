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

namespace XamarinForms.ViewModels
{
    public class PredstavaViewModel : BaseViewModel
    {
        private readonly APIService _predstaveService;

        public ObservableCollection<Predstava> PredstavaList { get; set; }

        public PredstavaSearchRequest _search;

        private string _naziv;
        public string Naziv { get => _naziv; set => _naziv = value; }


        public PredstavaViewModel(PredstavaSearchRequest search)
        {
            _search = search;
            PredstavaList = new ObservableCollection<Predstava>();
            _predstaveService = new APIService("Predstava");
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }

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
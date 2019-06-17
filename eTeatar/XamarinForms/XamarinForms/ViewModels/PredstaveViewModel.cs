using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DataTransferObjects;
using Xamarin.Forms;
using XamarinForms.Helpers;

namespace XamarinForms.ViewModels
{
    public class PredstaveViewModel : BaseViewModel
    {
        private readonly APIService _predstaveService;
        public string Username { get; set; }
        public ObservableCollection<Predstava> PredstavaList { get; set; }
        public PredstaveViewModel()
        {
            PredstavaList =new ObservableCollection<Predstava>();

            _predstaveService = new APIService("Predstava");
            InitCommand = new Command(async()=> await Init());
            InitCommand.Execute(null);
            Username = KupacData.Get().KorisnickoIme;
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
           var list = await _predstaveService.Get<List<DataTransferObjects.Predstava>>(null);
           foreach (var item in list)
               PredstavaList.Add(item);
        }

    }
}
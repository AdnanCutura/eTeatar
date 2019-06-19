using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms.ViewModels
{
    class TerminViewModel:BaseViewModel
    {
        private readonly APIService _terminservice = new APIService("Termin");

        public ObservableCollection<DataTransferObjects.Termin> TerminList { get; set; } = new ObservableCollection<DataTransferObjects.Termin>();

        private DataTransferObjects.Requests.TerminSearchRequest search = new DataTransferObjects.Requests.TerminSearchRequest();
        public string Naziv { get => search.NazivPredstave; set => search.NazivPredstave = value; }

        public TerminViewModel()
        {
            Init = new Command(async () => await Initialize());
            Init.Execute(null);
        }

        public ICommand Init { get; private set; }
        private async Task Initialize()
        {
            try
            {
                var list = await _terminservice.Get<List<DataTransferObjects.Termin>>(search);

                TerminList.Clear();
                foreach (var item in list)
                    //if(item.DatumVrijeme > DateTime.Now)
                    TerminList.Add(item);
            }
            catch { }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms.ViewModels
{
    public class OstaviOcjenuViewModel : BaseViewModel
    {
        private readonly APIService _ocjenaService = new APIService("Ocjena");

        private INavigation _navigation;

        public List<int> ocjene { get; set; } = new List<int> { 1, 2, 3, 4, 5 };

        private int _ocjena;
        public int ocjena { get => _ocjena; set => SetProperty(ref _ocjena, value); }

        private string _id { get; set; }

        public OstaviOcjenuViewModel(string Id, INavigation Navigation)
        {
            _id = Id;
            _navigation = Navigation;

            ocjena = ocjene[4];
            OstaviOcjenuCommand = new Command(async () => await OstaviOcjenu());
            NazadCommand = new Command(async () => await Nazad());
        }

        public ICommand OstaviOcjenuCommand { get; set; }

        public async Task OstaviOcjenu()
        {
            var newOcjena = new DataTransferObjects.Requests.OcjenaInsertRequest
            {
                Review = "",
                NarudzbaId = _id,
                Vrijednost = _ocjena
            };

            try
            {
                await _ocjenaService.Insert<DataTransferObjects.Ocjena>(newOcjena);
                await Application.Current.MainPage.DisplayAlert("Informacija", "Uspješno ste se ostavili ocjenu", "OK");
                await Nazad();
            }
            catch { }
        }

        public ICommand NazadCommand { get; set; }

        public async Task Nazad()
        {
            await _navigation.PopModalAsync();
        }
    }
}

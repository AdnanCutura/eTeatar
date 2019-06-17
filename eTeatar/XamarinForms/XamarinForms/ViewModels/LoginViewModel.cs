using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinForms.Helpers;
using XamarinForms.Views;

namespace XamarinForms.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _kupacService;

        public LoginViewModel()
        {
            _kupacService = new APIService("Kupac");
            LoginCommand = new Command(async () => await Login());
            _username = "Kupac";
            _password = "1";
        }

        private string _username = string.Empty;
        public string Username {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        private string _password;
        public string Password {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public ICommand LoginCommand { get; set; }
        public async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {
                var list = await _kupacService.Get<List<DataTransferObjects.Kupac>>(null);
                KupacData.Set(list.FirstOrDefault(w => w.KorisnickoIme == _username));
                Application.Current.MainPage = new MainPage();
            }
            catch
            {
                // ignored
            }
        }

    }
}

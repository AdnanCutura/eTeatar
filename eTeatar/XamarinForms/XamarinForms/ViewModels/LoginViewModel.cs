using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinForms.Views;

namespace XamarinForms.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _korisnickiNalogService;

        public LoginViewModel()
        {
            _korisnickiNalogService = new APIService("KorisnickiNalog");
            LoginCommand = new Command(async () => await Login());
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
                await _korisnickiNalogService.Get<dynamic>(null);
                Application.Current.MainPage = new MainPage();
            }
            catch
            {
                // ignored
            }
        }

    }
}

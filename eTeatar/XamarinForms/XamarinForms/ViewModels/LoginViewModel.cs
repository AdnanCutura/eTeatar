using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            LoginCommand = new Command(async () => await Login(), () => !IsBusy);
            RegistracijaCommand = new Command(Registracija);
            _username = "Kupac";
            _password = "1";
        }

        private string _username;
        public string Username {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        private string _password;
        public string Password {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public Command RegistracijaCommand { get; set; }
        public Command LoginCommand { get; set; }

        private void Registracija() => Application.Current.MainPage = new RegistracijaPage();

        private async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;
            LoginCommand.ChangeCanExecute();

            try
            {

                var list = await _kupacService.Get<List<DataTransferObjects.Kupac>>(null);
                KupacData.Set(list.FirstOrDefault(w => w.KorisnickoIme == _username));
                LoginCommand.ChangeCanExecute();
                IsBusy = false;
                Application.Current.MainPage = new MainPage();

                //else
                //{
                //    await Application.Current.MainPage.DisplayAlert("Greška", "Podaci nisu ispravni!", "OK");
                //}
            }
            catch
            {
                IsBusy = false;
                LoginCommand.ChangeCanExecute();
            }
        }

    }
}

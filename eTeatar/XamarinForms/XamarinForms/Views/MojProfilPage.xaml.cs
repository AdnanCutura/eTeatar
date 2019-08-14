using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.Convertor;
using XamarinForms.ViewModels;

namespace XamarinForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MojProfilPage : ContentPage
    {
        private byte[] _slikaByte;
        private readonly MojProfilViewModel _model;

        public MojProfilPage()
        {
            InitializeComponent();
            BindingContext = _model = new MojProfilViewModel();
        }

        private async void UploadPicture(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsPickPhotoSupported)
                await DisplayAlert("Nije podržano", "Ova funkcionalnost nije podržana na vašem uređaju", "Ok");

            var mediaOptions = new PickMediaOptions()
            {
                PhotoSize = PhotoSize.Medium
            };

            var selectedImageFile = await CrossMedia.Current.PickPhotoAsync(mediaOptions);

            if (selectedImageFile != null)
            {
                if (KupacAvatar == null)
                    await DisplayAlert("Greška", "Slika nije učitana, pokušajte ponovo", "Ok");

                var slika = ImageSource.FromStream(() => selectedImageFile.GetStream());
                KupacAvatar.Source = slika;
                byte[] imgData = new ImageConverter().StreamToBytes(selectedImageFile.GetStream());
                _slikaByte = imgData;
            }
        }

        private void UpdateProfil(object sender, EventArgs e)
        {
            _model.UpdateProfilCommand = new Command(async () => await _model.UpdateProfil(_slikaByte));
            _model.UpdateProfilCommand.Execute(null);
        }

        private void CleanPassword(object sender, EventArgs e)
        {
            NoviPassword.Text = "";
            PotvrdaPassword.Text = "";
        }
    }
}
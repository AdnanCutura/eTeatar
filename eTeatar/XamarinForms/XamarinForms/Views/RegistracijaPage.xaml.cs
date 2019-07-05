using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.Convertor;
using XamarinForms.ViewModels;

namespace XamarinForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistracijaPage : ContentPage
    {
        private byte[] _slikaByte;
        private readonly RegistracijaViewModel _model;

        public RegistracijaPage()
        {
            InitializeComponent();
            BindingContext = _model = new RegistracijaViewModel();
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

            if (KupacAvatar == null)
                await DisplayAlert("Greška", "Slika nije učitana, pokušajte ponovo", "Ok");

            if (selectedImageFile != null)
            {
                var slika = ImageSource.FromStream(() => selectedImageFile.GetStream());
                KupacAvatar.Source = slika;


                byte[] imgData = new ImageConverter().StreamToBytes(selectedImageFile.GetStream());
                _slikaByte = imgData;
            }
        }

        private void InsertKupac(object sender, EventArgs e)
        {
            _model.InsertKupacCommand = new Command(async () => await _model.InsertKupac(_slikaByte));
            _model.InsertKupacCommand.Execute(null);
        }

    }
}
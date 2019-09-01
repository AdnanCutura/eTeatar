using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;
using XamarinForms.Convertor;

namespace XamarinForms.Helpers
{
    public static class UploadPicture
    {
        /// <summary>
        /// Metoda za dodavanje slike iz datoteke
        /// </summary>
        public static async Task<byte[]> UploadingPicture(byte[] picture)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsPickPhotoSupported)
                await Application.Current.MainPage.DisplayAlert("Nije podržano", "Ova funkcionalnost nije podržana na vašem uređaju", "Ok");

            var mediaOptions = new PickMediaOptions()
            {
                PhotoSize = PhotoSize.Medium
            };

            var selectedImageFile = await CrossMedia.Current.PickPhotoAsync(mediaOptions);

            if (selectedImageFile != null)
                return picture = new ImageConverter().StreamToBytes(selectedImageFile.GetStream());

            await Application.Current.MainPage.DisplayAlert("Greška", "Slika nije učitana, pokušajte ponovo", "Ok");
            return null;
        }
    }
}

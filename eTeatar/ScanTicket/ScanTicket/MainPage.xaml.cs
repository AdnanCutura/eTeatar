using DataTransferObjects;
using DataTransferObjects.Requests;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace ScanTicket
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly APIService _serviceNarudzba = new APIService("Narudzba");
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Skeniraj_kartu(object sender, EventArgs e)
        {
            var scan = new ZXingScannerPage();
            await Navigation.PushAsync(scan);
            scan.OnScanResult += (result) =>
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                    ScanText.Text = "Kod karte: " + result.Text;
                    await _serviceNarudzba.Update<Narudzba>(result.ToString(), new NarudzbaUpdateRequest
                    {
                        IsSkenirana = true
                    });
                });
            };
        }
    }
}

using DataTransferObjects;
using DataTransferObjects.Requests;
using Flurl.Http;
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

        /// <summary>
        /// Event za skeniranje karte
        /// </summary>
        private async void Skeniraj_kartu(object sender, EventArgs e)
        {
            var scan = new ZXingScannerPage();
            await Navigation.PushAsync(scan);
            scan.OnScanResult += (result) =>
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();

                    try
                    {
                        var karta = await _serviceNarudzba.GetById<Narudzba>(result.ToString());

                        if (karta.IsSkenirana)
                        {
                            ScanText.Text = "Karta je već poništena";
                            ScanCode.Text = result.Text;
                            MainLayout.BackgroundColor = Color.Red;
                        }

                        else
                        {
                            ScanText.Text = "Karta je uspješno poništena";
                            ScanCode.Text = result.Text;
                            MainLayout.BackgroundColor = Color.Green;

                            await _serviceNarudzba.Update<Narudzba>(result.ToString(), new NarudzbaUpdateRequest
                            {
                                IsSkenirana = true
                            });
                        }
                    }

                    catch (FlurlHttpException err)
                    {
                        switch (err.Call.HttpStatus)
                        {
                            case System.Net.HttpStatusCode.NotFound:
                                ScanText.Text = "Karta ne postoji";
                                ScanCode.Text = result.Text;
                                MainLayout.BackgroundColor = Color.Red;
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                    }


                });
            };
        }
    }
}

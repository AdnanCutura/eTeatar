using DataTransferObjects;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.ViewModels;
using ZXing.Net.Mobile.Forms;

namespace XamarinForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KartaPage : ContentPage
    {
        private readonly KartaViewModel _model;

        public KartaPage(Narudzba narudzba)
        {
            InitializeComponent();
            BindingContext = _model = new KartaViewModel
            {
                Narudzba = narudzba
            };

            var qrCode = new ZXingBarcodeImageView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                AutomationId = "zxingBarcodeImageView",
                BarcodeFormat = ZXing.BarcodeFormat.QR_CODE,
                BarcodeOptions = {Width = 300, Height = 300, Margin = 10},
                BarcodeValue = narudzba.Id
            };

            var codeTxt = new Label
            {
                Text = narudzba.Id,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                FontSize = 10
           };
;
            QrKarta.Children.Insert(2, qrCode);
            QrKarta.Children.Insert(3, codeTxt);
        }


    }
}
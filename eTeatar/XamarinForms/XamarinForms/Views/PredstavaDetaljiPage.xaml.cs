using DataTransferObjects;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.ViewModels;

namespace XamarinForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PredstavaDetaljiPage : ContentPage
    {
        private PredstavaDetaljiViewModel _model;

        public PredstavaDetaljiPage(string id)
        {
            BindingContext = _model = new PredstavaDetaljiViewModel(id);
            InitializeComponent();
        }

        private void PredstavaDetalji(object sender, SelectedItemChangedEventArgs e)
        {
            var predstava = (Predstava)e.SelectedItem;
            Navigation.PushModalAsync(new PredstavaDetaljiPage(predstava.Id));
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
                await Navigation.PushModalAsync(new NarudzbaPage((Termin)e.SelectedItem));
        }
    }
}
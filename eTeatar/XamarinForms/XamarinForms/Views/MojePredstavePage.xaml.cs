using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObjects;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MojePredstavePage : ContentPage
    {
        public ViewModels.MojePredstaveViewModel model;
        public MojePredstavePage()
        {
            InitializeComponent();
            BindingContext = model = new ViewModels.MojePredstaveViewModel();
        }

        protected override void OnAppearing()
        {
            model.Init.Execute(null);
            base.OnAppearing();
        }

        private async void MojePredstave_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Narudzba;
            await Navigation.PushAsync(new KartaPage(item));
        }
    }
}
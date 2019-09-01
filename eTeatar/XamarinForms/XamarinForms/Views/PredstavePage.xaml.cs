using DataTransferObjects.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.ViewModels;

namespace XamarinForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PredstavePage : ContentPage
    {
        PredstavaViewModel model = null;

        public PredstavePage(PredstavaSearchRequest search = null)
        {
            BindingContext = model = new PredstavaViewModel(search, Navigation);
            model.InitCommand.Execute(null);
            InitializeComponent();
            base.OnAppearing();
        }

        private async void Search(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PredstavaSearchView(model._search));
        }
    }
}
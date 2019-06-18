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
    public partial class PredstavaSearchView : ContentPage
    {
        private PredstavaSearchViewModel model;
        public PredstavaSearchView(PredstavaSearchRequest search)
        {
            InitializeComponent();
            BindingContext = model = new PredstavaSearchViewModel(search);
        }

        private async void Search(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PredstavePage(model._search));
        }
    }
}
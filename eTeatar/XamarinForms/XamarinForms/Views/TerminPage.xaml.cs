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
    public partial class TerminPage : ContentPage
    {
        TerminViewModel model;
        public TerminPage()
        {
            InitializeComponent();
            BindingContext = model = new TerminViewModel();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem!=null)
                await Navigation.PushModalAsync(new NarudzbaPage((DataTransferObjects.Termin)e.SelectedItem));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            TerminList.SelectedItem = null;
        }
    }
}
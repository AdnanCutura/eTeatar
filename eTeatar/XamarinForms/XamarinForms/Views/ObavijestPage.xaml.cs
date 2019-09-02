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
    public partial class ObavijestPage : ContentPage
    {
        public ObavijestViewModel model;
        public ObavijestPage()
        {
            BindingContext = model = new ObavijestViewModel(Navigation);
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.WorkAround.Execute(null);
        }
    }
}
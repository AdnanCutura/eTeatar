using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
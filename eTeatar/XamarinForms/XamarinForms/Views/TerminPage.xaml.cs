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
    }
}
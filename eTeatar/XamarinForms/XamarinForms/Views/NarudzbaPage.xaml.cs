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
    public partial class NarudzbaPage : ContentPage
    {
        NarudzbaViewModel model = null;

        public NarudzbaPage(DataTransferObjects.Termin termin)
        {
            InitializeComponent();
            BindingContext = model = new NarudzbaViewModel { Termin = termin };
            model.InitCommand.Execute(null);
        }
    }
}
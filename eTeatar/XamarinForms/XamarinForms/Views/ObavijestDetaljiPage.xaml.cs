using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DataTransferObjects;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.ViewModels;

namespace XamarinForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ObavijestDetaljiPage : ContentPage
    {
        private ObavijestDetaljiViewModel _model;

        public ObavijestDetaljiPage(string id)
        {

            BindingContext = _model = new ObavijestDetaljiViewModel(id);
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            KomentarEditor.Text = "";
        }
    }
};
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

    }
};
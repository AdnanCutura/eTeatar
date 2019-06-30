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

        private readonly APIService _obavijestService = new APIService("Obavijest");

        private ObavijestDetaljiViewModel _model;
        private readonly string _obavijestId;

        public ObavijestDetaljiPage(string id = "15f54bf3-b185-43ea-ac60-399916781070")
        {
            _obavijestId = id;
            InitializeComponent();
            Init = new Command(async ()=> await Initialize(id));
            Init.Execute(null);
        }

        private ICommand Init { get; set; } 

        public async Task Initialize(string id)
        {
            var ob = await _obavijestService.GetById<Obavijest>(id);
            BindingContext = _model = new ObavijestDetaljiViewModel()
            {
                Obavijest = ob
            };
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            KomentarEditor.Text = "";
        }
    }
};
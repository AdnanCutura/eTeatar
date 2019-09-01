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
    public partial class PredstavaDetaljiPage : ContentPage
    {
        private readonly APIService _predstavaService;
        private PredstavaDetaljiViewModel _model;

        public PredstavaDetaljiPage(string id)
        {
            _predstavaService = new APIService("Predstava");
            InitializeComponent();
            InitCommand = new Command(async () => await Init(id));
            InitCommand.Execute(null);
        }

        public ICommand InitCommand { get; set; }

        public async Task Init(string id)
        {
            try
            {
                var item = await _predstavaService.GetById<Predstava>(id);
                BindingContext = _model = new PredstavaDetaljiViewModel
                {
                    Predstava = item
                };
                _model.InitCommand.Execute(null);
            }
            catch
            {
                // ignored
            }
        }

        private void PredstavaDetalji(object sender, SelectedItemChangedEventArgs e)
        {
            var predstava = (Predstava)e.SelectedItem;
            Navigation.PushModalAsync(new PredstavaDetaljiPage(predstava.Id));
        }
    }
}
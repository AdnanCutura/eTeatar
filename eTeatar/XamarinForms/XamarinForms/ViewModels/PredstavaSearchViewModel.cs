using DataTransferObjects.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms.ViewModels
{
    public class PredstavaSearchViewModel : BaseViewModel
    {
        public class PickerItemO
        {
            public string Naziv { get; set; }
            public DataTransferObjects.Enums.OrderBy Value { get; set; }
        }

        public class PickerItemOC
        {
            public string Naziv { get; set; }
            public int Value { get; set; }
        }

        public class PickerItemOB
        {
            public string Naziv { get; set; }
            public DataTransferObjects.Enums.PredstavaOrderBy Value { get; set; }
        }

        public bool _datumOdSet;
        private DateTime _datumOd;
        public DateTime DatumOd { get => _datumOd; set { SetProperty(ref _datumOd, value); _search.DatumOd = value; _datumOdSet = true; } }

        public bool _datumDoSet;
        private DateTime _datumDo;
        public DateTime DatumDo { get => _datumDo; set { SetProperty(ref _datumDo, value); _search.DatumDo = value; _datumDoSet = true; } }

        public PredstavaSearchRequest _search;
        public string Naziv { get => _search.Naziv; set => _search.Naziv = value; }

        public ObservableCollection<DataTransferObjects.Teatar> Teatri { get; set; } = new ObservableCollection<DataTransferObjects.Teatar>();
        private DataTransferObjects.Teatar _selectedTeatar;
        public DataTransferObjects.Teatar SelectedTeatar { get => _selectedTeatar; set { SetProperty(ref _selectedTeatar, value); _search.TeatarId = value.Id; } }

        public ObservableCollection<PickerItemO> Order { get; set; } = new ObservableCollection<PickerItemO>
            {
                new PickerItemO { Naziv = DataTransferObjects.Enums.OrderBy.Ascending.ToString(), Value = DataTransferObjects.Enums.OrderBy.Ascending },
                new PickerItemO { Naziv = DataTransferObjects.Enums.OrderBy.Descending.ToString(), Value = DataTransferObjects.Enums.OrderBy.Descending }
            };
        private PickerItemO _selectedOrder = null;
        public PickerItemO SelectedOrder { get => _selectedOrder; set { SetProperty(ref _selectedOrder, value); _search.Order = value.Value; } }

        public ObservableCollection<PickerItemOC> Ocjena { get; set; } = new ObservableCollection<PickerItemOC>
            {
                new PickerItemOC{ Naziv = "Sve", Value = 0},
                new PickerItemOC{ Naziv = "1 i vise", Value = 1},
                new PickerItemOC{ Naziv = "2 i vise", Value = 2},
                new PickerItemOC{ Naziv = "3 i vise", Value = 3},
                new PickerItemOC{ Naziv = "4 i vise", Value = 4},
                new PickerItemOC{ Naziv = "5", Value = 5},
            };
        private PickerItemOC _selectedOcjena = null;
        public PickerItemOC SelectedOcjena { get => _selectedOcjena; set { SetProperty(ref _selectedOcjena, value); _search.Ocjena = value.Value; } }

        public ObservableCollection<PickerItemOB> OrderBy { get; set; } = new ObservableCollection<PickerItemOB>
            {
                new PickerItemOB{ Naziv = DataTransferObjects.Enums.PredstavaOrderBy.Datum.ToString(), Value = DataTransferObjects.Enums.PredstavaOrderBy.Datum},
                new PickerItemOB{ Naziv = DataTransferObjects.Enums.PredstavaOrderBy.Ocjena.ToString(), Value = DataTransferObjects.Enums.PredstavaOrderBy.Ocjena}
            };
        private PickerItemOB _selectedOrderBy = null;
        public PickerItemOB SelectedOrderBy { get => _selectedOrderBy; set { SetProperty(ref _selectedOrderBy, value); _search.OrderBy = value.Value; } }

        private readonly APIService _teatarService = new APIService("Teatar");

        public ICommand Init { get; set; }

        public PredstavaSearchViewModel(PredstavaSearchRequest search)
        {
            _search = search;
            if (search == null)
            {
                _search = new PredstavaSearchRequest();
            }

            Init = new Command(async () => await Initialize());
            Init.Execute(null);
        }

        public async Task Initialize()
        {
            SelectedOrder = Order[0];
            SelectedOrderBy = OrderBy[0];
            SelectedOcjena = Ocjena[0];

            DatumOd = DateTime.Now;
            DatumDo = DateTime.Now;

            _datumOdSet = false;
            _datumDoSet = false;

            var list = await _teatarService.Get<List<DataTransferObjects.Teatar>>(null);

            foreach (var item in list)
            {
                Teatri.Add(item);
            }
        }
    }
}

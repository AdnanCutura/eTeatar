using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DataTransferObjects;
using DataTransferObjects.Requests;
using Xamarin.Forms;

namespace XamarinForms.ViewModels
{
    public class ObavijestDetaljiViewModel
    {
        private readonly APIService _serviceKomentar = new APIService("Komentar");

        public Obavijest Obavijest { get; set; }
        public Kupac Kupac { get; set; }
        public string Komentar { get; set; }

        public ObservableCollection<Komentar> Komentari { get; set; }

        public ObavijestDetaljiViewModel()
        {
            Kupac = Helpers.KupacData.Get();
            Komentari = new ObservableCollection<Komentar>();
            InitCommand = new Command(async () => await Init());
            
            NoviKomentarCommand = new Command(async () => await NoviKomentar());
        }

        public ICommand NoviKomentarCommand { get; set; }
        public ICommand InitCommand { get; set; }
        
        #region Metode za komande
        public async Task Init()
        {
            if (!Komentari.Any())
                await LoadKomentare();

            else
            {
                Komentari.Clear();
                await LoadKomentare();
            }
        }

        public async Task NoviKomentar()
        {
            var noviKomentar = new KomentarInsertRequest
            {
                DatumVrijeme = DateTime.Now,
                KupacId = Kupac.Id,
                Sadrzaj = Komentar,
                ObavijestId = Obavijest.Id
            };

            try
            {
                await _serviceKomentar.Insert<Komentar>(noviKomentar);
                InitCommand.Execute(null);
            }
            catch
            {
                // ignored
            }
        }
        #endregion

        private async Task LoadKomentare()
        {
            try
            {
                var list = await _serviceKomentar.Get<List<Komentar>>(Obavijest.Id);
                foreach (var item in list)
                    Komentari.Add(item);
            }
            catch
            {
                // ignored
            }
        }
    }
}

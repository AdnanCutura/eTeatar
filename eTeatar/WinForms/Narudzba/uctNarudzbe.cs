using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Narudzba
{
    public partial class uctNarudzbe : UserControl
    {
        private readonly APIService _narudzbaService;

        public uctNarudzbe()
        {
            InitializeComponent();
            _narudzbaService = new APIService("Narudzba");
        }

        private async void UctNarudzbe_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            await LoadData();
        }

        public async Task LoadData()
        {
            try
            {
                var search = new DataTransferObjects.Requests.NarudzbaSearchRequest
                {
                    Ime = txbIme.Text,
                    Prezime = txbPrezime.Text,
                    NazivPredstave = txbNazivPredstave.Text,
                    KorisnickoIme = txbKorisnickoIme.Text
                };

                var list = await _narudzbaService.Get<List<DataTransferObjects.Narudzba>>(search);

                dgvNarudzbe.AutoGenerateColumns = false;

                dgvNarudzbe.DataSource = list;

                for (int i = 0; i < dgvNarudzbe.RowCount; i++)
                {
                    dgvNarudzbe.Rows[i].Cells["Ime"].Value = list[i].Kupac.Ime;
                    dgvNarudzbe.Rows[i].Cells["Prezime"].Value = list[i].Kupac.Prezime;
                    dgvNarudzbe.Rows[i].Cells["KorisnickoIme"].Value = list[i].Kupac.KorisnickoIme;
                    dgvNarudzbe.Rows[i].Cells["Predstava"].Value = list[i].Termin.Predstava.Naziv;
                    dgvNarudzbe.Rows[i].Cells["Termin"].Value = list[i].Termin.DatumVrijeme;
                    dgvNarudzbe.Rows[i].Cells["Teatar"].Value = list[i].Termin.Dvorana.Teatar.Naziv;
                    dgvNarudzbe.Rows[i].Cells["Ocjena"].Value = list[i].Ocjena?.Vrijednost;
                }
            }
            catch{/*Exceptions handeled in API*/}
        }
   
    }
}

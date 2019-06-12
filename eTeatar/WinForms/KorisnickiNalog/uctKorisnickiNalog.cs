using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.KorisnickiNalog
{
    public partial class uctKorisnickiNalog : UserControl
    {
        private APIService _korisnickiNalogService;

        public  uctKorisnickiNalog()
        {
            InitializeComponent();
            _korisnickiNalogService = new APIService("KorisnickiNalog");
        }

        private async void UctKorisnickiNalog_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            var search = new DataTransferObjects.Requests.KorisnickiNalogSearchRequest
            {
                Ime = txbIme.Text,
                Prezime = txbPrezime.Text,
                KorisnickoIme = txbKorisnickoIme.Text
            };

            try { 
            var list = await _korisnickiNalogService.Get<List<DataTransferObjects.KorisnickiNalog>>(search);
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = list;
            for (int i = 0; i < list.Count(); i++)
                dgvKorisnici.Rows[i].Cells["Uloga"].Value = list[i].KorisnickaUloga.Naziv;
            }
            catch {
                dgvKorisnici.DataSource = null;
            }

        }

        private async void Search_Click(object sender, EventArgs e)
        {
            await LoadData();
        }

        private void BtnDodajAdmin_Click(object sender, EventArgs e)
        {
            PanelSwitcher.setToTop(new uctDodajAdmin());
        }
    }
}

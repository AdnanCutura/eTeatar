using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Glumac
{
    public partial class uctGlumac : UserControl
    {
        private readonly APIService _glumacService = new APIService("Glumac");
        
        public uctGlumac()
        {
            InitializeComponent();
        }

        private async void UctGlumac_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {

            var search = new DataTransferObjects.Requests.GlumacSearchRequest
            {
                Ime = txbIme.Text,
                Prezime = txbPrezime.Text
            };

            var list = await _glumacService.Get<List<DataTransferObjects.Glumac>>(search);

            dgvGlumac.AutoGenerateColumns = false;

            dgvGlumac.DataSource = list;

            for (int i = 0; i < list.Count(); i++)
                dgvGlumac.Rows[i].Cells["Spol"].Value = list[i].Spol.Naziv;

        }

        private void BtnDodajTeatar_Click(object sender, EventArgs e)
        {
            PanelSwitcher.setToTop(new uctDodajGlumac());
        }

        private async void DgvGlumac_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvGlumac.Rows[e.RowIndex].Cells["Id"].Value;
            if (dgvGlumac.Columns[e.ColumnIndex].Name == "Izbrisi")
            {
                if (MessageBox.Show("Jeste li sigurni", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await _glumacService.Delete<DataTransferObjects.Glumac>(id);
                    await LoadData();
                    return;
                }
            }
           
            PanelSwitcher.RemoveControl(this);
            PanelSwitcher.setToTop(new uctDodajGlumac(id.ToString()));
        }

        private async void Search_Click(object sender, EventArgs e)
        {
            await LoadData();
        }
    }
}

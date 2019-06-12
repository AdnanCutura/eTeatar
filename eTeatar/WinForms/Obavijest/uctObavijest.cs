using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObjects.Requests;
using WinForms.Helpers;

namespace WinForms.Obavijest
{
    public partial class uctObavijest : UserControl
    {
        private readonly APIService _obavijestService = new APIService("Obavijest");
        private readonly APIService _adminService = new APIService("Administrator");

        public uctObavijest()
        {
            InitializeComponent();
        }

        private async void UctObavijest_Load(object sender, EventArgs e)
        {
            await LoadObavijesti();
        }

        private async Task LoadObavijesti(DateTime? from = null, DateTime? to = null)
        {
            List<DataTransferObjects.Obavijest> list;

            if (from == null && to != null)
                list = await _obavijestService.Get<List<DataTransferObjects.Obavijest>>(new ObavijestSearchRequest
                {
                    DatumDo = to
                });


            if (from != null && to != null)
                list = await _obavijestService.Get<List<DataTransferObjects.Obavijest>>(new ObavijestSearchRequest
                {
                    DatumOd = from,
                    DatumDo = to
                });

            else
                list = await _obavijestService.Get<List<DataTransferObjects.Obavijest>>(null);


            dgvObavijest.AutoGenerateColumns = false;
            dgvObavijest.DataSource = list;

            for(int i = 0; i< dgvObavijest.Rows.Count; i++) { 
                dgvObavijest.Rows[i].Cells["AdministratorName"].Value = list[i].Administrator.Ime;
                dgvObavijest.Rows[i].Cells["AdministratorId"].Value = list[i].Administrator.Id;
            }

        }

        private void SrchDateFrom_ValueChanged(object sender, EventArgs e)
        {
            srchDateFrom.CustomFormat = "dd.MM.yyyy";
        }

        private void SrchDateFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                srchDateFrom.CustomFormat = " ";
        }

        private async void SearchIcon_Click(object sender, EventArgs e)
        {
            if (srchDateFrom.CustomFormat == " ")
                await LoadObavijesti(null, srchDateTo.Value);
            else
                await LoadObavijesti(srchDateFrom.Value, srchDateTo.Value);
        }

        private void BtnDodajObavijest_Click(object sender, EventArgs e)
        {
            PanelSwitcher.setToTop(new uctDodajObavijest());
        }

        private async void DgvObavijest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentAdministartorId = AdminData._admin.Id;
            var obavijestAdministratorId = dgvObavijest.Rows[e.RowIndex].Cells["AdministratorId"].Value;

            if (currentAdministartorId != obavijestAdministratorId.ToString())
            {
                MessageBox.Show("Ne možete brisati ni uređivati obavijesti koje nisu vaše autorske!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var id = dgvObavijest.Rows[e.RowIndex].Cells["Id"].Value;
            if (dgvObavijest.Columns[e.ColumnIndex].Name == "Izbrisi")
            {
                if (MessageBox.Show("Jeste li sigurni", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await _obavijestService.Delete<DataTransferObjects.Teatar>(id);
                    await LoadObavijesti();
                    return;
                }
            }

            PanelSwitcher.setToTop(new uctDodajObavijest(id.ToString()));
        }
    }
}

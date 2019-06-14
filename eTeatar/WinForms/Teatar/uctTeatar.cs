using DataTransferObjects;
using DataTransferObjects.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Teatar
{
    public partial class uctTeatar : UserControl
    {
        private readonly APIService _teatarService = new APIService("Teatar");
        private readonly APIService _gradService = new APIService("Grad");

        public uctTeatar()
        {
            InitializeComponent();
        }

        private async void UctTeatar_Load(object sender, EventArgs e)
        {
            await LoadTeatri();
            await LoadGradovi();
        }

        private async void DgvTeatar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvTeatar.Rows[e.RowIndex].Cells["Id"].Value;
            if (dgvTeatar.Columns[e.ColumnIndex].Name == "Izbrisi")
            {
                if (MessageBox.Show("Jeste li sigurni", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await _teatarService.Delete<DataTransferObjects.Teatar>(id);
                    await LoadTeatri();
                    return;
                }
            }

            PanelSwitcher.setToTop(new uctDodajTeatar(id.ToString()));
        }

        private void BtnDodajTeatar_Click(object sender, EventArgs e)
        {
            PanelSwitcher.setToTop(new uctDodajTeatar());
        }

        #region Učitavanje podataka

        private async Task LoadTeatri(string gradId = null)
        {
            var search = new TeatarSearchRequest
            {
                GradId = gradId
            };

            try
            {
                var list = await _teatarService.Get<List<DataTransferObjects.Teatar>>(search);

                dgvTeatar.AutoGenerateColumns = false;
                dgvTeatar.DataSource = list;

                for (int i = 0; i < list.Count(); i++)
                {
                    dgvTeatar.Rows[i].Cells["BrojDvorana"].Value = list[i].Dvorane.Count;
                }
            }
            catch
            {
                // ignored
            }
        }

        private async Task LoadGradovi()
        {
            List<Grad> result = new List<Grad>();
            result = await _gradService.Get<List<Grad>>(null);
            result.Insert(0, new Grad());

            srchGrad.DisplayMember = "Naziv";
            srchGrad.ValueMember = "Id";
            srchGrad.DataSource = result;
        }

        #endregion

        #region Pretraga
        private async void SrchGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadTeatri(srchGrad.SelectedValue?.ToString());
        } 
        #endregion
    }
}

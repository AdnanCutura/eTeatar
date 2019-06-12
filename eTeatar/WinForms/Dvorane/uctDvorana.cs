using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Dvorane
{
    public partial class uctDvorana : UserControl
    {
        private readonly APIService _dvoranaService;
        private readonly APIService _teatarService;
        public uctDvorana()
        {
            InitializeComponent();
            _dvoranaService = new APIService("Dvorana");
            _teatarService = new APIService("Teatar");
        }

        private async void UctDvorana_Load(object sender, EventArgs e)
        {
            await LoadTeatri();
            await LoadData();
        }

        private async void Search_Click(object sender, EventArgs e)
        {
            await LoadData();
        }

        public async Task LoadTeatri()
        {
            var list = await _teatarService.Get<List<DataTransferObjects.Teatar>>(null);

            foreach (var teatar in list)
                teatar.Naziv += $" ({teatar.Grad.Naziv})";

            list.Insert(0, new DataTransferObjects.Teatar());

            cmbTeatri.DisplayMember = "Naziv";
            cmbTeatri.ValueMember = "Id";
            cmbTeatri.DataSource = list;
        }

        public async Task LoadData()
        {
            var search = new DataTransferObjects.Requests.DvoranaSearchRequest
            {
                TeatarId = cmbTeatri.SelectedValue?.ToString(),
                Naziv = txbNaziv.Text
            };

            try
            {
                var list = await _dvoranaService.Get<List<DataTransferObjects.Dvorana>>(search);
                dgvDvorana.AutoGenerateColumns = false;
                dgvDvorana.DataSource = list;

                for (int i = 0; i < list.Count(); i++)
                    dgvDvorana.Rows[i].Cells["Teatar"].Value = list[i].Teatar.Naziv;
            }
            catch
            {
                dgvDvorana = null;
            }
        }

        private void BtnDodajDvoranu_Click(object sender, EventArgs e)
        {
            PanelSwitcher.setToTop(new uctDodajDvorana(null));
        }

        private async void DgvDvorana_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvDvorana.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value.ToString();
            if (dgvDvorana.Columns[e.ColumnIndex].Name == "Akcija")
            {
                if (MessageBox.Show("Jeste li sigurni", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await _dvoranaService.Delete<DataTransferObjects.Dvorana>(id);
                    await LoadData();
                    return;
                }
            }
            else
            {
                PanelSwitcher.setToTop(new uctDodajDvorana(id));
            }
        }
    }
}

using DataTransferObjects.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Predstava
{
    public partial class uctTerminiPredstave : UserControl
    {
        private readonly APIService _terminService = new APIService("Termin");
        private readonly APIService _dvoranaService = new APIService("Dvorana");
        private readonly APIService _predstavaService = new APIService("Predstava");
        private readonly string _predstavaId;

        public uctTerminiPredstave(string predstavaId)
        {
            _predstavaId = predstavaId;
            InitializeComponent();
        }

        private async void UctTerminiPredstave_Load(object sender, EventArgs e)
        {
            await LoadTermin();
            await LoadDvorana();

            this.cmbDvorana.SelectedIndexChanged += new System.EventHandler(this.CmbDvorana_SelectedIndexChanged);
            var predstava = await _predstavaService.GetById<DataTransferObjects.Predstava>(_predstavaId);
            lblHeading.Text += " \"" + predstava.Naziv + "\"";
        }

        #region Učitavanje podataka
        private async Task LoadTermin(string dvoranaId = null)
        {
            try
            {
                var search = new TerminSearchRequest
                {
                    PredstavaId = _predstavaId,
                    DvoranaId = dvoranaId
                };

                var list = await _terminService.Get<List<DataTransferObjects.Termin>>(search);

                dgvTermin.AutoGenerateColumns = false;
                dgvTermin.DataSource = list;

                for (int i = 0; i < dgvTermin.RowCount; i++)
                {
                    dgvTermin.Rows[i].Cells["DvoranaName"].Value = list[i].Dvorana.Naziv;
                    dgvTermin.Rows[i].Cells["PredstavaName"].Value = list[i].Predstava.Naziv;
                }
            }
            catch
            {
                // ignored
            }
        }

        private async Task LoadDvorana()
        {
            var list = await _dvoranaService.Get<List<DataTransferObjects.Dvorana>>(null);

            list.Insert(0, new DataTransferObjects.Dvorana());
            cmbDvorana.DisplayMember = "Naziv";
            cmbDvorana.ValueMember = "Id";
            cmbDvorana.DataSource = list;
        }
        #endregion

        #region Pretraga
        private async void CmbDvorana_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadTermin(cmbDvorana.SelectedValue?.ToString());
        }
        #endregion

        private void BtnDodajTermin_Click(object sender, EventArgs e)
        {
            PanelSwitcher.setToTop(new uctDodajTermin(_predstavaId));
        }

        private async void DgvTermin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var terminId = dgvTermin.Rows[e.RowIndex].Cells["Id"].Value?.ToString();
            var termin = await _terminService.GetById<DataTransferObjects.Termin>(terminId);

            if (termin.DatumVrijeme < DateTime.Now)
            {
                MessageBox.Show("Ne možete mjenjati termin koji je prošao!", "Greška", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                return;
            }

            if (dgvTermin.Columns[e.ColumnIndex].Name == "Izbrisi")
            {
                if (!termin.Narudzbe.Any())

                    if (MessageBox.Show("Jeste li sigurni", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        await _terminService.Delete<DataTransferObjects.Termin>(terminId);
                        await LoadTermin();
                        return;
                    }
                    else
                        MessageBox.Show("Ne možete brisati termin za kojeg postoje karte!", "Greška", MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);

            }

            PanelSwitcher.setToTop(new uctDodajTermin(_predstavaId, terminId));
        }

        private void LblBackPredstava_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PanelSwitcher.setToTop(new uctPredstava());
        }
    }
}
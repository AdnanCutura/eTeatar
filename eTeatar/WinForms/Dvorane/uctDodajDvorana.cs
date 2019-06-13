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
    public partial class uctDodajDvorana : UserControl
    {
        private readonly APIService _dvoranaService;
        private readonly APIService _teatarService;
        private readonly APIService _tipSjedistaService;
        private readonly APIService _dvoranaTipSjedistaService;
        public readonly DataValidation _validator;

        private readonly string _id;
        public uctDodajDvorana(string id)
        {
            InitializeComponent();
            _id = id;
            _dvoranaService = new APIService("Dvorana");
            _teatarService = new APIService("Teatar");
            _tipSjedistaService = new APIService("TipSjedista");
            _dvoranaTipSjedistaService = new APIService("DvoranaTipSjedista");
            _validator = Factory.GetValidator(errorProvider1);
        }

        private async void UctDodajDvorana_Load(object sender, EventArgs e)
        {
            await LoadTeatri();
            await LoadTipoviSjedista();
            await LoadData();
        }

        private async Task LoadData()
        {
            if (string.IsNullOrEmpty(_id))
                return;

            var item = await _dvoranaService.GetById<DataTransferObjects.Dvorana>(_id);

            txbNaziv.Text = item.Naziv;
            cmbTeatar.SelectedValue = item.Teatar.Id;

            foreach (DataGridViewRow row in dgvTipSjedista.Rows)
            {
                row.Cells["brojSjedista"].Value = item.TipoviSjedista.Where(w => w.TipSjedistaId == row.Cells["idDataGridViewTextBoxColumn"].Value.ToString()).FirstOrDefault()?.BrojSjedista;
            }
        }

        private async Task LoadTeatri()
        {
            var list = await _teatarService.Get<List<DataTransferObjects.Teatar>>(null);

            foreach (var item in list)
                item.Naziv += $" ({item.Grad.Naziv})";

            list.Insert(0, new DataTransferObjects.Teatar());

            cmbTeatar.ValueMember = "Id";
            cmbTeatar.DisplayMember = "Naziv";
            cmbTeatar.DataSource = list;
        }

        private async Task LoadTipoviSjedista()
        {
            var list = await _tipSjedistaService.Get<List<DataTransferObjects.TipSjedista>>(null);

            dgvTipSjedista.DataSource = list;
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            var request = new DataTransferObjects.Requests.DvoranaUpsertRequest
            {
                Naziv = txbNaziv.Text,
                TeatarId = cmbTeatar.SelectedValue.ToString()
            };

            DataTransferObjects.Dvorana response;

            if (!string.IsNullOrEmpty(_id))
                response = await _dvoranaService.Update<DataTransferObjects.Dvorana>(_id, request);
            else
                response = await _dvoranaService.Insert<DataTransferObjects.Dvorana>(request);

            foreach(DataGridViewRow row in dgvTipSjedista.Rows)
            {
                bool updated = false;

                int brojSjedista = 0;
                string id = row.Cells["idDataGridViewTextBoxColumn"].Value.ToString();

                if (row.Cells["BrojSjedista"].Value != null)
                    Int32.TryParse(row.Cells["BrojSjedista"].Value.ToString(),out brojSjedista);

                foreach (var tipsjedista in response.TipoviSjedista)
                {
                    if (tipsjedista.TipSjedistaId == row.Cells["idDataGridViewTextBoxColumn"].Value.ToString() && brojSjedista!=0)
                        await _dvoranaTipSjedistaService.Update<DataTransferObjects.DvoranaTipSjedista>(tipsjedista.Id, new DataTransferObjects.Requests.DvoranaTipSjedistaUpsertRequest { BrojSjedista = brojSjedista, DvoranaId = response.Id, TipSjedistaId = id });
                    updated = true;
                }

                if (!updated && brojSjedista !=0)
                    await _dvoranaTipSjedistaService.Insert<DataTransferObjects.DvoranaTipSjedista>(new DataTransferObjects.Requests.DvoranaTipSjedistaUpsertRequest {BrojSjedista = brojSjedista, DvoranaId = response.Id, TipSjedistaId = id});
            }

            if (response != null)
            {
                MessageBox.Show("Uspješno izvršeno");
                PanelSwitcher.RemoveControl(this);
                PanelSwitcher.setToTop(new uctDvorana());
            }
        }

        private void TxbNaziv_Validating(object sender, CancelEventArgs e)
        {
            _validator.NullCheckTxb(txbNaziv, e);
        }

        private void CmbTeatar_Validating(object sender, CancelEventArgs e)
        {
            _validator.NullCheckCmb(cmbTeatar, e);
        }
    }
}

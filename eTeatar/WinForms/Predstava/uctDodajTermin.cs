using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObjects.Requests;

namespace WinForms.Predstava
{
    public partial class uctDodajTermin : UserControl
    {
        private readonly APIService _terminService = new APIService("Termin");
        private readonly APIService _dvoranaService = new APIService("Dvorana");
        private readonly APIService _predstavaService = new APIService("Predstava");
        private readonly DataValidation _dataValidation;
        private readonly string _predstavaId;
        private readonly string _terminId;

        public uctDodajTermin(string predstavaId, string terminId = null)
        {
            _predstavaId = predstavaId;
            _terminId = terminId;
            InitializeComponent();
            _dataValidation = Factory.GetValidator(errorProvider); ;
        }

        private async void UctDodajTermin_Load(object sender, EventArgs e)
        {
            await LoadDvorana();
            var predstava = await _predstavaService.GetById<DataTransferObjects.Predstava>(_predstavaId);

            if (_terminId != null)
            {
                var entity = await _terminService.GetById<DataTransferObjects.Termin>(_terminId);
                dtpTermin.Value = entity.DatumVrijeme;
                mtxbBaznaCijenaKarte.Text = entity.BaznaCijenaKarte.ToString(CultureInfo.InvariantCulture);
                cmbDvorana.SelectedValue = entity.Dvorana.Id;
                lblHeading.Text = "Uređivanje termina za \"" + predstava.Naziv + "\"";
            }
            else
                lblHeading.Text = "Dodavanje termina za \"" + predstava.Naziv + "\"";
        }

        private async Task LoadDvorana()
        {
            var list = await _dvoranaService.Get<List<DataTransferObjects.Dvorana>>(null);

            list.Insert(0, new DataTransferObjects.Dvorana());
            cmbDvorana.DisplayMember = "Naziv";
            cmbDvorana.ValueMember = "Id";
            cmbDvorana.DataSource = list;
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                string cijena = mtxbBaznaCijenaKarte.Text.Substring(0, mtxbBaznaCijenaKarte.Text.Length - 3);
                var request = new TerminUpsertRequest
                {
                    DvoranaId = cmbDvorana.SelectedValue.ToString(),
                    PredstavaId = _predstavaId,
                    BaznaCijenaKarte = double.Parse(cijena),
                    DatumVrijeme = dtpTermin.Value
                };
                DataTransferObjects.Termin response;
                if (_terminId == null)
                    response = await _terminService.Insert<DataTransferObjects.Termin>(request);

                else
                    response = await _terminService.Update<DataTransferObjects.Termin>(_terminId, request);

                if (response != null)
                {
                    MessageBox.Show($"Uspješno izvršeno");
                    PanelSwitcher.setToTop(new uctTerminiPredstave(_predstavaId));
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PanelSwitcher.setToTop(new uctTerminiPredstave(_predstavaId));
            PanelSwitcher.RemoveControl(this);
        }

        private void CmbDvorana_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(cmbDvorana, e);
        }

        private void MtxbBaznaCijenaKarte_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(mtxbBaznaCijenaKarte, e);
        }

        private void DtpTermin_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(dtpTermin, e);
        }
    }
}

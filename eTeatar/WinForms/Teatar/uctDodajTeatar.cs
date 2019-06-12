using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObjects;
using DataTransferObjects.Requests;

namespace WinForms.Teatar
{
    public partial class uctDodajTeatar : UserControl
    {
        private readonly APIService _teatarService = new APIService("Teatar");
        private readonly APIService _drzavaService = new APIService("Drzava");
        private readonly APIService _gradService = new APIService("Grad");
        private readonly DataValidation _dataValidation;

        private readonly string _teatarId;
        public uctDodajTeatar(string teatarId = null)
        {
            _teatarId = teatarId;
            InitializeComponent();
            _dataValidation = Factory.GetValidator(errorProvider);
        }

        private async void UctDodajTeatar_Load(object sender, EventArgs e)
        {
            //Učitavanje podataka za combobox-ove
            await LoadDrzave();
            await LoadGradovi(null);

            if (!string.IsNullOrEmpty(_teatarId))
            {
                var entity = await _teatarService.GetById<DataTransferObjects.Teatar>(_teatarId);
           
                lblHeading.Text = "Izmjena podataka za teatar";
                txbBrojTelefona.Text = entity.BrojTelefona;
                txbAdresa.Text = entity.Adresa;
                txbEmail.Text = entity.Email;
                txbNaziv.Text = entity.Naziv;
                txbVrijemeOtvaranja.Text = entity.VrijemeOtvaranja.ToShortTimeString();
                txbVrijemeZatvaranja.Text = entity.VrijemeZatvaranja.ToShortTimeString();
                cmbDrzava.SelectedValue = entity.Grad.Drzava.Id;
                cmbGrad.SelectedValue = entity.Grad.Id;
            }
            else
                lblHeading.Text = "Dodavanje teatra";
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                object gradId = cmbGrad.SelectedValue;

                TeatarUpsertRequest request = new TeatarUpsertRequest
                {
                    GradId = gradId.ToString(),
                    Adresa = txbAdresa.Text,
                    BrojTelefona = txbBrojTelefona.Text,
                    Naziv = txbNaziv.Text,
                    Email = txbEmail.Text,
                    VrijemeOtvaranja = Convert.ToDateTime(txbVrijemeOtvaranja.Text),
                    VrijemeZatvaranja = Convert.ToDateTime(txbVrijemeZatvaranja.Text)
                };

                DataTransferObjects.Teatar entity;

                if (string.IsNullOrEmpty(_teatarId))
                    entity = await _teatarService.Insert<DataTransferObjects.Teatar>(request);
                else
                    entity = await _teatarService.Update<DataTransferObjects.Teatar>(_teatarId, request);

                if (entity != null)
                    MessageBox.Show("Uspješno izvršeno");

                PanelSwitcher.RemoveControl(this);
            }

            //pokreni user control lista teatara
        }

        #region Učitavanje podataka za comboBox-ove

        private async Task LoadDrzave()
        {
            List<Drzava> result = await _drzavaService.Get<List<Drzava>>(null);
            result.Insert(0, new Drzava());

            cmbDrzava.DisplayMember = "Naziv";
            cmbDrzava.ValueMember = "Id";
            cmbDrzava.DataSource = result;
        }

        private async Task LoadGradovi(string drzavaId)
        {
            List<Grad> result = new List<Grad>();

            if (!string.IsNullOrEmpty(drzavaId))
                result = await _gradService.Get<List<Grad>>(new GradSearchRequest
                {
                    DrzavaId = drzavaId
                });
            else
                result = await _gradService.Get<List<Grad>>(null);

            result.Insert(0, new Grad());

            cmbGrad.DisplayMember = "Naziv";
            cmbGrad.ValueMember = "Id";
            cmbGrad.DataSource = result;
        }

        #endregion

        #region Učitavanje podataka na promjenu stanja
        private async void CmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            object drzavaId = cmbDrzava.SelectedValue;
            await LoadGradovi(drzavaId?.ToString());
        }

        private async void CmbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            object gradId = cmbGrad.SelectedValue;

            if (!string.IsNullOrEmpty(gradId?.ToString()))
            {
                Grad grad = await _gradService.GetById<Grad>(gradId?.ToString());

                var drzavaId = grad.Drzava.Id;

                cmbDrzava.SelectedValue = drzavaId;
                cmbGrad.SelectedValue = gradId;
            }
        }

        #endregion

        #region Validacija

        private void TxbNaziv_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(txbNaziv, e);
        }

        private void TxbAdresa_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(txbAdresa, e);
        }

        private void TxbBrojTelefona_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(txbBrojTelefona, e);
        }

        private void CmbDrzava_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(cmbDrzava, e);
        }

        private void CmbGrad_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheckCmb(cmbGrad, e);
        }

        private void TxbEmail_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(txbEmail, e);
            _dataValidation.EmailRegexCheck(txbEmail, e);
        }

        private void TxbVrijemeOtvaranja_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(txbVrijemeOtvaranja, e);
            _dataValidation.TimeRegexCheck(txbVrijemeOtvaranja, e);
        }

        private void TxbVrijemeZatvaranja_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheckMaskBox(txbVrijemeZatvaranja, e);
            _dataValidation.TimeRegexCheck(txbVrijemeZatvaranja, e);
        }

        #endregion


    }
}

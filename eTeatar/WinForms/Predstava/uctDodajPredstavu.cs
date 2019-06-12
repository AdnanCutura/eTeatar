using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObjects.Requests;
using WinForms.Helpers;

namespace WinForms.Predstava
{
    public partial class uctDodajPredstavu : UserControl
    {
        private readonly APIService _predstavaService = new APIService("Predstava");
        private readonly APIService _teatarService = new APIService("Teatar");
        private readonly PredstavaUpsertRequest _request;
        private readonly DataValidation _dataValidation;
        private readonly string _predstavaId;

        public uctDodajPredstavu(string predstavaId = null)
        {
            _predstavaId = predstavaId;
            InitializeComponent();
            _dataValidation = Factory.GetValidator(errorProvider); ;
            _request = new PredstavaUpsertRequest();
        }

        private async void UctDodajPredstavu_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(_predstavaId))
            {
                var entity = await _predstavaService.GetById<DataTransferObjects.Predstava>(_predstavaId);
                lblHeading.Text = "Izmjena podataka za predstavu";
                txbNaziv.Text = entity.Naziv;
                txbNazivIzvornogDjela.Text = entity.NazivIzvornogDjela;
                txbPisacIzvornogDjela.Text = entity.PisacIzvornogDjela;
                txbReziser.Text = entity.ReziserImePrezime;
                txbTrajanje.Text = entity.Trajanje;



            }
            else
                lblHeading.Text = "Dodavanje teatra";
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                _request.Naziv = txbNaziv.Text;
                _request.NazivIzvornogDjela = txbNazivIzvornogDjela.Text;
                _request.PisacIzvornogDjela = txbPisacIzvornogDjela.Text;
                _request.ReziserImePrezime = txbReziser.Text;
                _request.Opis = rtxbOpis.Text;
                _request.Trajanje = txbTrajanje.Text;

                if (_request.Slika == null)
                    _request.Slika = Converters.SystemDrawingToByteArray(imgPredstava.Image);

                DataTransferObjects.Predstava entity;
                if (!string.IsNullOrEmpty(_predstavaId))
                    entity = await _predstavaService.Update<DataTransferObjects.Predstava>(_predstavaId, _request);
                else
                    entity = await _predstavaService.Insert<DataTransferObjects.Predstava>(_request);

                if (entity != null)
                {
                    MessageBox.Show("Uspješno izvršeno");
                    PanelSwitcher.RemoveControl(this);
                    PanelSwitcher.setToTop(new uctPredstava());
                }
            }
        }

        #region Validacija

        private void BtnDodajSliku_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            byte[] slika = File.ReadAllBytes(openFileDialog.FileName);

            _request.Slika = slika;
            imgPredstava.Image = Converters.ByteArrayToSystemDrawing(slika);
        }

        private void TxbNaziv_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(txbNaziv, e);
        }

        private void TxbTrajanje_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(txbTrajanje, e);
        }

        private void TxbReziser_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(txbReziser, e);
        }

        private void TxbPisacIzvornogDjela_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(txbPisacIzvornogDjela, e);
        }

        private void TxbNazivIzvornogDjela_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(txbNazivIzvornogDjela, e);
        }

        private void RtxbOpis_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(rtxbOpis, e);
        }

        #endregion
    }
}

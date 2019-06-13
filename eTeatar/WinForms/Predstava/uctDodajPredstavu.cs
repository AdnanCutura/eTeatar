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
        private readonly APIService _zanrService = new APIService("Zanr");
        private readonly APIService _glumacService = new APIService("Glumac");
        private readonly APIService _predstavaZanrService = new APIService("PredstavaZanr");
        private readonly APIService _ulogaService = new APIService("Uloga");

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
            await LoadZanr();
            await LoadGlumac();

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

                //Unos zanrova za predstavu
                foreach (DataGridViewRow row in dgvZanr.Rows)
                {
                    var zanrId = row.Cells["Id"].Value.ToString();

                    var isOdabran = (bool?)row.Cells["Odabir"].Value;

                    if (isOdabran.HasValue && isOdabran.Value)
                    {
                        await _predstavaZanrService.Insert<DataTransferObjects.Requests.PredstavaZanrUpsertRequest>(
                            new PredstavaZanrUpsertRequest
                            {
                                ZanrId = zanrId,
                                PredstavaId = entity.Id
                            });
                    }
                }

                //Unos glumaca za predstavu
                foreach (DataGridViewRow row in dgvGlumac.Rows)
                {
                    var glumacId = row.Cells["Glumac"].Value?.ToString();
                    var uloga = row.Cells["NazivUloge"].Value?.ToString();

                    if (glumacId != null && uloga != null)
                        await _ulogaService.Insert<DataTransferObjects.Requests.UlogaUpsertRequest>(
                            new UlogaUpsertRequest
                            {
                                Naziv = uloga,
                                PredstavaId = entity.Id,
                                GlumacId = glumacId
                            });
                }


                if (entity != null)
                {
                    MessageBox.Show("Uspješno izvršeno");
                    PanelSwitcher.RemoveControl(this);
                    PanelSwitcher.setToTop(new uctPredstava());
                }
            }
        }

        private void BtnDodajSliku_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            byte[] slika = File.ReadAllBytes(openFileDialog.FileName);

            _request.Slika = slika;
            imgPredstava.Image = Converters.ByteArrayToSystemDrawing(slika);
        }

        #region Učitavanje podataka
        private async Task LoadZanr()
        {
            var list = await _zanrService.Get<List<DataTransferObjects.Zanr>>(null);

            dgvZanr.AutoGenerateColumns = false;
            dgvZanr.DataSource = list;
        }

        private async Task LoadGlumac()
        {
            var list = await _glumacService.Get<List<DataTransferObjects.Glumac>>(null);

            DataGridViewComboBoxColumn colGlumac = (DataGridViewComboBoxColumn)dgvGlumac.Columns["Glumac"];
            colGlumac.DataSource = await _glumacService.Get<List<DataTransferObjects.Glumac>>(null);
        }
        #endregion

        #region Validacija

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

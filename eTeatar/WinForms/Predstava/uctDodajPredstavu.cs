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
using System.Xml;
using DataTransferObjects.Requests;
using WinForms.Helpers;

namespace WinForms.Predstava
{
    public partial class uctDodajPredstavu : UserControl
    {
        private readonly APIService _predstavaService = new APIService("Predstava");
        private readonly APIService _zanrService = new APIService("Zanr");
        private readonly APIService _predstavaZanrService = new APIService("PredstavaZanr");
        private readonly APIService _ulogaService = new APIService("Uloga");

        private readonly PredstavaUpsertRequest _request;
        private readonly DataValidation _dataValidation;
        private readonly string _predstavaId;
        private List<DataTransferObjects.Uloga> _uloge;
        private List<string> _zanrovi;

        public uctDodajPredstavu(string predstavaId = null)
        {
            _predstavaId = predstavaId;
            InitializeComponent();
            _dataValidation = Factory.GetValidator(errorProvider); ;
            _request = new PredstavaUpsertRequest();
            _uloge = new List<DataTransferObjects.Uloga>();
            _zanrovi = new List<string>();
        }

        private async void UctDodajPredstavu_Load(object sender, EventArgs e)
        {
            await LoadZanr();

            if (!string.IsNullOrEmpty(_predstavaId))
            {
                var entity = await _predstavaService.GetById<DataTransferObjects.Predstava>(_predstavaId);
                lblHeading.Text = "Izmjena podataka za predstavu";
                txbNaziv.Text = entity.Naziv;
                txbNazivIzvornogDjela.Text = entity.NazivIzvornogDjela;
                txbPisacIzvornogDjela.Text = entity.PisacIzvornogDjela;
                txbReziser.Text = entity.ReziserImePrezime;
                txbTrajanje.Text = entity.Trajanje;
                rtxbOpis.Text = entity.Opis;

                if(entity.Slika.Length!=0)
                    imgPredstava.Image = Converters.ByteArrayToSystemDrawing(entity.Slika);

                _zanrovi = entity.Zanrovi.Select(s => s.Id).ToList();
                //Cekiranje zanrova
                for (int i = 0; i < clbZanrovi.Items.Count; i++)
                    if (_zanrovi.Contains(((DataTransferObjects.Zanr)clbZanrovi.Items[i]).Id))
                        clbZanrovi.SetItemChecked(i, true);

                //Dodavanje uloga
                _uloge = entity.Uloge;
                LoadUloge();

            }
            else
                lblHeading.Text = "Dodavanje teatra";

        }

        public void LoadUloge()
        {
            dgvUloge.DataSource = typeof(List<DataTransferObjects.Uloga>);
            dgvUloge.DataSource = _uloge;
            for (int i = 0; i < dgvUloge.RowCount; i++)
                dgvUloge.Rows[i].Cells["Glumac"].Value = $"{_uloge[i].Glumac.Ime} {_uloge[i].Glumac.Prezime}";
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

                DataTransferObjects.Predstava response;
                if (!string.IsNullOrEmpty(_predstavaId))
                    response = await _predstavaService.Update<DataTransferObjects.Predstava>(_predstavaId, _request);
                else
                    response = await _predstavaService.Insert<DataTransferObjects.Predstava>(_request);

                if (response != null)
                {
                    //Insert update uloga
                    foreach(var uloga in _uloge)
                        if (string.IsNullOrEmpty(uloga.Id))
                            await _ulogaService.Insert<DataTransferObjects.Uloga>(new DataTransferObjects.Requests.UlogaUpsertRequest { GlumacId = uloga.Glumac.Id, IsGlavnaUloga = uloga.IsGlavnaUloga, Naziv = uloga.Naziv, PredstavaId = response.Id });
                        else
                            await _ulogaService.Update<DataTransferObjects.Uloga>(uloga.Id, new DataTransferObjects.Requests.UlogaUpsertRequest { GlumacId = uloga.Glumac.Id, IsGlavnaUloga = uloga.IsGlavnaUloga, Naziv = uloga.Naziv, PredstavaId = response.Id });


                    var zanrovi = new List<string>();
                    //Insert zanrovi
                    foreach (DataTransferObjects.Zanr zanr in clbZanrovi.CheckedItems)
                    {
                        //Usput kupim id selektovanih zanrova
                        zanrovi.Add(zanr.Id);
                        if (!_zanrovi.Contains(zanr.Id))
                            await _predstavaZanrService.Insert<DataTransferObjects.PredstavaZanr>(new PredstavaZanrUpsertRequest { PredstavaId = response.Id, ZanrId = zanr.Id });
                    }

                    //Delete zanrovi
                    foreach (var item in _zanrovi)
                        if (!zanrovi.Contains(item))
                        {
                            var PZ = await _predstavaZanrService.Get<List<DataTransferObjects.PredstavaZanr>>(new PredstavaZanrSearchRequest { PredstavaId = response.Id, ZanrId = item });
                            await _predstavaZanrService.Delete<dynamic>(PZ.First().Id);
                        }

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
            clbZanrovi.DataSource = list;
            clbZanrovi.DisplayMember = "Naziv";
            clbZanrovi.ValueMember = "Id";
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

        private void RtxbOpis_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(rtxbOpis, e);
        }

        #endregion

        private void BtnDodajUlogu_Click(object sender, EventArgs e)
        {
            frmDodajUloga frm = new frmDodajUloga(ref _uloge);
            frm.Show();
            frm.FormClosed += new FormClosedEventHandler(Form_Closed);
        }

        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            LoadUloge();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PanelSwitcher.setToTop(new uctPredstava());
            PanelSwitcher.RemoveControl(this);
        }
    }
}

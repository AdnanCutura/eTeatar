using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObjects.Requests;
using WinForms.Helpers;

namespace WinForms.Obavijest
{
    public partial class uctDodajObavijest : UserControl
    {
        private readonly APIService _obavijestService = new APIService("Obavijest");
        private readonly DataValidation _dataValidation;
        private readonly ObavijestUpsertRequest _request;
        private readonly string _obavijestId;

        public uctDodajObavijest(string obavijestId = null)
        {
            _obavijestId = obavijestId;
            InitializeComponent();
            _dataValidation = Factory.GetValidator(errorProvider);
            _request = new ObavijestUpsertRequest();
        }

        private async void UctDodajObavijest_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_obavijestId))
            {
                var entity = await _obavijestService.GetById<DataTransferObjects.Obavijest>(_obavijestId);

                lblHeading.Text = "Izmjena podataka za obavijest";
                txbNaziv.Text = entity.Naslov;
                rtxbSadrzaj.Text = entity.Sadrzaj;
                if (entity.Slika.Length != 0)
                    imgSlika.Image = Converters.ByteArrayToSystemDrawing(entity.Slika);

            }
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                _request.DatumVrijeme = DateTime.Now;
                _request.Naslov = txbNaziv.Text;
                _request.Sadrzaj = rtxbSadrzaj.Text;
                _request.AdministratorId = AdminData.Get().Id;

                if (_request.Slika == null)
                    _request.Slika = Converters.SystemDrawingToByteArray(imgSlika.Image);

                DataTransferObjects.Obavijest entity;
                if (!string.IsNullOrEmpty(_obavijestId))
                    entity = await _obavijestService.Update<DataTransferObjects.Obavijest>(_obavijestId, _request);
                else
                    entity = await _obavijestService.Insert<DataTransferObjects.Obavijest>(_request);

                if (entity != null)
                {
                    MessageBox.Show("Uspješno izvršeno");
                    PanelSwitcher.RemoveControl(this);
                    PanelSwitcher.setToTop(new uctObavijest());
                }
            }
        }

        private void BtnDodajSliku_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            byte[] slika = File.ReadAllBytes(openFileDialog.FileName);

            _request.Slika = slika;
            imgSlika.Image = Converters.ByteArrayToSystemDrawing(slika);
        }

        #region Validacija
        private void TxbNaziv_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(txbNaziv, e);
        }

        private void RtxbSadrzaj_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(rtxbSadrzaj, e);
        }
        #endregion

        private void Button1_Click(object sender, EventArgs e)
        {
            PanelSwitcher.setToTop(new uctObavijest());
            PanelSwitcher.RemoveControl(this);
        }
    }
}

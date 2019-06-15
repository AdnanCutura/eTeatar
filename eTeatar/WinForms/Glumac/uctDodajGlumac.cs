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
using System.IO;
using WinForms.Helpers;

namespace WinForms.Glumac
{
    public partial class uctDodajGlumac : UserControl
    {
        private readonly APIService _glumacService = new APIService("Glumac");
        private readonly APIService _spolService = new APIService("Spol");
        private readonly DataValidation _dataValidation;
        private readonly DataTransferObjects.Requests.GlumacUpsertRequest request;

        private readonly string _id;

        public uctDodajGlumac(string id = null)
        {
            InitializeComponent();
            _dataValidation = Factory.GetValidator(errorProvider);
            request = new GlumacUpsertRequest();
            _id = id;
        }

        private async void UctDodajGlumac_Load(object sender, EventArgs e)
        {
            await LoadSpolovi();

            if (!string.IsNullOrEmpty(_id))
            {
                var glumac = await _glumacService.GetById<DataTransferObjects.Glumac>(_id);
                txbBiografija.Text = glumac.Biografija;
                txbIme.Text = glumac.Ime;
                txbPrezime.Text = glumac.Prezime;
                cmbSpol.SelectedValue = glumac.Spol.Id;

                if (glumac.Slika.Length!=0)
                    pictureBox1.Image = Converters.ByteArrayToSystemDrawing(glumac.Slika);
            }
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                request.Biografija = txbBiografija.Text;
                request.Ime = txbIme.Text;
                request.Prezime = txbPrezime.Text;
                request.SpolId = cmbSpol.SelectedValue.ToString();

                if (request.Slika == null)
                    request.Slika = Converters.SystemDrawingToByteArray(pictureBox1.Image);

                DataTransferObjects.Glumac entity;

                if (!string.IsNullOrEmpty(_id))
                    entity = await _glumacService.Update<DataTransferObjects.Glumac>(_id, request);
                else
                    entity = await _glumacService.Insert<DataTransferObjects.Glumac>(request);

                if (entity != null)
                {
                    MessageBox.Show("Uspješno izvršeno");
                    PanelSwitcher.RemoveControl(this);
                    PanelSwitcher.setToTop(new uctGlumac());
                }
            }
        }

        private async Task LoadSpolovi()
        {
            List<Spol> result = await _spolService.Get<List<Spol>>(null);
            result.Insert(0, new Spol());

            cmbSpol.DisplayMember = "Naziv";
            cmbSpol.ValueMember = "Id";
            cmbSpol.DataSource = result;
        }

        private void BtnDodajSliku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            byte[] v = File.ReadAllBytes(openFileDialog1.FileName);
            request.Slika = v;
            pictureBox1.Image = Converters.ByteArrayToSystemDrawing(File.ReadAllBytes(openFileDialog1.FileName));
        }

        private void TxbIme_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(txbIme, e);
        }

        private void CmbSpol_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(cmbSpol, e);
        }

        private void TxbPrezime_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(txbPrezime, e);
        }

        private void TxbBiografija_Validating(object sender, CancelEventArgs e)
        {
            _dataValidation.NullCheck(txbBiografija, e);
        }

        //TODO: Slika validation
    }
}

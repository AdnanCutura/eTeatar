using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using WinForms.Helpers;

namespace WinForms.KorisnickiNalog
{
    public partial class uctDodajAdmin : UserControl
    {
        private DataTransferObjects.Requests.AdministratorKorisnickiNalogUpsertRequest _request;
        private readonly DataValidation _validator;
        private readonly APIService _korisnickiNalogService;

        public uctDodajAdmin()
        {
            InitializeComponent();
            _request = new DataTransferObjects.Requests.AdministratorKorisnickiNalogUpsertRequest();
            _validator = Factory.GetValidator(errorProvider1);
            _korisnickiNalogService = new APIService("Administrator");
        }

        private void UctPostavke_Load(object sender, EventArgs e)
        {}

        private void BtnDodajSliku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            byte[] file = File.ReadAllBytes(openFileDialog1.FileName);
            _request.Slika = file;
            imgAvatar.Image = Converters.ByteArrayToSystemDrawing(file);
        }

        private void TxbIme_Validating(object sender, CancelEventArgs e)
        {
            _validator.NullCheck(txbIme, e);
        }

        private void TxbPrezime_Validating(object sender, CancelEventArgs e)
        {
            _validator.NullCheck(txbPrezime, e);
        }

        private void TxbNovaSifra_Validating(object sender, CancelEventArgs e)
        {
            _validator.NullCheck(txbSifra, e);
        }

        private void TxbNovaSifraPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbSifra.Text))
                return;

            _validator.NullCheck(txbSifraPotvrda, e);

            if (txbSifraPotvrda.Text != txbSifra.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txbSifraPotvrda, "Pasvordi se ne slazu");
            }
        }

        private void TxbBrojTelefona_Validating(object sender, CancelEventArgs e)
        {
            _validator.NullCheck(txbBrojTelefona, e);
        }

        private void TxbEmail_Validating(object sender, CancelEventArgs e)
        {
            _validator.NullCheck(txbEmail, e);
        }

        private void TxbKorisnickoIme_Validating_1(object sender, CancelEventArgs e)
        {
            _validator.NullCheck(txbKorisnickoIme, e);

        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            _request.Telefon = txbBrojTelefona.Text;
            _request.Email = txbEmail.Text;
            _request.Ime = txbIme.Text;
            _request.Prezime = txbPrezime.Text;
            _request.Password = txbSifra.Text;
            _request.PasswordPotvrda = txbSifraPotvrda.Text;
            _request.KorisnickoIme = txbKorisnickoIme.Text;

            if (_request.Slika == null)
                _request.Slika = Converters.SystemDrawingToByteArray(imgAvatar.Image);

            var entity = await _korisnickiNalogService.Insert<DataTransferObjects.Administrator>(_request);

            if (entity != null)
            {
                MessageBox.Show("Uspješno izvršeno");
                PanelSwitcher.RemoveControl(this);
                PanelSwitcher.setToTop(new uctKorisnickiNalog());
            }
        }

    }
}

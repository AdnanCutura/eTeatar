using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using WinForms.Helpers;

namespace WinForms.KorisnickiNalog
{
    public partial class uctPostavke : UserControl
    {
        private DataTransferObjects.Administrator _admin;
        private DataTransferObjects.Requests.AdministratorKorisnickiNalogUpsertRequest _request;
        private readonly DataValidation _validator;
        private readonly APIService _korisnickiNalogService;

        public uctPostavke()
        {
            InitializeComponent();
            _admin = AdminData.Get();
            _request = new DataTransferObjects.Requests.AdministratorKorisnickiNalogUpsertRequest();
            _validator = Factory.GetValidator(errorProvider1);
            _korisnickiNalogService = new APIService("Administrator");
        }

        private void UctPostavke_Load(object sender, EventArgs e)
        {
            txbBrojTelefona.Text = _admin.Telefon;
            txbEmail.Text = _admin.Email;
            txbIme.Text = _admin.Ime;
            txbPrezime.Text = _admin.Prezime;
            if (_admin.Slika.Length != 0)
            {
                imgAvatar.Image = Converters.ByteArrayToSystemDrawing(_admin.Slika);
            }
        }

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
            _validator.NullCheckTxb(txbIme, e);
        }

        private void TxbPrezime_Validating(object sender, CancelEventArgs e)
        {
            _validator.NullCheckTxb(txbPrezime, e);
        }

        private void TxbNovaSifra_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TxbNovaSifraPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbNovaSifra.Text))
            {
                return;
            }

            _validator.NullCheckTxb(txbNovaSifraPotvrda, e);
            if (txbNovaSifraPotvrda.Text != txbNovaSifra.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txbNovaSifraPotvrda, "Pasvordi se ne slazu");
            }

        }

        private void TxbBrojTelefona_Validating(object sender, CancelEventArgs e)
        {
            _validator.NullCheckTxb(txbBrojTelefona, e);
        }

        private void TxbEmail_Validating(object sender, CancelEventArgs e)
        {
            _validator.NullCheckTxb(txbEmail, e);
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            _request.Telefon = txbBrojTelefona.Text;
            _request.Email = txbEmail.Text;
            _request.Ime = txbIme.Text;
            _request.Prezime = txbPrezime.Text;
            _request.Password = txbNovaSifra.Text;
            _request.PasswordPotvrda = txbNovaSifraPotvrda.Text;

            if (_request.Slika == null)
                _request.Slika = Converters.SystemDrawingToByteArray(imgAvatar.Image);


            var entity = await _korisnickiNalogService.Update<DataTransferObjects.Administrator>(_admin.Id,_request);

            if (entity != null)
                MessageBox.Show("Uspješno izvršeno");

            _admin.Telefon = txbBrojTelefona.Text;
            _admin.Email = txbEmail.Text;
            _admin.Ime = txbIme.Text;
            _admin.Prezime = txbPrezime.Text;
            if (_request.Slika?.Length>0)
                _admin.Slika = _request.Slika;

            AdminData.Set(_admin);
        }
    }
}

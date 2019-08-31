using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Predstava
{
    public partial class frmDodajUloga : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private readonly APIService _glumacSerive;
        private List<GlumacUloga> _glumci;
        private List<DataTransferObjects.Uloga> _uloge;

        public frmDodajUloga(ref List<DataTransferObjects.Uloga> uloge)
        {
            InitializeComponent();
            _glumacSerive = new APIService("Glumac");
            _uloge = uloge;
        }

        #region header
        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void LblWinDown_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
        }

        #endregion
        private async void FrmDodajUloga_Load(object sender, EventArgs e)
        {
            await LoadGlumci();
        }

        private async Task LoadGlumci()
        {
            _glumci=  await _glumacSerive.Get<List<GlumacUloga>>(null);

            cmbGlumac.DataSource = _glumci;
            cmbGlumac.DisplayMember = "ImePrezime";
            cmbGlumac.ValueMember = "Id";
        }

        private void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            _uloge.Add(new DataTransferObjects.Uloga { Glumac = _glumci.Where(w => w.Id == cmbGlumac.SelectedValue.ToString()).FirstOrDefault(), Id = "", IsGlavnaUloga = chbGlavnaUloga.Checked, Naziv = txbNaziv.Text, Predstava = null });
            Close();
        }

        public class GlumacUloga : DataTransferObjects.Glumac
        {
            public string ImePrezime { get { return $"{Ime} {Prezime}"; } }
        }
    }
}

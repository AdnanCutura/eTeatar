using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WinForms.Helpers;
using WinForms.Obavijest;
using WinForms.Predstava;

namespace WinForms.Teatar
{
    public partial class frmETeatar : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public frmETeatar(DataTransferObjects.Administrator admin)
        {
            InitializeComponent();
            PanelSwitcher.SetPanel(ref pnlUserControl);
            AdminData.SetObjects(imgAvatar, lblImePrezime);
            AdminData.Set(admin);

            //Default on top
            PanelSwitcher.setToTop(new uctTeatar());
        }

        private void FrmTeatar_Load(object sender, EventArgs e)
        {
            this.MouseDown += new MouseEventHandler(PnlHeader_MouseDown);
        }

        #region Header
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
            Environment.Exit(0);
        }
        #endregion

        #region Sidebar menu
        private void BtnTeatarMeni_Click(object sender, EventArgs e)
        {
            PanelSwitcher.setToTop(new uctTeatar());
        }

        private void BtnGlumac_Click(object sender, EventArgs e)
        {
            PanelSwitcher.setToTop(new Glumac.uctGlumac());
        }

        private void BtnPostavke_Click(object sender, EventArgs e)
        {
            PanelSwitcher.setToTop(new KorisnickiNalog.uctPostavke());
        }

        private void BtnKorisnici_Click(object sender, EventArgs e)
        {
            PanelSwitcher.setToTop(new KorisnickiNalog.uctKorisnickiNalog());
        }

        private void BtnObavijesti_Click(object sender, EventArgs e)
        {
            PanelSwitcher.setToTop(new uctObavijest());
        }

        private void BtnPredstave_Click(object sender, EventArgs e)
        {
            PanelSwitcher.setToTop(new uctPredstava());
        }

        #endregion
    }
}

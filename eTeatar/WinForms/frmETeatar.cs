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
using WinForms.Helpers;

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

        private readonly DataTransferObjects.KorisnickiNalog _admin;

        private readonly APIService _teatarService = new APIService("Teatar");
        public frmETeatar(DataTransferObjects.KorisnickiNalog admin)
        {
            InitializeComponent();
            PanelSwitcher.SetPanel(ref pnlUserControl);
            //Default on top
            PanelSwitcher.setToTop(new uctTeatar());
            _admin = admin;
            lblImePrezime.Text = $"{admin.Ime} {admin.Prezime}";

            if (admin.Slika.Length!=0)
                imgAvatar.Image = Converters.ByteArrayToSystemDrawing(admin.Slika);
        }


        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void FrmTeatar_Load(object sender, EventArgs e)
        {
            this.MouseDown += new MouseEventHandler(PnlHeader_MouseDown);
        }

        private void BtnTeatarMeni_Click(object sender, EventArgs e)
        {
            //user control lista teatara
            PanelSwitcher.setToTop(new uctTeatar());
        }

        private void LblWinDown_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnGlumac_Click(object sender, EventArgs e)
        {
            PanelSwitcher.setToTop(new Glumac.uctGlumac());
        }
    }
}

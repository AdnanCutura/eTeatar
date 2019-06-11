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

namespace WinForms.Login
{
    public partial class frmLogin : Form
    {
        private readonly APIService _adminService = new APIService("Administrator");

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public frmLogin()
        {
            InitializeComponent();
        }

        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.MouseDown += new MouseEventHandler(PnlHeader_MouseDown);
        }


        private void LblWinDown_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void BtnPrijaviSe_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txbUsername.Text;
                APIService.Password = txbPassword.Text;

                await _adminService.Get<dynamic>(null);

                bool formOpen = false;

                foreach(Form form in Application.OpenForms)
                    if (form.Name == "frmETeatar")
                        formOpen = true;

                if (!formOpen)
                {
                    this.Hide();
                    Teatar.frmETeatar frm = new Teatar.frmETeatar();
                    frm.Show();
                }

            }
            catch
            {/*Exception handeled*/}
        }
    }
}

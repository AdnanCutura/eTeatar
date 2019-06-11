using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public static class PanelSwitcher
    {
        private static Panel _pnlUserControl;

        public static void SetPanel(ref Panel panel)
        {
            _pnlUserControl = panel;
        }

        public static void setToTop(UserControl userControl)
        {
            if (!_pnlUserControl.Controls.Contains(userControl))
            {
                _pnlUserControl.Controls.Add(userControl);
                userControl.Dock = DockStyle.Fill;
            }

            userControl.BringToFront();
        }

        public static void RemoveControl(UserControl userControl)
        {
            if (_pnlUserControl.Controls.Contains(userControl))
                _pnlUserControl.Controls.Remove(userControl);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Teatar;

namespace WinForms
{
    public static class Factory
    {
        private static Panel _pnlUserControl;

        public static DataValidation GetValidator(ErrorProvider errorProvider)
        {
            return new DataValidation(errorProvider);
        }

        public static void SetPanel(ref Panel panel)
        {
            _pnlUserControl = panel;
        }

        public static Panel GetPanel()
        {
            return _pnlUserControl;
        }

    }
}

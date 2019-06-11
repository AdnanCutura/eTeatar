using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public static class Factory
    {
        public static DataValidation GetValidator(ErrorProvider errorProvider)
        {
            return new DataValidation(errorProvider);
        }
    }
}

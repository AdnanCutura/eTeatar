using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinForms.Properties;

namespace WinForms
{
    public class DataValidation
    {
        private readonly ErrorProvider _errorProvider;
        public DataValidation(ErrorProvider errorProvider)
        {
            _errorProvider = errorProvider;
        }

        #region Null checking

        public void NullCheck(Control attribute, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(attribute.Text))
            {
                e.Cancel = true;
                _errorProvider.SetError(attribute, Resources.Validation___Required_field);
            }
            else
                _errorProvider.SetError(attribute, null);
        }


        public void NullCheckTxb(TextBox attribute, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(attribute.Text))
            {
                e.Cancel = true;
                _errorProvider.SetError(attribute, Resources.Validation___Required_field);
            }
            else
                _errorProvider.SetError(attribute, null);
        }
        
        public void NullCheckCmb(ComboBox attribute, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(attribute.Text))
            {
                e.Cancel = true;
                _errorProvider.SetError(attribute, Resources.Validation___Required_field);
            }
            else
                _errorProvider.SetError(attribute, null);
        }


        public void NullCheckMaskBox(MaskedTextBox attribute, CancelEventArgs e)
        {
            if (!attribute.MaskFull)
            {
                e.Cancel = true;
                _errorProvider.SetError(attribute, Resources.Validation___Required_field);
                attribute.BeepOnError = true;
            }
            else
                _errorProvider.SetError(attribute, null);
        }

        #endregion

        #region Regex

        public void EmailRegexCheck(TextBox email, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            Match match = regex.Match(email.Text);

            if (!match.Success)
            {
                e.Cancel = true;
                _errorProvider.SetError(email, "Email mora biti u ispravnom formatu.");
            }
            else
                _errorProvider.SetError(email, null);
        }

        public void TimeRegexCheck(MaskedTextBox time, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^([01]?[0-9]|2[0-3]):[0-5][0-9]$");
            Match match = regex.Match(time.Text);

            if (!match.Success)
            {
                e.Cancel = true;
                _errorProvider.SetError(time, "Vrijeme mora biti u ispravnom formatu.");
            }
            else
                _errorProvider.SetError(time, null);
        }

        #endregion
    }
}
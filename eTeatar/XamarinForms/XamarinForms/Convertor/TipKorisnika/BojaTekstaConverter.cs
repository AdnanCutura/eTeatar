using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamarinForms.Convertor.TipKorisnika
{
    public class BojaTekstaConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var tipKupca = value as string;

                switch (tipKupca)
                {
                    case "Standard":
                        return Color.White;
                    case "Silver":
                        return Color.FromHex("#221d1d");
                    case "Platinum":
                        return Color.FromHex("#221d1d");
                    case "Gold":
                        return Color.White;
                }
            }

            return Color.White;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

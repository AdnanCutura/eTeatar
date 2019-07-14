using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamarinForms.Convertor.TipKorisnika
{
    public class BojaPozadineConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var tipKupca = value as string;

                switch (tipKupca)
                {
                    case "Standard":
                        return Color.Gray;
                    case "Silver":
                        return Color.Silver;
                    case "Platinum":
                        return Color.FromHex("#e5e4e2");
                    case "Gold":
                        return Color.DarkGoldenrod;
                }
            }

            return Color.Gray;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

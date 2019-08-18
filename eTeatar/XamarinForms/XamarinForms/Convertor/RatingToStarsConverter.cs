using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Android.Webkit;
using Xamarin.Forms;

namespace XamarinForms.Convertor
{
    public class RatingToStarsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var rating = (double)value;

            switch (Math.Round(rating))
            {
                case 1: return "★";
                case 2: return "★★";
                case 3: return "★★★";
                case 4: return "★★★★";
                case 5: return "★★★★★";
            }

            if (!string.IsNullOrWhiteSpace(parameter.ToString()))
                return parameter.ToString();

            return "Trenutno nema ocjena";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

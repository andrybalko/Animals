using System;
using System.Globalization;
using Xamarin.Forms;

namespace Animals.com.animals.converters
{
    public class InvertBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var original = (bool)value;
            return !original;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var original = (bool)value;
            return !original;
        }
    }
}

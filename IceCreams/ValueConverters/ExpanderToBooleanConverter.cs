
using System;
using System.Globalization;

namespace IceCreams
{
    public class ExpanderToBooleanConverter : ValueConverterBase<ExpanderToBooleanConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value == parameter);
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (System.Convert.ToBoolean(value)) return parameter;
                return null;
        }
    }
}

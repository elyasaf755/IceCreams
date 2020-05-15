
using System;
using System.Globalization;

namespace IceCreams
{
    public class IsNullOrEmptyConverter : ValueConverterBase<IsNullOrEmptyConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
                return value == null || (value as string) == "";

            return (value == null);
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException("IsNullConverter can only be used OneWay.");
        }
    }
}

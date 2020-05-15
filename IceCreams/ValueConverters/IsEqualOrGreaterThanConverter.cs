using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreams
{
    public class IsEqualOrGreaterThanConverter : ValueConverterBase<IsEqualOrGreaterThanConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int intValue = (int)value;
            int compareToValue = int.Parse(parameter as string);

            return intValue >= compareToValue;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("IsEqualOrGreaterThanConverter's ConvertBack not implemented!");
        }
    }
}

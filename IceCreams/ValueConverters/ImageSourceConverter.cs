﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace IceCreams
{
    public class ImageSourceConverter : ValueConverterBase<ImageSourceConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType == typeof(ImageSource))
            {
                if (value is string)
                {
                    string str = (string)value;
                    return new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                }
                else if (value is Uri)
                {
                    Uri uri = (Uri)value;
                    return new BitmapImage(uri);
                }
            }
            return value;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

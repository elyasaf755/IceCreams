using System;
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
            BitmapImage result;

            if (targetType == typeof(ImageSource))
            {
                if (value is string)
                {
                    string str = (string)value;

                    try
                    {
                        result = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                    }
                    catch (System.IO.IOException)
                    {
                        return new BitmapImage(new Uri(@"pack://application:,,,/Images/image_not_found.png", UriKind.RelativeOrAbsolute));
                    }

                    return result;
                }
                else if (value is Uri)
                {
                    Uri uri = (Uri)value;

                    try
                    {
                        result = new BitmapImage(uri);
                    }
                    catch (System.IO.IOException)
                    {
                        return new BitmapImage(new Uri(@"pack://application:,,,/Images/image_not_found.png", UriKind.RelativeOrAbsolute));
                    }

                    return result;
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

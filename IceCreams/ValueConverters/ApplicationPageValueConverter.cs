using System;
using System.Diagnostics;
using System.Globalization;
using ViewModels;

namespace IceCreams
{
    /// <summary>
    /// Converts the <see cref="ApplicationPage"/> to an actual view/page
    /// </summary>
    public class ApplicationPageValueConverter : ValueConverterBase<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate page
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Login:
                    return new LoginPage();

                case ApplicationPage.RegisterEmail:
                    return new RegisterEmailPage();

                case ApplicationPage.RegisterDate:
                    return new RegisterDatePage();

                case ApplicationPage.RegisterPassword:
                    return new RegisterPasswordPage();

                case ApplicationPage.MainPage:
                    return new MainPage();

                case ApplicationPage.Store:
                    return new StorePage(ViewModelLocator.ApplicationViewModel.CurrentPageViewModel);

                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

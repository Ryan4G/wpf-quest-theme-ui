using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace QuestThemeUI.Converters
{
    [ValueConversion(typeof(string), typeof(Uri))]
    public class StringUriConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var uriPath = System.Convert.ToString(value);

            return new Uri(uriPath, UriKind.Relative);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new Uri("Pages/Default.xaml", UriKind.Relative);
        }
    }
}

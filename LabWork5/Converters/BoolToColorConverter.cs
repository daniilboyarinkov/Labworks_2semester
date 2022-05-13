using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace LabWork5.Converters
{
    public class BoolToColorConverter : IValueConverter
    {
        /// <summary>
        /// Converts Bool to either Green Color or Red Color
        /// </summary>
        /// <param name="value">Bool value to be converted</param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
            (bool)value ? Brushes.Green : Brushes.Red;

        /// <summary>
        /// Do it please for me somebody I'm to lazy to make it done.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
            throw new NotImplementedException();
    }
}

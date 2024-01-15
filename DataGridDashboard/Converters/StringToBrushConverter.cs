using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Avalonia.Data.Converters;
using Avalonia.Media;

namespace DataGridDashboard.Converters;
public class StringToBrushConverter : IValueConverter
{
    private static readonly BrushConverter _converter = new();
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return _converter.ConvertFromString(value.ToString()!);
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return _converter.ConvertToString(value);
    }
}

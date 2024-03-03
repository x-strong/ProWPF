using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ProWPF.Modules.CustomControls.Converters
{
  internal class OffsetConverter : IMultiValueConverter
  {
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
      if (values[0] is double v1 && values[1] is double v2)
      {
        var offset = (v1 - v2) / 2;
        Debug.WriteLine($"v1 is {v1}, v2 is {v2}, offset is {offset}.{Environment.NewLine}");

        return offset;
      }

      Debug.WriteLine($"Abnormal values:[{values[0]},{values[1]}].{Environment.NewLine}");

      return DependencyProperty.UnsetValue;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}

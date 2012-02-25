using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace CustomComboBoxTest
{
    class MaxSnoozeValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return 0;

            var control = (SnoozeControl) value;

            return DateTime.Now < control.EventTime ? control.EventTime.Subtract(DateTime.Now).TotalMinutes : 60;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

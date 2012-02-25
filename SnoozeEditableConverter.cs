using System;
using System.Windows.Data;

namespace GoogleCalendarReminder.Converters
{
    public class SnoozeEditableConverter : IValueConverter
    {
        public static readonly int CustomSnoozeValue = -100;

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null) return String.Empty;

            var snooze = 0;
            try
            {
                snooze = (int)value;
            }
            catch (InvalidCastException)
            {
                return String.Empty;
            }

            return snooze == CustomSnoozeValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

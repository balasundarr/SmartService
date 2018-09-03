﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace Smart.Wasl.Homes.Clients.Core.Converters
{
    public class CheckInTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                string time = value.ToString();
                DateTime date = DateTime.Parse(time, culture);

                return date.ToString("HH:mm tt");
            }
            catch
            {
                return value;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}

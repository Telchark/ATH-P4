﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfAppLab12.Converter
{
    [ValueConversion(typeof(int),typeof(double))]
    public class HeigthZoomConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var zoom = (int)value;
            return zoom; 
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    [ValueConversion(typeof(int),typeof(double))]
    public class WidthZoomConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var zoom = (int)value;
            return zoom * 2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

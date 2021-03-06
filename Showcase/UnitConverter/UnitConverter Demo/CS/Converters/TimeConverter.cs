﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace UnitConverterDemo
{
    public class TimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
                return value;
            if (value == null)
            {
                return null;
            }
            double _value = (double)value;

            if (parameter.Equals("SEC"))
            {
                return 31536000 * _value;
            }
            else if (parameter.Equals("MS"))
            {
                return 3.1536E10 * _value;
            }
            else if (parameter.Equals("MIN"))
            {
                return 525600 * _value;
            }           
            else if (parameter.Equals("DAY"))
            {
                return _value * 365;
            }
            else if (parameter.Equals("MONTH"))
            {
                return _value * 12;
            }
            else if (parameter.Equals("WEEK"))
            {
                return _value * 52.14;
            }
            else if (parameter.Equals("HR"))
            {
                return _value * 8760;
            }
            else
            {
                return Decimal.Parse(value.ToString());
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
                return value;
            if (value == null)
            {
                return null;
            }
            double _value = Double.Parse(value.ToString());

            if (parameter.Equals("SEC"))
            {
                return _value / 31536000;
            }
            else if (parameter.Equals("MS"))
            {
                return _value / 3.1536E10;
            }
            else if (parameter.Equals("MIN"))
            {
                return _value / 525600;
            }
            else if (parameter.Equals("DAY"))
            {
                return _value / 365;
            }
            else if (parameter.Equals("MONTH"))
            {
                return _value / 12;
            }
            else if (parameter.Equals("WEEK"))
            {
                return _value / 52.14;
            }
            else if (parameter.Equals("HR"))
            {
                return _value / 8760;
            }
            else
            {
                return Decimal.Parse(value.ToString());
            }
        }
    }
}

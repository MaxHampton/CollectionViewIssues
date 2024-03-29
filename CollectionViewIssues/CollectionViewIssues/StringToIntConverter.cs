﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace CollectionViewIssues
{
  public class StringToIntConverter : IValueConverter
  {
    public object Convert
    (
      object value,
      Type targetType,
      object parameter,
      CultureInfo culture
    )
    {
      return int.Parse((string) value);
    }

    public object ConvertBack
    (
      object value,
      Type targetType,
      object parameter,
      CultureInfo culture)
    {
      return ((int) value).ToString();
    }
  }
}

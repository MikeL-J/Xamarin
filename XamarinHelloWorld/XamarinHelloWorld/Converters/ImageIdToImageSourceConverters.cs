//using System;
//using System.Globalization;
//using System.Windows;
//using System.Windows.Data;
//using System.Windows.Media;

//using BermudaVend;
//using Xamarin.Forms;

//namespace bermuda_vend.Converters
//{
//    [ValueConversion(typeof(string), typeof(ImageSource))]
//    public class ImageIdToImageSourceConverter : IValueConverter
//    {
//        #region IValueConverter
//        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
//        {
//            return Application.Current.Resources.FindResource(value);
//        }
//        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
//        {
//            throw new NotImplementedException();
//        }
//        #endregion
//    }
//}

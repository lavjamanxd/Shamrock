using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Shamrock.Wpf.Converter
{
    public class ByteToImageSourceConverter : IValueConverter
    {
        private BitmapImage GetBitmapImageFromBytes(byte[] bytes)
        {
            BitmapImage bitmapImage;
            using (var memoryStream = new MemoryStream(bytes))
            {
                bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memoryStream;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                bitmapImage.Freeze();
            }
            return bitmapImage;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null ? GetBitmapImageFromBytes(value as byte[]) : null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}

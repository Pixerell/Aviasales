using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace UshakovAviaSales.Classes
{
    class HelperClass
    {
        public static void DigitOnlyInput(TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0) && e.Text[0] != ',')
            {
                e.Handled = true;
            }
        }

        public static List<object> GetAllFieldsWithText(object obj)
        {
            return obj.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(f => f.FieldType == typeof(TextBox) || f.FieldType == typeof(ComboBox))
                .Select(f => f.GetValue(obj))
                .ToList();
        }

        public static bool IsAllTextFieldsFill(object obj)
        {
            var fields = HelperClass.GetAllFieldsWithText(obj);
            return fields
                .Select(f => !string.IsNullOrEmpty(f.GetType().GetProperty("Text").GetValue(f) as string))
                .Aggregate((b1, b2) => b1 && b2);
        }
        public static BitmapImage BitmapToImageSource(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();

                return bitmapimage;
            }
        }
    }
}

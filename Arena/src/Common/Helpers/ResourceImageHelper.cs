﻿using System.IO;
using System.Windows.Media.Imaging;
using System.Drawing;

namespace Common.Helpers
{
    public static class ResourceImageHelper
    {
        public static BitmapImage LoadImage(Bitmap bitmap)
        {
            var ms = new MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            ms.Position = 0;
            var bi = new BitmapImage();
            bi.BeginInit();
            bi.StreamSource = ms;
            bi.EndInit();
            return bi;
        }
    }
}

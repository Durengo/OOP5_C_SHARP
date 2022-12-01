using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.source.Core
{
    public class Base64
    {
        public static string ConvertAndGetImageAsString(string imageFilepath)
        {
            Image img = new Bitmap(imageFilepath);
            var format = GetImageFormat(imageFilepath);

            return ImageToBase64(img, format);

        }
        public static string ImageToBase64(Image img, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
        public static Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        public static System.Drawing.Imaging.ImageFormat GetImageFormat(string file)
        {
            string extension = Path.GetExtension(file);
            if (string.IsNullOrEmpty(extension))
            {
                throw new ArgumentException(string.Format("Unable to determine file extension for filename: {0}", file));
            }
            switch (extension.ToLower())
            {
                case @".bmp":
                    return System.Drawing.Imaging.ImageFormat.Bmp;

                case @".gif":
                    return System.Drawing.Imaging.ImageFormat.Gif;

                case @".ico":
                    return System.Drawing.Imaging.ImageFormat.Icon;

                case @".jpg":
                case @".jpeg":
                    return System.Drawing.Imaging.ImageFormat.Jpeg;

                case @".png":
                    return System.Drawing.Imaging.ImageFormat.Png;

                case @".tif":
                case @".tiff":
                    return System.Drawing.Imaging.ImageFormat.Tiff;

                case @".wmf":
                    return System.Drawing.Imaging.ImageFormat.Wmf;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}

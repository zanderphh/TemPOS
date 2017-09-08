using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ThoughtWorks.QRCode.Codec.Data
{
    public class QRCodeBitmapImage : QRCodeImage
    {
        private Bitmap image;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="image">Bitmap image/param>
        public QRCodeBitmapImage(Bitmap image)
        {
            this.image = image;
        }

        public QRCodeBitmapImage(string fileName)
        {
            this.image = new Bitmap(fileName);
        }

        virtual public int Width
        {
            get
            {
                return image.Width;
            }

        }
        virtual public int Height
        {
            get
            {
                return image.Height;
            }

        }
     

        public virtual int getPixel(int x, int y)
        {
            return image.GetPixel(x, y).ToArgb();
        }
    }
}

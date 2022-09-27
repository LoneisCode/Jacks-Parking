using System;
using System.Text;
using System.Drawing;
using SkiaSharp;

namespace JacksUI
{
    internal class Bitmapping
    {
        //System.Drawing.Image lot = new Image { Source = "/Resources/Images/lotImage.jpg" };
        //Bitmap lotImage = BitmapFactory.DecodeFile("/Resources/Images/lotImage.jpg");

        SKBitmap lotImage = SKBitmap.Decode("lotImage.jpg");

        //Bitmap lotImage = new Bitmap("/Resources/Images/lotImage.jpg");

        //returns the R values of the diagonal pixels. Hardcoded for one spot.
        public byte[] getR()
        {
            int x = 2333;
            int y = 2297;
            byte[] rValues = new byte[120];

            for (int i = 0; i < 120; i++)
            {
                SKColor c = lotImage.GetPixel(x, y);
                rValues[i] = c.Red;
                x += 2;
                y -= 2;
            }



            return rValues;
        }

        //returns the G values of the diagonal pixels. Hardcoded for one spot.
        public byte[] getG()
        {
            int x = 2333;
            int y = 2297;
            byte[] gValues = new byte[120];

            for (int i = 0; i < 120; i++)
            {
                SKColor c = lotImage.GetPixel(x, y);
                gValues[i] = c.Green;
                x += 2;
                y -= 2;
            }

            return gValues;
        }

        //returns the B values of the diagonal pixels. Hardcoded for one spot.
        public byte[] getB()
        {
            int x = 2333;
            int y = 2297;
            byte[] bValues = new byte[120];

            for (int i = 0; i < 120; i++)
            {
                SKColor c = lotImage.GetPixel(x, y);
                bValues[i] = c.Blue;
                x += 2;
                y -= 2;
            }

            return bValues;
        }
    }
}

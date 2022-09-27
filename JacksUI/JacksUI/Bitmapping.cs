using System;
using System.Text;
using System.Drawing;

namespace JacksUI
{
    internal class Bitmapping
    {
        //System.Drawing.Image lot = new Image { Source = "/Resources/Images/lotImage.jpg" };
        //Bitmap lotImage = BitmapFactory.DecodeFile("/Resources/Images/lotImage.jpg");

        Bitmap lotImage = new Bitmap("/Resources/Images/lotImage.jpg");

        //returns the R values of the diagonal pixels. Hardcoded for one spot.
        public byte[] getR(int x, int y)
        {
            int x = 2333;
            int y = 2297;
            byte[] rValues = new byte[120];

            for (int i = 0; i < 120; i++)
            {
                System.Drawing.Color c = lotImage.GetPixel(x, y);
                rValues[i] = c.R;
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
                System.Drawing.Color c = lotImage.GetPixel(x, y);
                gValues[i] = c.G;
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
                System.Drawing.Color c = lotImage.GetPixel(x, y);
                bValues[i] = c.B;
                x += 2;
                y -= 2;
            }

            return bValues;
        }
    }
}

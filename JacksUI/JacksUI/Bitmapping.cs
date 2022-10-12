using System;
using System.Drawing;

namespace JacksUI
{
    public class Bitmapping
    {
        //System.Drawing.Image lot = new Image { Source = "/Resources/Images/lotImage.jpg" };
        //Bitmap lotImage = BitmapFactory.DecodeFile("/Resources/Images/lotImage.jpg");

        //System.Drawing.Image lot = Image.
        //static Microsoft.Maui.Controls.Image image = new Microsoft.Maui.Controls.Image
        //{
         //   Source = ImageSource.FromFile("Resources/images/lot_image.png")
       // };

        static Bitmap lotImage = new Bitmap("Resources/images/lot_image.png");


        //returns the R values of the diagonal pixels. Hardcoded for one spot.
        public static byte[] getR()
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
            Console.WriteLine(rValues[0]);
            return rValues;
        }

        //returns the G values of the diagonal pixels. Hardcoded for one spot.
        public static byte[] getG()
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
            Console.WriteLine(gValues[0]);
            return gValues;
        }

        //returns the B values of the diagonal pixels. Hardcoded for one spot.
        public static byte[] getB()
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
            Console.WriteLine(bValues[0]);
            return bValues;
        }
    }
}

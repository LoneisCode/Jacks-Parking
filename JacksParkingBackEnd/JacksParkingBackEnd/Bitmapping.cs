using JacksParkingBackEnd;
using System;
using System.Drawing;

    public class Bitmapping
    {
        //static Bitmap lotImage = new Bitmap("Resources/images/lot_image.png");
       /* ParkingLot[] lots;
        Bitmap[] bitmaps;
        Bitmapping(ParkingLot[] lots, Bitmap[] bitmaps)
        {
            this.lots = lots;
            //generating bitmaps for each lot
            for(int i = 0; i < bitmaps.Length; i++)
            {
                bitmaps[i] = new Bitmap(lots[i].getImagePath());
            }
        } */

        //returns the R values of the diagonal pixels. Hardcoded for one spot.
        public static byte[] getR(Bitmap lot, int topX, int topY, int bottomX, int bottomY, int length)
        {
            //int x = 308;//2333;
            //int y = 292;//2297;
            byte[] rValues = new byte[length];

            for (int i = 0; i < length; i++)
            {
                Color c = lotImage.GetPixel(x, y);
                rValues[i] = c.R;
                x += 1;
                y -= 1;
            }
            //Console.WriteLine(rValues[0]);
            System.Diagnostics.Debug.WriteLine(rValues[0]);
            return rValues;
        }

        //returns the G values of the diagonal pixels. Hardcoded for one spot.
        public static byte[] getG(int topX, int topY, int bottomX, int bottomY, int length)
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
        public static byte[] getB(int topX, int topY, int bottomX, int bottomY, int length)
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
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

        //returns the R values of the diagonal pixels. Iterates over the x coordinate 
        public static double[] getR(ParkingSpot spot, Bitmap lot){//Bitmap lot, int topX, int topY, int bottomX, int bottomY, int length, int slope)
        {
            //setting the starting pixel (bottom left corner)
            int x = spot.getBottomX(); //being int, pixels will be somewhat off of diagonal but should be good enough
            int y = spot.getBottomY();

            double[] rValues = new double[spot.getLength()];
            
            for (int i = 0; i < spot.getTopX(); i++)
            {
                Color c = lot.GetPixel(x, y);
                rValues[i] = c.R;
                x += 1; 
                y = (int)(spot.getSlope() * x + spot.getB());
            }
            //Console.WriteLine(rValues[0]);
            System.Diagnostics.Debug.WriteLine(rValues[0]);
            return rValues;
        }

        //returns the G values of the diagonal pixels. Hardcoded for one spot.
        public static double[] getG(int topX, int topY, int bottomX, int bottomY, int length)
        {
            int x = 2333;
            int y = 2297;
            double[] gValues = new double[120];

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
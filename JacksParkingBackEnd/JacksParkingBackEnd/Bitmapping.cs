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
           
            return rValues;
        }

        //returns the G values of the diagonal pixels. Hardcoded for one spot.
        public static double[] getG(Bitmap lot, int topX, int topY, int bottomX, int bottomY, int length, int slope)
        {
        int x = bottomX;//2333;
        int y = bottomY;//2297;
        double[] gValues = new double[length];

        for (int i = 0; i < length; i++)
        {
            Color c = lot.GetPixel(x, y);
            gValues[i] = (double)c.G;
            x += 1;
            y -= 1;
        }
        //Console.WriteLine(rValues[0]);
        System.Diagnostics.Debug.WriteLine(gValues);
        return gValues;
    }

        //returns the B values of the diagonal pixels. Hardcoded for one spot.
        public static double[] getB(Bitmap lot, int topX, int topY, int bottomX, int bottomY, int length, int slope)
        {
            int x = bottomX;//2333;
            int y = bottomY;//2297;
            double[] bValues = new double[length];

            for (int i = 0; i < length; i++)
            {
                Color c = lot.GetPixel(x, y);
                bValues[i] = (double)c.B;
                x += 1;
                y -= 1;
            }
            //Console.WriteLine(rValues[0]);
            System.Diagnostics.Debug.WriteLine(bValues);
            return bValues;
        }
    }
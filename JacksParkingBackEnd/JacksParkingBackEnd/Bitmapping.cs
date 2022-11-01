using JacksParkingBackEnd;
using System;
using System.Drawing;

    public class Bitmapping
    {

    //returns the R values of the diagonal pixels. Iterates over the x coordinate 
        public static double[] getR(ParkingSpot spot, Bitmap lot)
        {
            //setting the starting pixel (bottom left corner)
            int x = spot.getBottomX(); //being int, pixels will be somewhat off of diagonal but should be good enough
            int y = spot.getBottomY();

            double[] rValues = new double[spot.getXRange()];

            for (int i = 0; i < spot.getXRange(); i++)
            {
                Color c = lot.GetPixel(x, y);
                rValues[i] = c.R;
                if (spot.getTopLeft())
                    x -= 1;
                else
                    x += 1;

                y = (int)(spot.getSlope() * x + spot.getB());
            }

            return rValues;
        }

        public static double[] getG(ParkingSpot spot, Bitmap lot)
        {
                //setting the starting pixel (bottom left corner)
                int x = spot.getBottomX(); //being int, pixels will be somewhat off of diagonal but should be good enough
                int y = spot.getBottomY();

                double[] gValues = new double[spot.getXRange()];

                for (int i = 0; i < spot.getXRange(); i++)
                {
                    Color c = lot.GetPixel(x, y);
                    gValues[i] = c.G;
                    if (spot.getTopLeft())
                        x -= 1;
                    else
                        x += 1;
                    y = (int)(spot.getSlope() * x + spot.getB());
                }

                return gValues;
        }

        public static double[] getB(ParkingSpot spot, Bitmap lot)
        {
            //setting the starting pixel (bottom left corner)
            int x = spot.getBottomX(); //being int, pixels will be somewhat off of diagonal but should be good enough
            int y = spot.getBottomY();

            double[] bValues = new double[spot.getXRange()];

            for (int i = 0; i < spot.getXRange(); i++)
            {
                Color c = lot.GetPixel(x, y);
                bValues[i] = c.B;
                if (spot.getTopLeft())
                    x -= 1;
                else
                    x += 1;
                y = (int)(spot.getSlope() * x + spot.getB());
            }

            return bValues;
        }
    }
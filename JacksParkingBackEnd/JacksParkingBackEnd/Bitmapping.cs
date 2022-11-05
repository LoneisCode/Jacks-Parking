using JacksParkingBackEnd;
using System;
using System.Drawing;

    public class Bitmapping
    {
        // Input: A single parking spot object.
        // Output: Red component values of the diagonal pixels.
        // Iterates over the x coordinate.
        public static double[] GetR(ParkingSpot spot, Bitmap lot)
        {
            // TODO: Add "if" to set x and y to top or bottom left (x,y) pair coordinate.
            // Setting the starting pixel (either top left OR bottom left).
            // Being int, pixels will be somewhat off of diagonal but should be good enough.
            int x = spot.getBottomX(); 
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

        // Input: A single parking spot object.
        // Output: Green component values of the diagonal pixels.
        // Iterates over the x coordinate.
        public static double[] GetG(ParkingSpot spot, Bitmap lot)
        {
            // TODO: Add "if" to set x and y to top or bottom left (x,y) pair coordinate.
            // Setting the starting pixel (either top left OR bottom left).
            // Being int, pixels will be somewhat off of diagonal but should be good enough.
            int x = spot.getBottomX(); 
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

        // Input: A single parking spot object.
        // Output: Green component values of the diagonal pixels.
        // Iterates over the x coordinate.
        public static double[] GetB(ParkingSpot spot, Bitmap lot)
        {
            // TODO: Add "if" to set x and y to top or bottom left (x,y) pair coordinate.
            // Setting the starting pixel (either top left OR bottom left).
            // Being int, pixels will be somewhat off of diagonal but should be good enough.
            int x = spot.getBottomX(); 
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
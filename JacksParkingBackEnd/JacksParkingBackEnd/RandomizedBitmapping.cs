using JacksParkingBackEnd;
using System;
using System.Drawing;
using System.Linq;

public class RandomizedBitmapping
{
    
    // Input: A single parking spot object.
    // Output: Red component values of the diagonal pixels.
    // Iterates over the x coordinate.
    public static double[] GetR(ParkingSpot spot, Bitmap lot)
    {
        int arrSize = 100;
        // rand.Next(min, max) creates a number
        // between min and up to but not including max
        int maxX = spot.GetMaxX() + 1;
        int maxY = spot.GetMaxY() + 1;
        double[] rValues = new double[arrSize];

        for (int i = 0; i < arrSize; i++)
        {
            Random randomizedCoordinate = new Random();
            int x = randomizedCoordinate.Next(spot.GetMinX(), maxX);
            int y = randomizedCoordinate.Next(spot.GetMinY(), maxY);
            Color c = lot.GetPixel(x, y);
            rValues[i] = c.R;
        }

        return rValues;
    }

    // Input: A single parking spot object.
    // Output: Green component values of the diagonal pixels.
    // Iterates over the x coordinate.
    public static double[] GetG(ParkingSpot spot, Bitmap lot)
    {
        int arrSize = 100;
        // rand.Next(min, max) creates a number
        // between min and up to but not including max
        int maxX = spot.GetMaxX() + 1;
        int maxY = spot.GetMaxY() + 1;
        double[] gValues = new double[arrSize];

        for (int i = 0; i < arrSize; i++)
        {
            Random randomizedCoordinate = new Random();
            int x = randomizedCoordinate.Next(spot.GetMinX(), maxX);
            int y = randomizedCoordinate.Next(spot.GetMinY(), maxY);
            Color c = lot.GetPixel(x, y);
            gValues[i] = c.G;
        }

        return gValues;
    }

    // Input: A single parking spot object.
    // Output: Green component values of the diagonal pixels.
    // Iterates over the x coordinate.
    public static double[] GetB(ParkingSpot spot, Bitmap lot)
    {
        int arrSize = 100;
        // rand.Next(min, max) creates a number
        // between min and up to but not including max
        int maxX = spot.GetMaxX() + 1;
        int maxY = spot.GetMaxY() + 1;
        double[] bValues = new double[arrSize];

        for (int i = 0; i < arrSize; i++)
        {
            Random randomizedCoordinate = new Random();
            int x = randomizedCoordinate.Next(spot.GetMinX(), maxX);
            int y = randomizedCoordinate.Next(spot.GetMinY(), maxY);
            Color c = lot.GetPixel(x, y);
            bValues[i] = c.B;
        }

        return bValues;
    }
}
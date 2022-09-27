using System;

namespace JacksUI
{
    public class Calculations
    {
        //Input: Array of Red values, Array of Blue values, or Array of Green values
        //Output: Population Standard Deviation
        public static double standardDeviation(double[] colorArr, double mean)
        {
            double sum = colorArr.Sum(d => Math.Pow(d - mean, 2));
            return Math.Sqrt((sum) / colorArr.Count());

        }

        public static String ConfidenceInterval(double[] colorArr)
        {
            double[] result = new double[2];
            double mean = colorArr.Average();
            int sampleSize = colorArr.Length - 1;
            double sd = standardDeviation(colorArr, mean);
            double lowerBound = mean - (Constants.confidenceLevel_99 * (sd / Math.Sqrt(sampleSize)));
            double upperBound = mean + (Constants.confidenceLevel_99 * (sd / Math.Sqrt(sampleSize)));

            result[0] = lowerBound;
            result[1] = upperBound;

            return lowerBound + ", " + upperBound;
        }
    }
}

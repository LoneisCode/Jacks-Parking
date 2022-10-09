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

        public static double[] ConfidenceInterval(double[] colorArr)
        {
            double[] result = new double[2];
            try
            {
                double mean = colorArr.Average();
                int sampleSize = colorArr.Length - 1;
                double sd = standardDeviation(colorArr, mean);
                double lowerBound = mean - (Constants.confidenceLevel_99 * (sd / Math.Sqrt(sampleSize)));
                double upperBound = mean + (Constants.confidenceLevel_99 * (sd / Math.Sqrt(sampleSize)));

                result[0] = lowerBound;
                result[1] = upperBound;

                return result;
            }
            catch (NullReferenceException e) {
                Console.WriteLine("RBG array is null or value at index i is null.");
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}

using System;
using System.Linq;

namespace JacksParkingBackEnd
{
    // Calculations class only intended for retrieving confidence interval 
    // for an empty parking spot. 
    public class Calculations
    {
        // Input: Array of Red values, Array of Blue values, or Array of Green values.
        // Output: Population Standard Deviation.
        // Helper method to ConfidenceInterval().
        private static double StandardDeviation(double[] colorArr, double mean)
        {
            try
            {
                double sum = colorArr.Sum(d => Math.Pow(d - mean, 2));
                double unroundedResult = Math.Sqrt((sum) / colorArr.Count());
                return Math.Round(unroundedResult, 7);
            }
            catch (ArgumentNullException e)
            {
                throw e;
            }
        }

        // Input: Array of Red values, Array of Blue values, or Array of Green values.
        // Output: Confidence intervals of red, green, and blue values.
        public static double[] ConfidenceInterval(double[] colorArr)
        {
            double[] result = new double[2];
            try
            {
                double mean = colorArr.Average();
                int sampleSize = colorArr.Length - 1;
                double sd = StandardDeviation(colorArr, mean);
                double lowerBound = mean - (Constants.confidenceLevel_99 * (sd / Math.Sqrt(sampleSize)));
                double upperBound = mean + (Constants.confidenceLevel_99 * (sd / Math.Sqrt(sampleSize)));

                result[0] = Math.Round(lowerBound, 7);
                result[1] = Math.Round(upperBound, 7);

                return result;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("RBG array is null or value at index i is null.");
                throw e;
              
            }
        }
    }
}

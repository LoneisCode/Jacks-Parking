using System;
using System.Linq;

namespace JacksParkingBackEnd
{
    public class Calculations
    {
        //Input: Array of Red values, Array of Blue values, or Array of Green values
        //Output: Population Standard Deviation
        public static double standardDeviation(double[] colorArr, double mean)
        {
            try
            {
                double sum = colorArr.Sum(d => Math.Pow(d - mean, 2));
                double unroundedResult = Math.Sqrt((sum) / colorArr.Count());
                return Math.Round(unroundedResult, 7);
            }
            catch (ArgumentNullException e) {
                Console.WriteLine(e.Message);
            }
            return -1;
        }

        public static double[] confidenceInterval(double[] colorArr)
        {
            double[] result = new double[2]; 
            try
            {
                double mean = colorArr.Average();
                int sampleSize = colorArr.Length - 1;
                double sd = standardDeviation(colorArr, mean);
                double lowerBound = mean - (Constants.confidenceLevel_99 * (sd / Math.Sqrt(sampleSize)));
                double upperBound = mean + (Constants.confidenceLevel_99 * (sd / Math.Sqrt(sampleSize)));

                result[0] = Math.Round(lowerBound, 7);
                result[1] = Math.Round(upperBound, 7);

                return result;
            }
            catch (ArgumentNullException e) {
                Console.WriteLine("RBG array is null or value at index i is null.");
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public static bool? IsAvailable(double[] standardOfComparison, double[] colorArray) {
            try
            {
                double mean = colorArray.Average();
                double lowerBound = standardOfComparison[0];
                double upperBound = standardOfComparison[1];
                if ((mean >= lowerBound) && (mean <= upperBound))
                {
                    System.Diagnostics.Debug.WriteLine("true");
                    return true;
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("RBG array is null or value at index i is null.");
                Console.WriteLine(e.Message);
            }

            System.Diagnostics.Debug.WriteLine("false");
            return null;
        }
    }
}

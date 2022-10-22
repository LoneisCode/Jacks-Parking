using JacksUI;
using Xunit.Sdk;

namespace JacksUnitTest
{
    public class CalculationsTest
    {
        [Fact]
        public void StandardDeviation()
        {
            //valid array input
            double actualValue = Calculations.standardDeviation(CalculationsHelper.colorArr, CalculationsHelper.colorArrAverage);
            Assert.Equal(CalculationsHelper.expectedStandardDeviation, actualValue);

            //null array input
            double[]? colorArr = null;
            actualValue = Calculations.standardDeviation(colorArr, 0);
            Assert.Equal(-1, actualValue);
            
        }

        [Fact]
        public void ConfidenceInterval(){

            //valid array input
            double[] actualValue = Calculations.confidenceInterval(CalculationsHelper.colorArr);
            Assert.Equal(CalculationsHelper.expectedLowerBound, actualValue[0]);
            Assert.Equal(CalculationsHelper.expectedUpperBound, actualValue[1]);

            //null array input
            double[]? colorArr = null;
            actualValue = Calculations.confidenceInterval(colorArr);
            Assert.Null(actualValue);
        }
    }
}
using JacksParkingBackEnd;
namespace JacksParking_UnitTests
{
    public class CalculationUnitTests
    {
        // No longer testing StandardDeviation() because of its privacy level. 
        // Because it is a component that ConfidenceInterval() is dependant upon,
        // it implicitly is tested by testing ConfidenceInterval()
        /*
        [Fact]
        public void StandardDeviation()
        {
            // Valid array input
            double actualValue = Calculations.StandardDeviation(CalculationsHelper.colorArr, CalculationsHelper.colorArrAverage);
            Assert.Equal(CalculationsHelper.expectedStandardDeviation, actualValue);
            // Null array input
            double[]? colorArr = null;
            actualValue = Calculations.StandardDeviation(colorArr, 0);
            Assert.Equal(-1, actualValue);
        }
        */
        [Fact]
        public void CalculateCorrectConfidenceInterval()
        {
            //valid array input
            double[] actualValue = Calculations.ConfidenceInterval(CalculationsHelper.colorArr);
            Assert.Equal(CalculationsHelper.expectedLowerBound, actualValue[0]);
            Assert.Equal(CalculationsHelper.expectedUpperBound, actualValue[1]);
        }
        [Fact]
        public void CalculateConfidenceIntervalWithNullInput()
        {
            //null array input
            double[]? colorArr = null;
            double[] actualValue = Calculations.ConfidenceInterval(colorArr);
            Assert.Null(actualValue);
        }
    }
}
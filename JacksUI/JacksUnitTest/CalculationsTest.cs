using JacksUI;

namespace JacksUnitTest
{
    public class CalculationsTest
    {
        [Fact]
        public void StandardDeviation()
        {
            Calculations.standardDeviation(CalculationsHelper.colorArr, CalculationsHelper.colorMean);

        }
    }
}
using JacksParkingBackEnd;
namespace JacksParking_UnitTests
{
    public class ParkingSpotUnitTests
    {
        [Fact]
        public void CalculatexRangeWithBiggerTopXValue()
        {
            ParkingSpot TestSpot = new ParkingSpot(119, 325, 35, 358, false);
            Assert.Equal(84, TestSpot.GetXRange());
        }
        [Fact]
        public void CalculatexRangeWithSmallerTopXValue()
        {
            ParkingSpot TestSpot = new ParkingSpot(518, 320, 584, 358, true);
            Assert.Equal(66, TestSpot.GetXRange());
        }
        [Fact]
        public void CalculateLength()
        {
            ParkingSpot TestSpot = new ParkingSpot(518, 320, 584, 358, true);
            Assert.Equal(76, TestSpot.GetLength());
        }
        [Fact]
        public void CalculatePositiveSlope()
        {
            ParkingSpot TestSpot = new ParkingSpot(518, 320, 584, 358, true);
            Assert.Equal(0.5757576, TestSpot.GetSlope());
        }
        [Fact]
        public void CalculateNegativeSlope()
        {
            ParkingSpot TestSpot = new ParkingSpot(119, 325, 35, 358, false);
            Assert.Equal(-0.3928571, TestSpot.GetSlope());
        }
        [Fact]
        public void CalculateyIntercept()
        {
            ParkingSpot TestSpot = new ParkingSpot(119, 325, 35, 358, false);
            Assert.Equal(371.75, Math.Round(TestSpot.GetYIntercept(), 2));
        }
    }
}
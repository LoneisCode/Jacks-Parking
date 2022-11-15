using JacksParkingBackEnd;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace JacksParkingBackEndTest
{
    public class ParkingLotTests
    {
        [Fact]
        public void CalculateCorrectSpotsStatus()
        {

            ParkingSpot[] spots = new ParkingSpot[6];
            spots[0] = new ParkingSpot(119, 325, 35, 358, false); // Spot 1, empty 
            spots[1] = new ParkingSpot(446, 325, 515, 359, true); // Spot 12, empty
            spots[2] = new ParkingSpot(182, 326, 125, 358, false); // Spot 3, taken
            spots[3] = new ParkingSpot(284, 324, 243, 358, false); // Spot 6, taken
            spots[4] = new ParkingSpot(381, 324, 362, 358, false); // Spot 9, empty
            spots[5] = new ParkingSpot(477, 324, 551, 358, true); // Spot 13, taken

            Bitmap Village = new Bitmap(Constants.villageJPGImagePath);
            ParkingLot village = new ParkingLot(Constants.villageJPGImagePath, spots, Village);

            bool[] actualValues = new bool[6];

            for (int i = 0; i < spots.Length; i++)
            {

                bool available = true;

                double meanR = spots[i].GetRed().Average();
                double meanG = spots[i].GetGreen().Average();
                double meanB = spots[i].GetBlue().Average();

                // First empty spot with sun and shade.
                double lowerBoundR = village.GetConfidenceIntRed()[0];
                double upperBoundR = village.GetConfidenceIntRed()[1];
                double lowerBoundG = village.GetConfidenceIntGreen()[0];
                double upperBoundG = village.GetConfidenceIntGreen()[1];
                double lowerBoundB = village.GetConfidenceIntBlue()[0];
                double upperBoundB = village.GetConfidenceIntBlue()[1];

                // Second empty spot with all shade.
                double lowerBoundR2 = village.GetConfidenceIntRed2()[0];
                double upperBoundR2 = village.GetConfidenceIntRed2()[1];
                double lowerBoundG2 = village.GetConfidenceIntGreen2()[0];
                double upperBoundG2 = village.GetConfidenceIntGreen2()[1];
                double lowerBoundB2 = village.GetConfidenceIntBlue2()[0];
                double upperBoundB2 = village.GetConfidenceIntBlue2()[1];

                // Check if R value average is similar to R value for an 
                // empty spot with sun and shade. If is out of bounds, 
                // set availability to false, but double check by comparing
                // R value average to R value for an empty spot with all shade.
                if ((meanR < lowerBoundR) || (meanR > upperBoundR))
                {
                    available = false;

                    if ((meanR > lowerBoundR2) && (meanR < upperBoundR2))
                    {
                        System.Diagnostics.Debug.WriteLine("red is not in the bounds");
                        available = true;
                    }
                }

                // Check if R value average is similar to G value for an 
                // empty spot with sun and shade. If is out of bounds, 
                // set availability to false, but double check by comparing
                // R value average to G value for an empty spot with all shade.
                if ((meanG < lowerBoundG) || (meanG > upperBoundG))
                {
                    available = false;

                    if ((meanG > lowerBoundG2) && (meanG < upperBoundG2))
                    {
                        System.Diagnostics.Debug.WriteLine("green is not in the bounds");
                        available = true;
                    }
                }

                // Check if R value average is similar to B value for an 
                // empty spot with sun and shade. If is out of bounds, 
                // set availability to false, but double check by comparing
                // R value average to B value for an empty spot with all shade.
                if ((meanB < lowerBoundB) || (meanB > upperBoundB))
                {
                    available = false;

                    if ((meanB > lowerBoundB2) && (meanB < upperBoundB2))
                    {
                        System.Diagnostics.Debug.WriteLine("blue is not in the bounds");
                        available = true;
                    }
                }

                actualValues[i] = available;
            }

            Assert.True(actualValues[0]);
            Assert.True(actualValues[1]);
            Assert.False(actualValues[2]);
            Assert.False(actualValues[3]);
            Assert.True(actualValues[4]);
            Assert.False(actualValues[5]);



        }
    }
}

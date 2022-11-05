using System.Drawing;
using System.Linq;
using System;

namespace JacksParkingBackEnd
{
    public class ParkingLot
    {
        private ParkingSpot[] spots;
        // This will be the stream or something later.
        private string imagePath; 
        Bitmap lot;
        
        // Empty spot confidence intervals.
        private double[] confidenceIntRed;
        private double[] confidenceIntGreen;
        private double[] confidenceIntBlue;

        // Constructor 
        public ParkingLot(string imagePath, ParkingSpot[] spots, Bitmap lot)
        {
            this.imagePath = imagePath;
            this.spots = spots;
            this.lot = lot;

            SetRGB();

            // Creating empty parking spot confidence interval.
            this.confidenceIntRed = Calculations.ConfidenceInterval(spots[0].getRed());
            this.confidenceIntGreen = Calculations.ConfidenceInterval(spots[0].getGreen());
            this.confidenceIntBlue = Calculations.ConfidenceInterval(spots[0].getBlue());
        }

        // For each parking spot, get the red, green, and blue component values.
        public void SetRGB()
        {
            for (int i = 0; i < this.spots.Length; i++)
            {
                spots[i].setR(Bitmapping.GetR(spots[i], lot)); // Red
                spots[i].setG(Bitmapping.GetG(spots[i], lot)); // Green
                spots[i].setB(Bitmapping.GetB(spots[i], lot)); // Blue
            }
        }

        public string GetImagePath()
        {
            return imagePath;
        }

        public Bitmap GetBitmap()
        {
            return lot;
        }

        public ParkingSpot[] GetSpots()
        {
            return this.spots;
        }

        // Returns the total number of available parking spots 
        // in a parking lot.
        public int? SpotsStatus()
        {
            // Stores total spots.
            // Decrements as they fall "out" of the confidence intervals.
            int availableSpots = spots.Length;
            
            try
            {
                for(int i = 0; i < spots.Length; i++) { 

                    bool available = true;
                    
                    double meanR = spots[i].getRed().Average();
                    double meanG = spots[i].getGreen().Average();
                    double meanB = spots[i].getBlue().Average();

                    double lowerBoundR = confidenceIntRed[0];
                    double upperBoundR = confidenceIntRed[1];
                    double lowerBoundG = confidenceIntGreen[0];
                    double upperBoundG = confidenceIntGreen[1];
                    double lowerBoundB = confidenceIntBlue[0];
                    double upperBoundB = confidenceIntBlue[1];

                    if ((meanR < lowerBoundR) || (meanR > upperBoundR))
                    {
                        System.Diagnostics.Debug.WriteLine("red is not in the bounds");
                        available = false;
                    }

                    else if ((meanG < lowerBoundG) || (meanG > upperBoundG))
                    {
                        System.Diagnostics.Debug.WriteLine("green is not in the bounds");
                        available = false;
                    }

                    else if ((meanB < lowerBoundB) || (meanB > upperBoundB))
                    {
                        System.Diagnostics.Debug.WriteLine("blue is not in the bounds");
                        available = false;
                    }

                    if(!available)
                        availableSpots--;                
                }             
                return availableSpots;
            }
            catch (ArgumentNullException e)
            {
                System.Diagnostics.Debug.WriteLine("RBG array is null or value at index i is null.");
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
            return null;            
        }

    }
}

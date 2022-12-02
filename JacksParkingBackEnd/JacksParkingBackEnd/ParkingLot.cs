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

        // Empty spot confidence intervals for shadows
        private double[] confidenceIntRed2;
        private double[] confidenceIntGreen2;
        private double[] confidenceIntBlue2;

        // Constructor 
        public ParkingLot(string imagePath, ParkingSpot[] spots, Bitmap lot)
        {
            this.imagePath = imagePath;
            this.spots = spots;
            this.lot = lot;

            SetRGB();

            // Creating empty parking spot confidence interval.
            this.confidenceIntRed = Calculations.ConfidenceInterval(spots[0].GetRed());
            this.confidenceIntGreen = Calculations.ConfidenceInterval(spots[0].GetGreen());
            this.confidenceIntBlue = Calculations.ConfidenceInterval(spots[0].GetBlue());
            this.confidenceIntRed2 = Calculations.ConfidenceInterval(spots[1].GetRed());
            this.confidenceIntGreen2 = Calculations.ConfidenceInterval(spots[1].GetGreen());
            this.confidenceIntBlue2 = Calculations.ConfidenceInterval(spots[1].GetBlue());
        }

        // For each parking spot, get the red, green, and blue component values.
        public void SetRGB()
        {
            for (int i = 0; i < this.spots.Length; i++)
            {
                spots[i].SetR(Bitmapping.GetR(spots[i], lot)); // Red
                spots[i].SetG(Bitmapping.GetG(spots[i], lot)); // Green
                spots[i].SetB(Bitmapping.GetB(spots[i], lot)); // Blue
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

        public double[] GetConfidenceIntRed() 
        {
            return this.confidenceIntRed;
        }
        public double[] GetConfidenceIntGreen()
        {
            return this.confidenceIntGreen;
        }
        public double[] GetConfidenceIntBlue()
        {
            return this.confidenceIntBlue;
        }
        public double[] GetConfidenceIntRed2()
        {
            return this.confidenceIntRed2;
        }
        public double[] GetConfidenceIntGreen2()
        {
            return this.confidenceIntGreen2;
        }
        public double[] GetConfidenceIntBlue2()
        {
            return this.confidenceIntBlue2;
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
                    
                    double meanR = spots[i].GetRed().Average();
                    double meanG = spots[i].GetGreen().Average();
                    double meanB = spots[i].GetBlue().Average();

                    // First empty spot with sun and shade.
                    double lowerBoundR = confidenceIntRed[0];
                    double upperBoundR = confidenceIntRed[1];
                    double lowerBoundG = confidenceIntGreen[0];
                    double upperBoundG = confidenceIntGreen[1];
                    double lowerBoundB = confidenceIntBlue[0];
                    double upperBoundB = confidenceIntBlue[1];

                    // Second empty spot with all shade.
                    double lowerBoundR2 = confidenceIntRed2[0];
                    double upperBoundR2 = confidenceIntRed2[1];
                    double lowerBoundG2 = confidenceIntGreen2[0];
                    double upperBoundG2 = confidenceIntGreen2[1];
                    double lowerBoundB2 = confidenceIntBlue2[0];
                    double upperBoundB2 = confidenceIntBlue2[1];

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


                    if (!available)
                    {
                        availableSpots--;
                    }
                        
                }

                SQLiteConnection sqlite_conn;
                sqlite_conn = Accessdb.CreateConnection();
                Accessdb.UpdateSpacesOccupied(sqlite_conn, availableSpots, 1);

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

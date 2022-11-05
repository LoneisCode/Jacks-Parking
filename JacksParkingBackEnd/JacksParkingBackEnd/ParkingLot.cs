using System.Drawing;
using System.Linq;
using System;

namespace JacksParkingBackEnd
{
    public class ParkingLot
    {
        private ParkingSpot[] spots;
        private string imagePath; //this will be the stream or something later
        Bitmap lot;
        //empty spot confidence intervals
        private double[] confidenceIntRed;
        private double[] confidenceIntGreen;
        private double[] confidenceIntBlue;


        public ParkingLot(string imagePath, ParkingSpot[] spots, Bitmap lot)
        {
            this.imagePath = imagePath;
            this.spots = spots;
            this.lot = lot;

            setRGB();
            //creating empty parking spot confidence interval
            this.confidenceIntRed = Calculations.ConfidenceInterval(spots[0].getRed());
            this.confidenceIntGreen = Calculations.ConfidenceInterval(spots[0].getGreen());
            this.confidenceIntBlue = Calculations.ConfidenceInterval(spots[0].getBlue());
        }

        public void setRGB()
        {
            for (int i = 0; i < this.spots.Length; i++)
            {
                spots[i].setR(Bitmapping.getR(spots[i], lot)); //Red
                spots[i].setG(Bitmapping.getG(spots[i], lot));//Green
                spots[i].setB(Bitmapping.getB(spots[i], lot));//Blue
            }
        }

        public string getImagePath()
        {
            return imagePath;
        }

        public Bitmap GetBitmap()
        {
            return lot;
        }

        public ParkingSpot[] getSpots()
        {
            return this.spots;
        }

        //returns a total of available spots
        public int? spotsStatus()
        {
            //stores total spots, decrements as they fall "out" of the confidence intervals
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

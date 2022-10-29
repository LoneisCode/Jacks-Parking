using System.Drawing;

namespace JacksParkingBackEnd
{
    public class ParkingLot
    {
        private ParkingSpot[] spots;
        private string imagePath; //this will be the stream or something later
        Bitmap lot;
        private double[] confidenceIntRed;
        private double[] confidenceIntBlue;
        private double[] confidenceIntGreen;


        public ParkingLot(string imagePath, ParkingSpot[] spots, Bitmap lot)
        {
            this.imagePath = imagePath;
            this.spots = spots;
            this.lot = lot;

            //creating empty parking spot confidence interval
            this.confidenceIntRed = Calculations.confidenceInterval(spots[0].getRed());
            this.confidenceIntGreen = Calculations.confidenceInterval(spots[0].getGreen());
            this.confidenceIntBlue = Calculations.confidenceInterval(spots[0].getBlue());
        }

        public void setRGB()
        {
            for (int i = 0; i < this.spots.Length; i++)
            {
                spots[i].setR(Bitmapping.getR(spots[i], lot)); //Red
                //Green
                //Blue
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

        public 

        //public bool spotStatus(ParkingSpot spot)
        //{
        //    if()
        //}
    }
}

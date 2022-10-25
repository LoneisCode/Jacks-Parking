using System.Drawing;

namespace JacksParkingBackEnd
{
    public class ParkingLot : ParkingLotInterface
    {
        private ParkingSpot[] spots;
        private string imagePath; //this will be the stream or something later
        Bitmap lot;


        public ParkingLot(string imagePath, ParkingSpot[] spots, Bitmap lot)
        {
            this.imagePath = imagePath;
            this.spots = spots;
            this.lot = lot;
        }

        public string getImagePath()
        {
            return imagePath;
        }

    }
}
